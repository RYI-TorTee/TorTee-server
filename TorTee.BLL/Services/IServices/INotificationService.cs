using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Notifications;

namespace TorTee.BLL.Services.IServices
{
    public interface INotificationService
    {
        Task<ServiceActionResult> CreateNotification(NotificationRequest request);
        Task<ServiceActionResult> GetAllPaging(Guid userId, PagingRequest request);
        Task<ServiceActionResult> CountUnreadNotification(Guid userId);
        Task<ServiceActionResult> ReadNotification(Guid userId);
    }
}
