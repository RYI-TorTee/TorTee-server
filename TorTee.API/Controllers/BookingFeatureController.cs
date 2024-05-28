using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.Core.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api/Booking-Feature")]
    public class BookingFeatureController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;
        private readonly IUserSkillService _userSkillService;
        private readonly IBookingPlanService _bookingPlanService;
        private readonly IMentorPlanService _mentorPlanService;
        private readonly IApplicationQuestionService _applicationQuestionService;
        private readonly IMenteeApplicationAnswerService _menteeApplicationAnswerService;
        private readonly IMenteeApplicationService _menteeApplicationService;
        private readonly ILogger<BookingFeatureController> _logger;

        public BookingFeatureController(
            IMentorUserService mentorUserService,
            IUserSkillService userSkillService,
            IBookingPlanService bookingPlanService,
            IMentorPlanService mentorPlanService,
            IApplicationQuestionService applicationQuestionService,
            IMenteeApplicationAnswerService menteeApplicationAnswerService,
            IMenteeApplicationService menteeApplicationService,
            ILogger<BookingFeatureController> logger)
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

        // GET: api/Booking-Feature/GetAllApplicationQuestion
        [HttpGet("GetAllApplicationQuestion")]
        public async Task<ActionResult<IEnumerable<ApplicationQuestion>>> GetAllApplicationQuestion()
        {
            try
            {
                var questions = await _applicationQuestionService.GetAll();
                return Ok(questions);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all application questions.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetApplicationQuestionById/{id}
        [HttpGet("GetApplicationQuestionById/{id}")]
        public async Task<ActionResult<ApplicationQuestion>> GetApplicationQuestionById(Guid id)
        {
            try
            {
                var question = await _applicationQuestionService.GetOne(id);
                if (question == null)
                {
                    return NotFound();
                }
                return Ok(question);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting application question by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // POST: api/Booking-Feature/AddMenteeApplicationAnswer
        [HttpPost("AddMenteeApplicationAnswer")]
        public async Task<ActionResult> AddMenteeApplicationAnswer([FromBody] MenteeApplicationAnswerCreateRequestModel answer)
        {
            if (answer == null)
            {
                return BadRequest("Mentee application answer is null.");
            }

            try
            {
                await _menteeApplicationAnswerService.Add(answer);
                // Retrieve the generated ID after adding the answer
               // var addedAnswer = await _menteeApplicationAnswerService.GetOne(answer.QuestionId);
                return StatusCode(201, "Add sussecc full");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding mentee application answer.");
                return StatusCode(500, "Internal server error" +ex);
            }
        }

        // POST: api/Booking-Feature/AddMenteeApplication
        [HttpPost("AddMenteeApplication")]
        public async Task<ActionResult> AddMenteeApplication([FromBody] MenteeApplicationCreateRequestModel application)
        {
            if (application == null)
            {
                return BadRequest("Mentee application is null.");
            }

            try
            {
                application.Status = TorTee.Core.Domains.Enums.ApplicationStatus.PENDING;
                application.AppliedDate = DateTime.Now;
                await _menteeApplicationService.Add(application);
                return StatusCode(201, "Add sussecc full" + application); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding mentee application.");
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/Booking-Feature/UpdateStatusMenteeApplication/{id}
        [HttpPut("UpdateStatusMenteeApplication")]
        public async Task<ActionResult> UpdateStatusMenteeApplication( [FromBody] MenteeApplicationUpdateRequestModel application)
        {
            if (application == null)
            {
                return BadRequest("Invalid application data.");
            }
            
            try
            {
                var existingApplication = await _menteeApplicationService.GetOne(application.Id);
                if (existingApplication == null)
                {
                    return NotFound("Mentee application not found.");
                }
                existingApplication.Status = application.Status;
                await _menteeApplicationService.Update(existingApplication);
                return Ok(new { message = "Mentee application status updated successfully.", application });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating mentee application status.");
                return StatusCode(500, "Internal server error");
            }
        }


        // GET: api/Booking-Feature/GetMentorById/{id}
        [HttpGet("GetMentorById/{id}")]
        public ActionResult<User> GetMentorById(Guid id)
        {
            try
            {
                var mentor = _mentorUserService.GetDetailOne(id);
                if (mentor == null)
                {
                    return NotFound();
                }
                return Ok(mentor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetMenteeApplicationAnswerByIdMentee/{id}
        [HttpGet("GetMenteeApplicationAnswerByIdMentee/{id}")]
        public async Task<ActionResult<MenteeApplication>> GetMenteeApplicationAnswerByIdMentee(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var application = _menteeApplicationService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (application == null)
                {
                    return NotFound();
                }
                return Ok(application);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting mentee application by mentee id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetAllSkillMentorById/{id}
        [HttpGet("GetAllSkillMentorById/{id}")]
        public async Task<ActionResult<UserSkill>> GetAllSkillMentorById(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var skills = _userSkillService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (skills == null)
                {
                    return NotFound();
                }
                return Ok(skills);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all skills for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetAllBookingCallMentorById/{id}
        [HttpGet("GetAllBookingCallMentorById/{id}")]
        public async Task<ActionResult<Session>> GetAllBookingCallMentorById(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var bookingCalls = _bookingPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (bookingCalls == null)
                {
                    return NotFound();
                }
                return Ok(bookingCalls);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all booking calls for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/Booking-Feature/GetAllMentorPlanMentorById/{id}
        [HttpGet("GetAllMentorPlanMentorById/{id}")]
        public async Task<ActionResult<MenteePlan>> GetAllMentorPlanMentorById(Guid id, [FromQuery] FormSearch search)
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

        // POST: api/Booking-Feature
        [HttpPost]
        public async Task<ActionResult> AddMentor([FromBody] MentorDTO mentor)
        {
            if (mentor == null)
            {
                return BadRequest("Mentor data is null.");
            }

            try
            {
                await _mentorUserService.Add(mentor);
                return CreatedAtAction(nameof(GetMentorById), new { id = mentor.Id }, mentor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding a mentor.");
                return StatusCode(500, "Internal server error");
            }
        }

        // PUT: api/Booking-Feature/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMentor(Guid id, [FromBody] MentorProfileUpdateRequestModel mentor)
        {
            if (mentor == null || id != mentor.Id)
            {
                return BadRequest("Invalid mentor data.");
            }

            try
            {
                var existingMentor = await _mentorUserService.GetOne(id);
                if (existingMentor == null)
                {
                    return NotFound("Mentor not found.");
                }

                await _mentorUserService.Update(mentor);
                return Ok(new { message = "Mentor updated successfully.", mentor });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating a mentor.");
                return StatusCode(500, "Internal server error");
            }
        }


        // DELETE: api/Booking-Feature/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMentor(Guid id)
        {
            try
            {
                var mentor = await _mentorUserService.GetOne(id);
                if (mentor == null)
                {
                    return NotFound("Mentor not found.");
                }

                await _mentorUserService.Delete(id);
                return Ok("Mentor deleted successfully.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a mentor.");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
