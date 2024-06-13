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
        public async Task<IActionResult> CreateSubmission([FromForm] CreateSubmissionRequest request)
        {
           
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateASubmission(request, _userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        //[HttpGet("mentee/my-mentors")]
        //public async Task<IActionResult> GetMyMentors()
        //{ Guid currentUser = new Guid("5a08a055-6168-4c7d-8158-08dc845d49d6"); mentee
        //Guid currentUser = new Guid("34E51525-5B2C-4B66-29CD-08DC7B8919DB"); mentor
        //    Guid currentUser = new Guid();
        //    return await ExecuteServiceLogic(
        //        async () => await _mentorshipService.GetMyMentors(currentUser).ConfigureAwait(false)
        //    ).ConfigureAwait(false);
        //}

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
        public async Task<IActionResult> CreateAssignment([FromForm] CreateAssignmentRequest request)
        {            
            return await ExecuteServiceLogic(
                async () => await _workspaceService.CreateAAssignment(request, _userClaims.UserId).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("mentor/assignments")]
        public async Task<IActionResult> GetAssignmentsSent()
        {
            Guid currentUser = new Guid("34E51525-5B2C-4B66-29CD-08DC7B8919DB");
            return await ExecuteServiceLogic(
                async () => await _workspaceService.GetMentorAssignments(currentUser).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPut("mentor/grade")]
        public async Task<IActionResult> GradeSubmission(GradeSubmissionRequest request)
        {
            Guid currentUser = new Guid();
            return await ExecuteServiceLogic(
                async () => await _workspaceService.UpdateGradeForSubmission(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        //[HttpGet("mentor/my-mentees")]
        //public async Task<IActionResult> GetMyMentees()
        //{
        //    Guid currentUser = new Guid();
        //    return await ExecuteServiceLogic(
        //        async () => await _mentorshipService.GetMyMentees(currentUser).ConfigureAwait(false)
        //    ).ConfigureAwait(false);
        //}
    }
}
