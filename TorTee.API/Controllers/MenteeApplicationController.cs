using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Constants;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class MenteeApplicationController : BaseApiController
    {
        private readonly IMenteeApplicationService _menteeApplicationService;
        private readonly IUserClaimsService _userClaimsService;
        private UserClaims _userClaims;

        public MenteeApplicationController(IMenteeApplicationService menteeApplicationService, IUserClaimsService userClaimsService)
        {
            _menteeApplicationService = menteeApplicationService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        /// <summary>
        /// send apply to mentor
        /// </summary>
        /// <returns></returns>
         [HttpPost("mentee/apply")]
        [Authorize(Roles = UserRoleConstants.MENTEE)]
        public async Task<IActionResult> ApplyToMentor(CreateMenteeApplicationRequest request)
        {
            var userId = _userClaims.UserId;
            return await ExecuteServiceLogic(
            async () =>  await _menteeApplicationService.CreateMenteeApplication(request, userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// all application mentor received
        /// </summary>
        /// <returns></returns>
        [HttpGet("mentor/applications")]
        [Authorize(Roles = UserRoleConstants.MENTOR)]
        public async Task<IActionResult> AllApplicationReceived()
        {
            var userId = _userClaims.UserId;
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetAllMenteeApplicationsReceived(userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// accepted, denied application
        /// </summary>
        /// <returns></returns>
        [HttpPut("mentor/update-application")]
        [Authorize(Roles = UserRoleConstants.MENTOR)]
        public async Task<IActionResult> UpdateApplicationReceived(UpdateMenteeApplicationRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.UpdateMenteeApplicationStatus(request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// Get all my application to make payment
        /// </summary>
        /// <returns></returns>
        [HttpGet("mentee/applications")]
        [Authorize(Roles = UserRoleConstants.MENTEE)]
        public async Task<IActionResult> AllApplicationSent()
        {
            var userId = _userClaims.UserId;
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetAllMenteeApplicationsSent(userId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        /// <summary>
        /// Get application Details
        /// </summary>
        /// <returns></returns>
        [HttpGet("application/{id}")]
        [Authorize]
        public async Task<IActionResult> ApplicationDetail(Guid id)
        {           
            return await ExecuteServiceLogic(
            async () => await _menteeApplicationService.GetMenteeApplicationDetails(id).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

    }
}
