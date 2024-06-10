using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{
   
    [ApiController]
    [Route("api/Mentor-Application-Manager-By-Staff")]
    public class MentorApplicationManagerByStaff : BaseApiController
    {

        private readonly IStaffMentorApplicationService _staffMentorApplicationService;

        private readonly ILogger<MentorApplicationManagerByStaff> _logger;

        public MentorApplicationManagerByStaff(

            IStaffMentorApplicationService staffMentorApplicationService,

            ILogger<MentorApplicationManagerByStaff> logger)
        {

            _staffMentorApplicationService = staffMentorApplicationService;

            _logger = logger;
        }

   

        // PUT: api/UpdateStatusMentorApplication
        [HttpPut("Update-Status-MentorApplication")]
        public async Task<ActionResult> UpdateStatusMentorApplication([FromBody] MentorApplicationUpdateRequestModel application)
        {
            if (application == null)
            {
                return BadRequest("Invalid application data.");
            }

            try
            {
                var existingMentorApplicationService = await _staffMentorApplicationService.GetOne(application.Id);
                if (existingMentorApplicationService == null)
                {
                    return NotFound("Mentee application not found.");
                }
                await _staffMentorApplicationService.Update(application);
                return Ok(new { message = "Mentor application status updated successfully.", application });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating MentorApplication status.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/GetDetailMentorApplicationById
        [HttpGet("GetDetail-MentorApplication-By-Id")]
        public async Task<ActionResult<MentorApplicationRequestModel>> GetDetailMentorApplicationById(Guid id)
        {
            try
            {
                var mentorPlans = _staffMentorApplicationService.GetOneById(id);
                if (mentorPlans == null)
                {
                    return NotFound();
                }
                return Ok(mentorPlans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all MentorApplication for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("GetAll-MentorApplication-Paging")]
        public async Task<IActionResult> GetMentorApplicationPaging([FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
           async () => await _staffMentorApplicationService.GetAllPaging(request).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

    }
}
