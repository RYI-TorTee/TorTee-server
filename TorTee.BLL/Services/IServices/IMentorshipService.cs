using TorTee.BLL.Models;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorshipService
    {
        Task<ServiceActionResult> GetMyMentors(Guid menteeId);
        Task<ServiceActionResult> GetMyMentees(Guid mentorId);
    }
}
