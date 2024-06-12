using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Assignments;
using TorTee.BLL.Models.Requests.Submissions;
using TorTee.BLL.Models.Responses.Assignments;
using TorTee.BLL.Models.Responses.AssignmentSubmissions;
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
        public async Task<ServiceActionResult> CreateAAssignment(CreateAssignmentRequest request, Guid mentorId)
        {
            var entity = _mapper.Map<Assignment>(request);
            if (request.File!=null)
                entity.File = await _fileStorageService.UploadFileBlobAsync(request.File);            
            entity.MentorId = mentorId;
            await _unitOfWork.AssignmentRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> CreateASubmission(CreateSubmissionRequest request)
        {
            //var isOnDurationOdMentoring = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
            //    .Where(app => app. && app.StartDate >= DateTime.Now && app.EndDate <= DateTime.Now);

            var entity = _mapper.Map<AssignmentSubmission>(request);
            if (request.File != null)
                entity.File = await _fileStorageService.UploadFileBlobAsync(request.File);
            await _unitOfWork.AssignmentSubmissionRepository.AddAsync(entity);
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> GetAssignmentDetails(Guid assignmentId)
        {
            var returnAssignment = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                .Where(a=>a.Id==assignmentId)
                .Include(a=>a.Submissions)
                .ToList()
                .FirstOrDefault();
            
            return new ServiceActionResult(true) { Data = _mapper.Map<AssignmentResponse>(returnAssignment) };
        }

        public async Task<ServiceActionResult> GetMenteeAssignments(Guid menteeId)
        {
            var myAssignments = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                                .Where(a => a.MenteeId == menteeId)
                                .Include(a => a.Submissions);

            return new ServiceActionResult(true) { Data = myAssignments.ProjectTo<AssignmentResponse>(_mapper.ConfigurationProvider) }; 
            
        }

        public async Task<ServiceActionResult> GetMentorAssignments(Guid mentorId)
        {
            var myAssignments = (await _unitOfWork.AssignmentRepository.GetAllAsyncAsQueryable())
                                .Where(a => a.MentorId == mentorId)
                                .Include(a => a.Submissions);

            return new ServiceActionResult(true) { Data = myAssignments.ProjectTo<AssignmentResponse>(_mapper.ConfigurationProvider) };
        }

        public async Task<ServiceActionResult> GetReceivedSubmission(Guid mentorId)
        {
            var submissions = (await _unitOfWork.AssignmentSubmissionRepository.GetAllAsyncAsQueryable())
                .Include(s => s.Assignment)
                .Where(s => s.Assignment.MentorId == mentorId).
                ProjectTo<AssignmentSubmissionResponse>(_mapper.ConfigurationProvider);
            return new ServiceActionResult(true) { Data = submissions };
        }

        public async Task<ServiceActionResult> GetSentSubmission(Guid menteeId)
        {
            var submissions = (await _unitOfWork.AssignmentSubmissionRepository.GetAllAsyncAsQueryable())
                .Include(s => s.Assignment)
                .Where(s => s.Assignment.MenteeId == menteeId).
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

            submission.Description = request.Description;
            submission.Grade = request.Grade;
            submission.Status = Core.Domains.Enums.SubmissionStatus.GRADED;

            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }
        
        
    }
}
