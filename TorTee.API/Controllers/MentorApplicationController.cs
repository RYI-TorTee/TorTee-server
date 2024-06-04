using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MentorApplicationController : BaseApiController
    {
        private readonly IMentorApplicationService _mentorApplicationService;

        public MentorApplicationController(IMentorApplicationService mentorApplicationService)
        {
            _mentorApplicationService = mentorApplicationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMentorApplication([FromForm]CreateMentorApplicationRequest request)
        {
            return await ExecuteServiceLogic(
                async () => await _mentorApplicationService.CreateMentorApplication(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllApplications([FromQuery] MentorApplicationRequest request)
        {
            return await ExecuteServiceLogic(
                async () => await _mentorApplicationService.GetAllApplications(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplication(Guid id)
        {
            return await ExecuteServiceLogic(
                async () => await _mentorApplicationService.GetApplication(id).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }
    }
}
