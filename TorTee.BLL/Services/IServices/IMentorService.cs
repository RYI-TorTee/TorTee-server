using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorService
    {
        Task<ServiceActionResult> BrowseMentorList(QueryParametersRequest queryParameters);
        Task<ServiceActionResult> RecommendationMentorList(PagingRequest request);
        Task<ServiceActionResult> GetMyMentors(Guid menteeId);
        Task<ServiceActionResult> GetMyMentees(Guid mentorId);
    }
}
