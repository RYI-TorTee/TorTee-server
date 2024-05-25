using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests;
using TorTee.BLL.Services;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;

namespace TorTee.API.Controllers
{
    public class MentorController : BaseApiController
    {
        private readonly IMentorService _mentorService;
        public MentorController(IMentorService mentorService)
        {
            _mentorService = mentorService;
        }

        [HttpGet("browse-mentor")]
        public async Task<IActionResult> GetMentorList([FromQuery] QueryParametersRequest queryParametersRequest)
        {
            return await ExecuteServiceLogic(
            async () => await _mentorService.BrowseMentorList(queryParametersRequest).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpGet("recommendation")]
        public async Task<IActionResult> GetRecommendedMetor([FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
           async () => await _mentorService.RecommendationMentorList(request).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }
    }
}
