using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorService
    {
        Task<ServiceActionResult> BrowseMentorList(QueryParametersRequest queryParameters);
        Task<ServiceActionResult> RecommendationMentorList(PagingRequest request);
    }
}
