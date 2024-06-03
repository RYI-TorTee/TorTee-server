using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MentorApplications;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorApplicationService
    {
        Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest);
        Task<ServiceActionResult> GetAllApplications(QueryParametersRequest request);
        Task<ServiceActionResult> GetApplication(Guid id);
        Task<ServiceActionResult> ReviewApplication(Guid id, string status);
    }
}
