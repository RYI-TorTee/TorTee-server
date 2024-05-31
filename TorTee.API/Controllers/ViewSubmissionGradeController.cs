using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Models.Requests.Assignment;
using TorTee.BLL.Models.Requests.AssignmentSubmission;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{


    [ApiController]
    [Route("api/View-Submission-Grade-For-Mentor")]
    public class ViewSubmissionGradeController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;
        private readonly IUserSkillService _userSkillService;
        private readonly IBookingPlanService _bookingPlanService;
        private readonly IMentorPlanService _mentorPlanService;
        private readonly IApplicationQuestionService _applicationQuestionService;
        private readonly IMenteeApplicationAnswerService _menteeApplicationAnswerService;
        private readonly IMenteeApplicationService _menteeApplicationService;
        private readonly IAssignmentService _assignmentService;
        private readonly IAssignmentSubmissionService _assignmentSubmissionService;
        private readonly ILogger<ViewSubmissionGradeController> _logger;

        public ViewSubmissionGradeController(
            IMentorUserService mentorUserService,
            IUserSkillService userSkillService,
            IBookingPlanService bookingPlanService,
            IMentorPlanService mentorPlanService,
            IApplicationQuestionService applicationQuestionService,
            IMenteeApplicationAnswerService menteeApplicationAnswerService,
            IMenteeApplicationService menteeApplicationService,
            IAssignmentService assignmentService,
            IAssignmentSubmissionService assignmentSubmissionService,
            ILogger<ViewSubmissionGradeController> logger)
        {
            _mentorUserService = mentorUserService;
            _userSkillService = userSkillService;
            _bookingPlanService = bookingPlanService;
            _mentorPlanService = mentorPlanService;
            _applicationQuestionService = applicationQuestionService;
            _menteeApplicationAnswerService = menteeApplicationAnswerService;
            _menteeApplicationService = menteeApplicationService;
            _assignmentService = assignmentService;
            _assignmentSubmissionService = assignmentSubmissionService;
            _logger = logger;
        }

        // GET: api/GetAllSubmissionByAssignmentId
        [HttpGet("GetAllSubmissionByAssignmentId")]
        public async Task<ActionResult<AssignmentSubmissionRequestModel>> GetAllSubmissionByAssignmentId(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var assignmentSubmission = _assignmentSubmissionService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (assignmentSubmission == null)
                {
                    return NotFound();
                }
                return Ok(assignmentSubmission);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all assignmentSubmission for mentor by assignmentid.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/GetAssignmentById
        [HttpGet("GetAssignmentById")]
        public async Task<ActionResult<AssignmentRequestModel>> GetAssignmentById(Guid id)
        {
            try
            {
                var assignment = _assignmentService.GetOneById(id);
                if (assignment == null)
                {
                    return NotFound();
                }
                return Ok(assignment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting  assignment for mentor by assignmentid.");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/GetAssignmentById
        [HttpGet("GetAssignmentSubmitById")]
        public async Task<ActionResult<AssignmentSubmissionRequestModel>> GetAssignmentSubmitById(Guid id)
        {
            try
            {
                var assignmentSubmit = _assignmentSubmissionService.GetOneById(id);
                if (assignmentSubmit == null)
                {
                    return NotFound();
                }
                return Ok(assignmentSubmit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting  assignmentsubmit for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }


        // PUT: api/Booking-Feature/UpdateStatusMenteeApplication/{id}
        [HttpPut("GradeAssignmentSubmit")]
        public async Task<ActionResult> GradeAssignmentSubmit([FromBody] AssignmentSubmissionUpdateRequestModel assignmentSubmission)
        {
            if (assignmentSubmission == null)
            {
                return BadRequest("Invalid AssignmentSubmission data.");
            }

            try
            {
                var existingAssignmentSubmission = await _assignmentSubmissionService.GetOne(assignmentSubmission.Id);
                if (existingAssignmentSubmission == null)
                {
                    return NotFound("Mentee AssignmentSubmission not found.");
                }
               
                await _assignmentSubmissionService.Update(assignmentSubmission);
                return Ok(new { message = "Mentee AssignmentSubmission status updated successfully.", assignmentSubmission });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating mentee AssignmentSubmission status.");
                return StatusCode(500, "Internal server error");
            }
        }


    }
}
