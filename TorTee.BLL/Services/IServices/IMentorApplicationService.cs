using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorApplicationService
    {
        Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest);
    }
}
