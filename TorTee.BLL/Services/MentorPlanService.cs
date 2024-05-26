using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorPlanService : IMentorPlanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MentorPlanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(MenteePlan mentorPlan)
        {
            try
            {
                var repos = _unitOfWork.MentorPlanRepository;
                await repos.AddAsync(mentorPlan);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid mentorPlanId)
        {
            try
            {
                var repos = _unitOfWork.MentorPlanRepository;
                var mentorPlan = await repos.GetAsync(mp => mp.Id == mentorPlanId);
                if (mentorPlan == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(mentorPlan);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<MenteePlan>> GetAll()
        {
            return await _unitOfWork.MentorPlanRepository.GetAllAsync();
        }

        public IList<MenteePlan> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<MenteePlan, bool>> filter = mentorPlan => mentorPlan.MentorId == id;
            Func<IQueryable<MenteePlan>, IOrderedQueryable<MenteePlan>> orderBy = null;
            IList<MenteePlan> result = (IList<MenteePlan>)_unitOfWork.MentorPlanRepository.GetDetail(filter, orderBy, "MenteeApplications", pageSize, pageIndex);
            return result;
        }

        public async Task<MenteePlan> GetOne(Guid mentorPlanId)
        {
            return await _unitOfWork.MentorPlanRepository.FindAsync(mentorPlanId);
        }

        public async Task Update(MenteePlan mentorPlan)
        {
            try
            {
                var repos = _unitOfWork.MentorPlanRepository;
                var existingMentorPlan = await repos.FindAsync(mentorPlan.Id);
                if (existingMentorPlan == null)
                    throw new KeyNotFoundException();

                
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }
    }
}
