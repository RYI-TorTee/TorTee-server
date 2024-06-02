using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Assignment;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
   
    public class AssignmentService : IAssignmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AssignmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(AssignmentCreateRequestModel AssignmentCreate)
        {
            try
            {
                var Assignment = _mapper.Map<Assignment>(AssignmentCreate);
                var repos = _unitOfWork.AssignmentRepository;
                await repos.AddAsync(Assignment);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid AssignmentId)
        {
            try
            {
                var repos = _unitOfWork.AssignmentRepository;
                var Assignment = await repos.GetAsync(mp => mp.Id == AssignmentId);
                if (Assignment == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(Assignment);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<Assignment>> GetAll()
        {
            return await _unitOfWork.AssignmentRepository.GetAllAsync();
        }

        public IList<AssignmentRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<Assignment, bool>> filter = Assignment => Assignment.MentorId == id;
            Func<IQueryable<Assignment>, IOrderedQueryable<Assignment>> orderBy = null;
            IList<Assignment> result = (IList<Assignment>)_unitOfWork.AssignmentRepository.GetDetail(filter, orderBy, "Submissions", pageSize, pageIndex);
            var Assignment = _mapper.Map<IList<AssignmentRequestModel>>(result);
            return Assignment;
        }

        public async Task<Assignment> GetOne(Guid AssignmentId)
        {
            return await _unitOfWork.AssignmentRepository.FindAsync(AssignmentId);
        }

        public async Task Update(AssignmentUpdateRequestModel Assignment)
        {
            try
            {
                var repos = _unitOfWork.AssignmentRepository;
                var existingAssignment = await repos.FindAsync(Assignment.Id);
                if (existingAssignment == null)
                    throw new KeyNotFoundException();
                existingAssignment.Title = Assignment.Title;
                existingAssignment.Deadline = Assignment.Deadline;
                existingAssignment.Description = Assignment.Description;
                existingAssignment.AssignedDate = Assignment.AssignedDate;
                //........

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public AssignmentRequestModel GetOneById(Guid id)
        {
            Expression<Func<Assignment, bool>> filter = Assignment => Assignment.Id == id;
            Func<IQueryable<Assignment>, IOrderedQueryable<Assignment>> orderBy = null;
            Assignment result = _unitOfWork.AssignmentRepository.GetDetail(filter, orderBy, "Submissions", 1, 1).FirstOrDefault();
            var assignment = _mapper.Map<AssignmentRequestModel>(result);
            return assignment;
        }
    }
}
