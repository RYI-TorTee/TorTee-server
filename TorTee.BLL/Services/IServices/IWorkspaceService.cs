using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.Submissions;

namespace TorTee.BLL.Services.IServices
{
    public interface IWorkspaceService
    {
        Task<ServiceActionResult> GetMenteeAssignments(Guid menteeId);
        Task<ServiceActionResult> CreateASubmission(CreateSubmissionRequest request, Guid menteeId);
        Task<ServiceActionResult> GetAssignmentDetails(Guid assignmentId);
        Task<ServiceActionResult> GetSentSubmission(Guid menteeId);
        Task<ServiceActionResult> GetReceivedSubmission(Guid mentorId);
        Task<ServiceActionResult> GetSubmissionDetails(Guid submissionId);
        Task<ServiceActionResult> CreateAAssignment(CreateAssignmentRequest request, Guid mentorId);       
        Task<ServiceActionResult> GetMentorAssignments(Guid mentorId);
        Task<ServiceActionResult> UpdateGradeForSubmission(GradeSubmissionRequest request);
        Task<ServiceActionResult> GetMyMentee(Guid mentorId);
        Task<ServiceActionResult> GetMyMentor(Guid menteeId);
    }
}
