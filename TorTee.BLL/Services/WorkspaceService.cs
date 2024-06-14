using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.Submissions;
using TorTee.BLL.Models.Responses.Assignments;
using TorTee.BLL.Models.Responses.AssignmentSubmissions;
using TorTee.BLL.Models.Responses.Mentees;
using TorTee.BLL.Models.Responses.Users;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class WorkspaceService : IWorkspaceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;

        public WorkspaceService(IUnitOfWork unitOfWork, IMapper mapper, IFileStorageService fileStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }

        public async Task<ServiceActionResult> GetMyMentee(Guid mentorId)
        {
            var mentorShip = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(app => app.MenteePlan)
                .Where(app => app.MenteePlan.MentorId == mentorId && app.StartDate <= DateTime.Now && app.EndDate >= DateTime.Now)
                .Select(app => app.User);

            return new ServiceActionResult(true) { Data = mentorShip.ProjectTo<UserResponse>(_mapper.ConfigurationProvider) };
        }
        public async Task<ServiceActionResult> CreateAAssignment(CreateAssignmentRequest request, Guid mentorId)
        {
            var isOnDurationOdMentoring = await (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(app => app.MenteePlan)
                .Where(app => app.UserId == request.MenteeId && app.MenteePlan.MentorId == mentorId && app.StartDate <= DateTime.Now && DateTime.Now <= app.EndDate)
                .AnyAsync();

            var mentee = await _unitOfWork.UserRepository.FindAsync(request.MenteeId);

            if (mentee == null)
                return new ServiceActionResult(false) { Detail = $"This mentee currently can not be found." };

            if (!isOnDurationOdMentoring)
                return new ServiceActionResult(false) { Detail = $"Your mentorship with {mentee.FullName} currently can not be found. You can not assign assignment for her/him." };

            if (request.Deadline <= DateTime.Now)
                return new ServiceActionResult(false) { Detail = "Deadline must be in future, not in the past." };

            var entity = _mapper.Map<Assignment>(request);

            if (request.File != null)
                entity.File = await _fileStorageService.UploadFileBlobAsync(request.File);
            entity.MentorId = mentorId;

            await _unitOfWork.AssignmentRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> CreateASubmission(CreateSubmissionRequest request, Guid menteeId)
        {
            var assignment = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable()).Where(ass => ass.Id == request.AssignmentId).Include(a => a.Mentor).FirstOrDefault();

            var isOnDurationOdMentoring = await (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(app => app.MenteePlan)
                .Where(app => app.UserId == menteeId && app.MenteePlan.MentorId == assignment.MentorId && app.StartDate <= DateTime.Now && DateTime.Now <= app.EndDate)
                .AnyAsync();

            if (!isOnDurationOdMentoring)
                return new ServiceActionResult(false) { Detail = $"Your mentorship with {assignment.Mentor.FullName} currently can not be found. Please register with {assignment.Mentor.FullName} again to learn" };

            if (assignment?.Deadline <= DateTime.Now)
                return new ServiceActionResult(false) { Detail = $"Out of deadline {assignment.Deadline.ToString("f")}" };

            var entity = _mapper.Map<AssignmentSubmission>(request);
            if (request.File != null)
                entity.File = await _fileStorageService.UploadFileBlobAsync(request.File);

            await _unitOfWork.AssignmentSubmissionRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> GetAssignmentDetails(Guid assignmentId)
        {
            var returnAssignment = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                .Where(a => a.Id == assignmentId)
                .Include(a => a.Mentee)
                .Include(a => a.Submissions)
                .FirstOrDefault();

            return new ServiceActionResult(true) { Data = _mapper.Map<AssignmentDetailResponse>(returnAssignment) };
        }

        public async Task<ServiceActionResult> GetMenteeAssignments(Guid menteeId)
        {
            var myAssignments = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                                .Where(a => a.MenteeId == menteeId)
                                .Include (a => a.Mentor)
                                .Include(a => a.Submissions)
                                .OrderByDescending(a=>a.AssignedDate);

            return new ServiceActionResult(true) { Data = myAssignments.ProjectTo<AssignmentResponse>(_mapper.ConfigurationProvider) };

        }

        public async Task<ServiceActionResult> GetMentorAssignments(Guid mentorId)
        {
            var myAssignments = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                                .Where(a => a.MentorId == mentorId)
                                .Include(a=>a.Mentee)
                                .Include(a => a.Submissions)
                                .OrderByDescending(a => a.AssignedDate); ;

            return new ServiceActionResult(true) { Data = myAssignments.ProjectTo<AssignmentResponse>(_mapper.ConfigurationProvider) };
        }

      
        public async Task<ServiceActionResult> GetMyMentor(Guid menteeId)
        {
            var mentorShip = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Where(app => app.UserId == menteeId && app.StartDate <= DateTime.Now && DateTime.Now <= app.EndDate)
                .Select(app=>app.MenteePlan.Mentor);

            return new ServiceActionResult(true) { Data = mentorShip.ProjectTo<MenteeResponse>(_mapper.ConfigurationProvider) };

        }

        public async Task<ServiceActionResult> GetReceivedSubmission(Guid mentorId)
        {
            var submissions = (await _unitOfWork.AssignmentSubmissionRepository.GetAllAsyncAsQueryable())
                .Include(s => s.Assignment)
                .Where(s => s.Assignment.MentorId == mentorId)
                .OrderByDescending(s=>s.SubmitedDate)
                .ProjectTo<AssignmentSubmissionResponse>(_mapper.ConfigurationProvider);
            return new ServiceActionResult(true) { Data = submissions };
        }

        public async Task<ServiceActionResult> GetSentSubmission(Guid menteeId)
        {
            var submissions = (await _unitOfWork.AssignmentSubmissionRepository.GetAllAsyncAsQueryable())
                .Include(s => s.Assignment)
                .Where(s => s.Assignment.MenteeId == menteeId).OrderByDescending(s => s.SubmitedDate).
                ProjectTo<AssignmentSubmissionResponse>(_mapper.ConfigurationProvider);

            return new ServiceActionResult(true) { Data = submissions };
        }

        public async Task<ServiceActionResult> GetSubmissionDetails(Guid submissionId)
        {
            var returnSubmission = await _unitOfWork.AssignmentSubmissionRepository.FindAsync(submissionId);

            return new ServiceActionResult(true) { Data = _mapper.Map<AssignmentSubmissionResponse>(returnSubmission) };
        }

        public async Task<ServiceActionResult> UpdateGradeForSubmission(GradeSubmissionRequest request)
        {
            var submission = await _unitOfWork.AssignmentSubmissionRepository.FindAsync(request.Id);

            if(submission==null)
                return new ServiceActionResult(false) { Detail = "Invalid submission"};

            submission.CommentOfMentor = request.CommentOfMentor;
            submission.Grade = request.Grade;
            submission.Status = Core.Domains.Enums.SubmissionStatus.GRADED;

            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }


    }
}
