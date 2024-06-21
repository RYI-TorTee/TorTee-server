using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Feedbacks;

namespace TorTee.BLL.Services.IServices
{
    public interface IFeedbackService
    {
        Task<ServiceActionResult> GetAllFeedbacksOfAMentor(Guid mentorId, PagingRequest request);
        Task<ServiceActionResult> AddFeedback(FeedbackRequest request, Guid mentorId);
        Task<ServiceActionResult> GetAllMentorForFeedback(Guid menteeId);

    }
}
