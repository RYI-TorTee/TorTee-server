using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Concurrent;
using TorTee.BLL.Models.Responses.Messages;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.SignalR
{
    [Authorize]
    public class MessageHub : Hub
    {
        private static readonly ConcurrentDictionary<string, string> _userConnections = new ConcurrentDictionary<string, string>();
        private readonly IMessageService _messageService;

        public MessageHub(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public override async Task OnConnectedAsync()
        {
            var userId = Context.UserIdentifier;
            if (userId != null)
            {
                _userConnections[userId] = Context.ConnectionId;
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = Context.UserIdentifier;
            if (userId != null)
            {
                _userConnections.TryRemove(userId, out _);
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(Guid receiverId, string message)
        {
            Guid.TryParse(Context.UserIdentifier, out Guid senderId);

            var data = await _messageService.SendMessage(new BLL.Models.Requests.Messages.CreateMessageRequest
            {
                ReceiverId = receiverId,
                Content = message
            }, senderId);

            await Clients.Caller.SendAsync("ReceiveMessage", data.Data);

            var isReceiverOnline = _userConnections.TryGetValue(receiverId.ToString(), out string receiverConnectionId);
            if (isReceiverOnline)
            {
                var messageReaponseToReceiver = (MessageResponse)data.Data;
                messageReaponseToReceiver.IsSentByCurrentUser = false;
                await Clients.Client(receiverConnectionId!).SendAsync("ReceiveMessage", messageReaponseToReceiver);
            }            
        }
    }
}
