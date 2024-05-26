using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Messages;

namespace TorTee.BLL.Services.IServices
{
    public interface IMessageService
    {
        Task<ServiceActionResult> CreateMessage(CreateMessageRequest request, Guid userId);

        Task<ServiceActionResult> GetMessageForUser(MessageParams messageParams, Guid userId);
    }
}
