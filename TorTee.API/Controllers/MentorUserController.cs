using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api/MentorUser")]
    public class MentorUserController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;
        private readonly IUserSkillService _userSkillService;
        private readonly IBookingPlanService _bookingPlanService;
        private readonly IMentorPlanService _mentorPlanService;
        private readonly ILogger<MentorUserController> _logger;
        public MentorUserController(ILogger<MentorUserController> logger,IMentorUserService MentorUserService, IUserSkillService userSkillService, IBookingPlanService bookingPlanService, IMentorPlanService mentorPlanService)
        {
            _mentorUserService = MentorUserService;
            _userSkillService = userSkillService;
            _bookingPlanService = bookingPlanService;
            _mentorPlanService = mentorPlanService;
            _logger = logger;
        }

        // GET: api/MentorUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MentorDTO>>> GetAllMentors()
        {
            try
            {
                _logger.LogInformation("GetAllMentors: Retrieving all mentors.");
                var mentors = await _mentorUserService.GetAll();
                return Ok(mentors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllMentors: An unexpected error occurred - {Message}", ex.Message);
                return StatusCode(500, "An unexpected error occurred while retrieving mentors.");
            }
        }

        // GET: api/MentorUser/{id}
        [HttpGet("GetMentorById/{{id}}")]
        public async Task<ActionResult<MentorDTO>> GetMentorById(Guid id)
        {
            var mentor =  _mentorUserService.GetDetailOne(id);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        [HttpGet("GetAllSkillMentorById/{{id}}")]
        public async Task<ActionResult<UserSkill>> GetAllUserSkillById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _userSkillService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        [HttpGet("GetAllBookingCallMentorById/{{id}}")]
        public async Task<ActionResult<Session>> GetAlBookingCallById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _bookingPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }
        [HttpGet("GetAllMentorPlanMentorById/{{id}}")]
        public async Task<ActionResult<MenteePlan>> GetAllMentorPlanById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _mentorPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        [HttpPost]
        public async Task<ActionResult> AddMentor([FromBody] MentorDTO mentor)
        {
            if (mentor == null)
            {
                return BadRequest("Mentor object is null");
            }

           

            try
            {
                await _mentorUserService.Add(mentor);
                return CreatedAtAction(nameof(GetMentorById), new { id = mentor.Id }, mentor);
            }
            catch (ArgumentNullException ex)
            {
                // Log the exception
                _logger.LogError(ex, "ArgumentNullException: {Message}", ex.Message);
                return BadRequest("The mentor information provided was incomplete.");
            }
            catch (InvalidOperationException ex)
            {
                // Log the exception
                _logger.LogError(ex, "InvalidOperationException: {Message}", ex.Message);
                return Conflict("A mentor with the same information already exists.");
            }
            catch (DbUpdateException ex)
            {
                // Log the exception
                _logger.LogError(ex, "DbUpdateException: {Message}", ex.Message);
                return StatusCode(500, "A database error occurred while adding the mentor.");
            }
            catch (Exception ex)
            {
                // Log the exception
                _logger.LogError(ex, "An unexpected error occurred: {Message}", ex.Message);
                return StatusCode(500, "An unexpected error occurred while adding the mentor.");
            }
        }

        // PUT: api/MentorUser/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMentor(Guid id, [FromBody] MentorProfileUpdateRequestModel mentor)
        {
            if (mentor == null || id != mentor.Id)
            {
                _logger.LogWarning("UpdateMentor: BadRequest - Mentor object is null or ID mismatch");
                return BadRequest("Mentor object is null or ID mismatch");
            }

            try
            {
                var existingMentor = await _mentorUserService.GetOne(id);
                if (existingMentor == null)
                {
                    _logger.LogWarning("UpdateMentor: NotFound - Mentor with ID {Id} not found", id);
                    return NotFound($"Mentor with ID {id} not found");
                }


                await _mentorUserService.Update(mentor);
                _logger.LogInformation("UpdateMentor: Mentor with ID {Id} updated successfully", id);
                return StatusCode(200, "Updated successfully");
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex, "UpdateMentor: ArgumentNullException - {Message}", ex.Message);
                return BadRequest("The mentor information provided was incomplete.");
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError(ex, "UpdateMentor: InvalidOperationException - {Message}", ex.Message);
                return Conflict("An operation conflict occurred while updating the mentor.");
            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "UpdateMentor: DbUpdateException - {Message}", ex.Message);
                return StatusCode(500, "A database error occurred while updating the mentor.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "UpdateMentor: An unexpected error occurred - {Message}", ex.Message);
                return StatusCode(500, "An unexpected error occurred while updating the mentor.");
            }
        }

            // DELETE: api/MentorUser/{id}
            [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMentor(Guid id)
        {
            var mentor = await _mentorUserService.GetOne(id);
            if (mentor == null)
            {
                return NotFound();
            }

            await _mentorUserService.Delete(id);
            return NoContent();
        }

    }
}
