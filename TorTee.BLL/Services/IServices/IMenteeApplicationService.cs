using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplications;

namespace TorTee.BLL.Services.IServices
{
    public interface IMenteeApplicationService
    {
        Task<ServiceActionResult> CreateMenteeApplication(CreateMenteeApplicationRequest request, Guid currentUserId);
        Task<ServiceActionResult> GetAllMenteeApplicationsSent(Guid menteeId);
        Task<ServiceActionResult> GetAllMenteeApplicationsReceived(Guid mentorId);
        Task<ServiceActionResult> GetMenteeApplicationDetails(Guid Id);
        Task<ServiceActionResult> UpdateMenteeApplicationStatus(UpdateMenteeApplicationRequest request);
    }
}
