using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class MenteeApplicationController : BaseApiController
    {
        private readonly IMenteeApplicationService _menteeApplicationService;

        public MenteeApplicationController(IMenteeApplicationService menteeApplicationService)
        {
            _menteeApplicationService = menteeApplicationService;
        }

        /// <summary>
        /// send apply to mentor
        /// </summary>
        /// <returns></returns>
         [HttpPost("mentee/apply")]
        public async Task<IActionResult> ApplyToMentor(CreateMenteeApplicationRequest request)
        {
            var userId = new Guid();
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.CreateMenteeApplication(request, userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// all application mentor received
        /// </summary>
        /// <returns></returns>
        [HttpGet("mentor/applications")]
        public async Task<IActionResult> AllApplicationReceived()
        {
            var userId = new Guid();
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetAllMenteeApplicationsReceived(userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// accepted, denied application
        /// </summary>
        /// <returns></returns>
        [HttpPut("mentor/update-application")]
        public async Task<IActionResult> UpdateApplicationReceived(UpdateMenteeApplicationRequest request)
        {
            var userId = new Guid();
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.UpdateMenteeApplicationStatus(request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all my application to make payment
        /// </summary>
        /// <returns></returns>
        [HttpGet("mentee/applications")]
        public async Task<IActionResult> AllApplicationSent()
        {
            var userId = new Guid();
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetAllMenteeApplicationsSent(userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// Get application Details
        /// </summary>
        /// <returns></returns>
        [HttpGet("application/{id}")]
        public async Task<IActionResult> ApplicationDetail(Guid id)
        {           
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetMenteeApplicationDetails(id).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

    }
}
