using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.Submissions;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class WorkspaceController : BaseApiController
    {
        private readonly IWorkspaceService _workspaceService;
        private readonly IUserClaimsService _userClaimsService;
        private UserClaims _userClaims;

        public WorkspaceController(IWorkspaceService workspaceService, IUserClaimsService userClaimsService)
        {
            _workspaceService = workspaceService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpGet("mentee/my-assignments")]
        public async Task<IActionResult> GetAssignmentsReceived()
        {
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMenteeAssignments(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentee/my-submissions")]
        public async Task<IActionResult> GetSubmissionSent()
        {
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetSentSubmission(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("mentee/submit")]
        public async Task<IActionResult> CreateSubmission([FromForm] CreateSubmissionRequest request)
        {           
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateASubmission(request, _userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentee/my-mentors")]
        public async Task<IActionResult> GetMyMentors()
        {           
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMyMentor(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("assignments/{id}")]
        public async Task<IActionResult> GetAssignmentsDetails(Guid id)
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetAssignmentDetails(id).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("submissions/{id}")]
        public async Task<IActionResult> GetSubmissionDetails(Guid id)
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetSubmissionDetails(id).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/submissions-received")]
        public async Task<IActionResult> GetSubmissionsReceived()
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetReceivedSubmission(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("mentor/create-assignment")]
        public async Task<IActionResult> CreateAssignment([FromForm] CreateAssignmentRequest request)
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateAAssignment(request, _userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/assignments")]
        public async Task<IActionResult> GetAssignmentsSent()
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMentorAssignments(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPut("mentor/grade")]
        public async Task<IActionResult> GradeSubmission(GradeSubmissionRequest request)
        {          
            return await ExecuteServiceLogic(
                async () => await _workspaceService.UpdateGradeForSubmission(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/my-mentees")]
        public async Task<IActionResult> GetMyMentees()
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMyMentee(_userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }
    }
}
