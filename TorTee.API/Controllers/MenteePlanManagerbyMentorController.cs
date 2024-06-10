using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Services;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{

    [ApiController]
    [Route("api/MenteePlan-Manager-by-Mentor")]
    public class MenteePlanManagerbyMentorController : BaseApiController
    {
  
        private readonly IMentorPlanService _mentorPlanService;

        private readonly ILogger<MenteeApplicationManagerbyMentee> _logger;

        public MenteePlanManagerbyMentorController(
    
            IMentorPlanService mentorPlanService,
 
            ILogger<MenteeApplicationManagerbyMentee> logger)
        {
            
            _mentorPlanService = mentorPlanService;
    
            _logger = logger;
        }



        [HttpGet("GetAll-MentorPlan-By-MentorId")]
        public async Task<IActionResult> GetMentorApplicationPaging(Guid id,[FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
           async () => await _mentorPlanService.GetAllPaging(request,id).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }


        // POST: api/Booking-Feature/AddMenteeApplication
        [HttpPost("Add-MenteePlan")]
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
        [HttpPut("Update-Status-MenteeApplication")]
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

        // GET: api/GetAllMentorPlanMentorById
        [HttpGet("Get-MentorPlan-By-MentorPlanId")]
        public async Task<ActionResult<MenteePlanRequestModel>> GetMentorPlanById(Guid id)
        {
            try
            {
                var mentorPlans =  _mentorPlanService.GetOneById(id);
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
