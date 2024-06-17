using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Messages;

namespace TorTee.BLL.Services.IServices
{
    public interface IMessageService
    {
        Task<ServiceActionResult> SendMessage(CreateMessageRequest request, Guid userId);
        Task<ServiceActionResult> GetMessagesOfAChat(ChatBoxParams messageParams, Guid userId);
        Task<ServiceActionResult> GetMyChatBoxs(Guid userId);
        Task<ServiceActionResult> SearchChat(string search);
    }
}
