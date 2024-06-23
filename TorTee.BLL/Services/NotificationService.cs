using AutoMapper;
using Azure.Core;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Notifications;
using TorTee.BLL.Models.Responses.Notifications;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Dtos;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class NotificationService : INotificationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NotificationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> CountUnreadNotification(Guid userId)
        {
            var currentUser = await _unitOfWork.UserRepository.FindAsync(userId) ?? throw new UserNotFoundException("Invalid user");
           
           var totalUnread = (await _unitOfWork.NotificationRepository.GetAllAsyncAsQueryable())
                .Where(n => n.ReceiverId == userId && n.Status == Core.Domains.Enums.MessageStatus.UNSEEN)
                .Count();

            return new ServiceActionResult(true) { Data = totalUnread };
        }

        public async Task<ServiceActionResult> CreateNotification(NotificationRequest request)
        {
            if (request.SenderId != null) { 
                var sender = await _unitOfWork.UserRepository.FindAsync(request.SenderId) ?? throw new UserNotFoundException("Invalid user");
            }
            if (request.ReceiverId != null) { 
                var receiverId = await _unitOfWork.UserRepository.FindAsync(request.ReceiverId) ?? throw new UserNotFoundException("Invalid user");
            }

            var noti = _mapper.Map<Notification>(request);
            await _unitOfWork.NotificationRepository.AddAsync(noti);
            await _unitOfWork.CommitAsync();

            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> GetAllPaging(Guid userId, PagingRequest request)
        {
            var currentUser = await _unitOfWork.UserRepository.FindAsync(userId) ?? throw new UserNotFoundException("Invalid user");
            var notifications = (await _unitOfWork.NotificationRepository.GetAllAsyncAsQueryable())
                .Where(n => n.ReceiverId == userId)
                .OrderByDescending(n => n.CreatedDate);
                
            return new ServiceActionResult(true) { Data = PaginationHelper.BuildPaginatedResult<Notification, NotificationResponse>
                (_mapper, notifications, request.PageSize, request.PageIndex)};
        }

        public Task<ServiceActionResult> ReadNotification(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
