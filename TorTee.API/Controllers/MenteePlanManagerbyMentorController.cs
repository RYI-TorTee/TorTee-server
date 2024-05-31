using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{

    [ApiController]
    [Route("api/MenteePlan-Manager-by-Mentor")]
    public class MenteePlanManagerbyMentorController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;
        private readonly IUserSkillService _userSkillService;
        private readonly IBookingPlanService _bookingPlanService;
        private readonly IMentorPlanService _mentorPlanService;
        private readonly IApplicationQuestionService _applicationQuestionService;
        private readonly IMenteeApplicationAnswerService _menteeApplicationAnswerService;
        private readonly IMenteeApplicationService _menteeApplicationService;
        private readonly ILogger<MenteeApplicationManagerbyMentee> _logger;

        public MenteePlanManagerbyMentorController(
            IMentorUserService mentorUserService,
            IUserSkillService userSkillService,
            IBookingPlanService bookingPlanService,
            IMentorPlanService mentorPlanService,
            IApplicationQuestionService applicationQuestionService,
            IMenteeApplicationAnswerService menteeApplicationAnswerService,
            IMenteeApplicationService menteeApplicationService,
            ILogger<MenteeApplicationManagerbyMentee> logger)
        {
            _mentorUserService = mentorUserService;
            _userSkillService = userSkillService;
            _bookingPlanService = bookingPlanService;
            _mentorPlanService = mentorPlanService;
            _applicationQuestionService = applicationQuestionService;
            _menteeApplicationAnswerService = menteeApplicationAnswerService;
            _menteeApplicationService = menteeApplicationService;
            _logger = logger;
        }

        // GET: api/Booking-Feature/GetAllMentorPlanMentorById/{id}
        [HttpGet("GetAllMentorPlanMentorById")]
        public async Task<ActionResult<MenteePlanRequestModel>> GetAllMentorPlanMentorById(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var mentorPlans = _mentorPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (mentorPlans == null)
                {
                    return NotFound();
                }
                return Ok(mentorPlans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all mentor plans for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // POST: api/Booking-Feature/AddMenteeApplication
        [HttpPost("AddMenteePlan")]
        public async Task<ActionResult> AddMenteePlan([FromBody] MenteePlanCreateRequestModel menteePlan)
        {
            if (menteePlan == null)
            {
                return BadRequest("Mentee application is null.");
            }

            try
            {
                menteePlan.Status = TorTee.Core.Domains.Enums.MenteePlanStatus.AVAILABLE;
                await _mentorPlanService.Add(menteePlan);
                return StatusCode(201, "Add sussecc full" + menteePlan);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding mentee application.");
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/Booking-Feature/UpdateStatusMenteeApplication/{id}
        [HttpPut("UpdateStatusMenteeApplication")]
        public async Task<ActionResult> UpdateStatusMenteeApplication([FromBody] MenteePlanUpdateRequestModel application)
        {
            if (application == null)
            {
                return BadRequest("Invalid application data.");
            }

            try
            {
                var existingMentorPlanService = await _mentorPlanService.GetOne(application.Id);
                if (existingMentorPlanService == null)
                {
                    return NotFound("Mentee application not found.");
                }
                application.Status = TorTee.Core.Domains.Enums.MenteePlanStatus.AVAILABLE;
                await _mentorPlanService.Update(application);
                return Ok(new { message = "Mentee application status updated successfully.", application });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating mentee application status.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetAllMentorPlanMentorById/{id}
        [HttpGet("GetMentorPlanById")]
        public async Task<ActionResult<MenteePlanRequestModel>> GetMentorPlanById(Guid id)
        {
            try
            {
                var mentorPlans = _mentorPlanService.GetOneById(id);
                if (mentorPlans == null)
                {
                    return NotFound();
                }
                return Ok(mentorPlans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all mentor plans for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
