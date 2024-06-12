using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.Submissions;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class WorkspaceController : BaseApiController
    {
        private readonly IWorkspaceService _workspaceService;
        private readonly IMentorshipService _mentorshipService;

        public WorkspaceController(IWorkspaceService workspaceService, IMentorshipService mentorshipService)
        {
            _workspaceService = workspaceService;
            _mentorshipService = mentorshipService;
        }

        [HttpGet("mentee/my-assignments")]
        public async Task<IActionResult> GetAssignmentsReceived()
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMenteeAssignments(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentee/my-submissions")]
        public async Task<IActionResult> GetSubmissionSent()
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetSentSubmission(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("mentee/submit")]
        public async Task<IActionResult> CreateSubmission(CreateSubmissionRequest request)
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateASubmission(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentee/my-mentors")]
        public async Task<IActionResult> GetMyMentors()
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _mentorshipService.GetMyMentors(currentUser).ConfigureAwait(false)
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
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetReceivedSubmission(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("mentor/create-assignment")]
        public async Task<IActionResult> CreateAssignment(CreateAssignmentRequest request)
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateAAssignment(request, currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/assignments")]
        public async Task<IActionResult> GetAssignmentsSent()
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMentorAssignments(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPut("mentor/grade")]
        public async Task<IActionResult> GetAssignmentSent(GradeSubmissionRequest request)
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.UpdateGradeForSubmission(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/my-mentees")]
        public async Task<IActionResult> GetMyMentees()
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _mentorshipService.GetMyMentees(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }
    }
}
