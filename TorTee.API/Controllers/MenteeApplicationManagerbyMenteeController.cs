using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{

    [ApiController]
    [Route("api/MenteeApplication-Manager-by-Mentee")]
    public class MenteeApplicationManagerbyMentee : BaseApiController
    {
        private readonly IMentorPlanService _mentorPlanService;
        private readonly IMenteeApplicationService _menteeApplicationService;
        private readonly ILogger<MenteeApplicationManagerbyMentee> _logger;

        public MenteeApplicationManagerbyMentee(
            IMentorPlanService mentorPlanService,
            IMenteeApplicationService menteeApplicationService,
            ILogger<MenteeApplicationManagerbyMentee> logger)
        {
            _mentorPlanService = mentorPlanService;
            _menteeApplicationService = menteeApplicationService;
            _logger = logger;
        }


  


        [HttpGet("GetAll-MentorPlan-By-MentorId")]
        public async Task<IActionResult> GetMentorPlanPagingByMenteeId(Guid id, [FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
           async () => await _menteeApplicationService.GetAllPaging(request, id).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }


        [HttpGet("Get-MenteePlan-By-MenteePlanId")]
        public async Task<ActionResult<IEnumerable<MenteePlanRequestModel>>> GetMenteePlanByMenteePlanId(Guid id)
        {
            try
            {
                var menteePlan = _mentorPlanService.GetOneById(id);
                if (menteePlan == null)
                {
                    return NotFound();
                }
                return Ok(menteePlan);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all MenteePlan for by id.");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
