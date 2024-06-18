﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

           
        public async Task<ServiceActionResult> SendMessage(CreateMessageRequest request, Guid userId)
        {
            var currentUser = userId;

            var sender = await _unitOfWork.UserRepository.GetAsync(u => u.Id == currentUser) ?? throw new UserNotFoundException();
            var receiver = await _unitOfWork.UserRepository.GetAsync(u => u.Id == request.ReceiverId) ?? throw new UserNotFoundException();

            var messageEntity = _mapper.Map<Message>(request);
            messageEntity.Sender = sender;
            messageEntity.Receiver = receiver;
            messageEntity.SentTime = DateTime.Now;            

            await _unitOfWork.MessageRepository.AddAsync(messageEntity);
            await _unitOfWork.CommitAsync();

            var returnMessage = _mapper.Map<MessageResponse>(messageEntity);

            return new ServiceActionResult() { Data = returnMessage};
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
                //.Skip((messageParams.PageIndex - 1) * messageParams.PageSize ?? 0)
                //.Take(messageParams.PageSize ?? 0)
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
                    Messages = g.OrderByDescending(m => m.SentTime)
                .Take(1).Select(m => new MessageResponse
                {
                    Content = m.Content,
                    SenderPhotoUrl = m.Sender.ProfilePic ?? "",
                    SenderName = m.Sender.FullName,
                    SentTime = m.SentTime,
                    IsSentByCurrentUser = m.SenderId == currentUserId
                }).OrderByDescending(m => m.SentTime).ToList()
                }).ToList();

            return new ServiceActionResult() { Data = chatBoxes };
        }

        public async Task<ServiceActionResult> SearchChat(string search)
        {
            var users = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                .Where(u => u.FullName.ToLower().Contains(search.ToLower()));

            return new ServiceActionResult() { Data = _mapper.ProjectTo<ChatBoxResponse>(users)};
        }

    }
}
