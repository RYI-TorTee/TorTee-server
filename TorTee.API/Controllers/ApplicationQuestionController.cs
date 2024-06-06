using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class ApplicationQuestionController : BaseApiController
    {
        private readonly IApplicationQuestionService _questionService;

        public ApplicationQuestionController(IApplicationQuestionService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllQuestions()
        {
            return await ExecuteServiceLogic(
                async () => await _questionService.GetAllQuestions().ConfigureAwait(false)
            ).ConfigureAwait(false);
        }
    }
}
