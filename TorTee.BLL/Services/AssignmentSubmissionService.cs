using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.AssignmentSubmission;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class AssignmentSubmissionService : IAssignmentSubmissionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssignmentSubmissionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(AssignmentSubmissionCreateRequestModel submissionCreate)
        {
            try
            {
                var submission = _mapper.Map<AssignmentSubmission>(submissionCreate);
                var repos = _unitOfWork.AssignmentSubmissionRepository;
                await repos.AddAsync(submission);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid submissionId)
        {
            try
            {
                var repos = _unitOfWork.AssignmentSubmissionRepository;
                var submission = await repos.GetAsync(s => s.Id == submissionId);
                if (submission == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(submission);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<AssignmentSubmission>> GetAll()
        {
            return await _unitOfWork.AssignmentSubmissionRepository.GetAllAsync();
        }

        public IList<AssignmentSubmissionRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<AssignmentSubmission, bool>> filter = submission => submission.AssignmentId == id;
            Func<IQueryable<AssignmentSubmission>, IOrderedQueryable<AssignmentSubmission>> orderBy = null;
            IList<AssignmentSubmission> result = (IList<AssignmentSubmission>)_unitOfWork.AssignmentSubmissionRepository.GetDetail(filter, orderBy, "Assignment", pageSize, pageIndex);
            var submissions = _mapper.Map<IList<AssignmentSubmissionRequestModel>>(result);
            return submissions;
        }

        public async Task<AssignmentSubmission> GetOne(Guid submissionId)
        {
            return await _unitOfWork.AssignmentSubmissionRepository.FindAsync(submissionId);
        }

        public async Task Update(AssignmentSubmissionUpdateRequestModel submissionUpdate)
        {
            try
            {
                var repos = _unitOfWork.AssignmentSubmissionRepository;
                var existingSubmission = await repos.FindAsync(submissionUpdate.Id);
                if (existingSubmission == null)
                    throw new KeyNotFoundException();
                existingSubmission.Status = submissionUpdate.Status;
                existingSubmission.Grade = submissionUpdate.Grade;
                //........

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public AssignmentSubmissionRequestModel GetOneById(Guid id)
        {
            Expression<Func<AssignmentSubmission, bool>> filter = submission => submission.Id == id;
            Func<IQueryable<AssignmentSubmission>, IOrderedQueryable<AssignmentSubmission>> orderBy = null;
            AssignmentSubmission result = _unitOfWork.AssignmentSubmissionRepository.GetDetail(filter, orderBy, "Assignment", 1, 1).FirstOrDefault();
            var submission = _mapper.Map<AssignmentSubmissionRequestModel>(result);
            return submission;
        }
    }
}
