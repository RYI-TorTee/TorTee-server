using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{

    [ApiController]
    [Route("api/Booking-Feature")]
    public class MenteeApplicationManagerbyMentee : ControllerBase
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


        // GET: api/Booking-Feature/GetAllBookingCallMentorById/{id}
        [HttpGet("GetListMenteeApplicationManagerByMentee")]
        public async Task<ActionResult<IEnumerable<MenteeApplicationRequestModel>>> GetListMenteeApplicationManagerByMentee(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var menteeApplicationRequestModel = _menteeApplicationService.GetListMenteeApplicationofMentee(id, search.currentPage, search.pageSize);
                if (menteeApplicationRequestModel == null)
                {
                    return NotFound();
                }
                return Ok(menteeApplicationRequestModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all MenteeApplicationRequestModel for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("GetMenteePlanByMenteePlanId")]
        public async Task<ActionResult<IEnumerable<MenteePlan>>> GetMenteePlanByMenteePlanId(Guid id)
        {
            try
            {
                var menteePlan = _mentorPlanService.GetOne(id);
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
