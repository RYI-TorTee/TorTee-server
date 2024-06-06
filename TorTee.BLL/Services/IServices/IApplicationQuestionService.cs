using TorTee.BLL.Models;

namespace TorTee.BLL.Services.IServices
{

    public interface IApplicationQuestionService
    {
        Task<ServiceActionResult> GetAllQuestions();
    }
}
