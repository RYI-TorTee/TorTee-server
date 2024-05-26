using AutoMapper;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.Models.Responses.Messages;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MessageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceActionResult> CreateMessage(CreateMessageRequest request, Guid userId)
        {
            var currentUser = userId;

            var sender = await _unitOfWork.UserRepository.GetAsync(u => u.Id == currentUser) ?? throw new UserNotFoundException();
            var receiver = await _unitOfWork.UserRepository.GetAsync(u => u.Id == request.ReceiverId) ?? throw new UserNotFoundException();

            var messageEntity = _mapper.Map<Message>(request);
            messageEntity.Sender = sender;
            messageEntity.Receiver = receiver;

            await _unitOfWork.MessageRepository.AddAsync(messageEntity);
            await _unitOfWork.CommitAsync();

            var returnMessage = _mapper.Map<MessageResponse>(request);

            return new ServiceActionResult(true) { Data = returnMessage };
        }

        public Task<ServiceActionResult> GetMessageForUser(MessageParams messageParams, Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
