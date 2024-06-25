using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Feedbacks;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Constants;

namespace TorTee.API.Controllers
{
    public class FeedbackController : BaseApiController
    {
        private readonly IFeedbackService _feedbackService;
        private readonly UserClaims _userClaims;
        private readonly IUserClaimsService _userClaimsService;

        public FeedbackController(IFeedbackService feedbackService, IUserClaimsService userClaimsService)
        {
            _feedbackService = feedbackService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpGet("send-feedback")]
        [Authorize(Roles = UserRoleConstants.MENTEE)]
        public async Task<IActionResult> GetAllMentorForFeedback()
        {
            return await ExecuteServiceLogic(
                               async () => await _feedbackService.GetAllMentorForFeedback(_userClaims.UserId).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpPost("send-feedback")]
        [Authorize(Roles = UserRoleConstants.MENTEE)]
        public async Task<IActionResult> CreateFeedback(FeedbackRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _feedbackService.AddFeedback(request, _userClaims.UserId).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpGet("{mentorId}")]
        public async Task<IActionResult> GetFeedbacksOfAMentor(Guid mentorId, [FromQuery] PagingRequest pagingRequest)
        {
            return await ExecuteServiceLogic(
                               async () => await _feedbackService.GetAllFeedbacksOfAMentor(mentorId, pagingRequest).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }
    }
}
