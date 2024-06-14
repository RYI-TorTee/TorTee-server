using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TorTee.API.SignalR;
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
        private readonly IHubContext<MessageHub> _hubContext;
        public MessageService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

           // await _hubContext.Clients.User(receiver.Id.ToString())
           //.SendAsync("ReceiveMessage", returnMessage);
        public async Task<ServiceActionResult> SendMessage(CreateMessageRequest request, Guid userId)
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


            return new ServiceActionResult(true);
        }


        public async Task<ServiceActionResult> GetMessagesOfAChat(ChatBoxParams messageParams, Guid currentUserId)
        {
            var messagesQuery = (await _unitOfWork.MessageRepository.GetAllAsyncAsQueryable())
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => (m.SenderId == currentUserId && m.ReceiverId == messageParams.ChatPartnerId) ||
                            (m.SenderId == messageParams.ChatPartnerId && m.ReceiverId == currentUserId))
                .OrderBy(m => m.SentTime)
                .AsQueryable();

            var messages = await messagesQuery
                .Skip((messageParams.PageIndex - 1) * messageParams.PageSize ?? 0)
                .Take(messageParams.PageSize ?? 0)
                .Select(m => new MessageResponse
                {
                    Content = m.Content,
                    SenderPhotoUrl = m.Sender.ProfilePic ?? "",
                    SenderName = m.Sender.FullName,
                    SentTime = m.SentTime,
                    IsSentByCurrentUser = m.SenderId == currentUserId
                }).ToListAsync();

            return new ServiceActionResult
            {
                Data = messages
            };
        }

        public async Task<ServiceActionResult> GetMyChatBoxs(Guid currentUserId)
        {
            var chatBoxes = (await _unitOfWork.MessageRepository.GetAllAsyncAsQueryable())
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .Where(m => m.SenderId == currentUserId || m.ReceiverId == currentUserId)
                .GroupBy(m => m.SenderId == currentUserId ? m.ReceiverId : m.SenderId)
                .Select(g => new ChatBoxResponse
                {
                    CurrentUserId = currentUserId,
                    ChatPartnerId = g.Key,
                    ChatPartnerName = g.First().SenderId == currentUserId ? g.First().Receiver.FullName : g.First().Sender.FullName,
                    Messages = g.OrderBy(m => m.SentTime)
                .Take(1).Select(m => new MessageResponse
                {
                    Content = m.Content,
                    SenderPhotoUrl = m.Sender.ProfilePic ?? "",
                    SenderName = m.Sender.FullName,
                    SentTime = m.SentTime,
                    IsSentByCurrentUser = m.SenderId == currentUserId
                }).OrderBy(m => m.SentTime).ToList()
                }).ToList();

            return new ServiceActionResult() { Data = chatBoxes };
        }
    }
}
