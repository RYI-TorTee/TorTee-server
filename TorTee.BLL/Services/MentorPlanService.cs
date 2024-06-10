using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorPlanService : IMentorPlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MentorPlanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(MenteePlanCreateRequestModel mentorPlanCreate)
        {
            try
            {
                var mentorPlan = _mapper.Map<MenteePlan>(mentorPlanCreate);
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

        public IList<MenteePlanRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<MenteePlan, bool>> filter = mentorPlan => mentorPlan.MentorId == id;
            Func<IQueryable<MenteePlan>, IOrderedQueryable<MenteePlan>> orderBy = null;
            IList<MenteePlan> result = (IList<MenteePlan>)_unitOfWork.MentorPlanRepository.GetDetail(filter, orderBy, "MenteeApplications", pageSize, pageIndex);
            var mentorPlan = _mapper.Map<IList<MenteePlanRequestModel>>(result);
            return mentorPlan;
        }

        public async Task<ServiceActionResult> GetAllPaging(PagingRequest request, Guid id)
        {
            //Code nay hoi nguu vi getall duoi db len lun , co ma do hoi va time huhuhuuh
            IQueryable<MenteePlan> menteePlans = _unitOfWork.MentorPlanRepository.GetAll().AsQueryable();
            var filteredPlans = menteePlans.Where(mentorPlan => mentorPlan.MentorId == id);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<MenteePlan, MenteePlanRequestModel>(_mapper, filteredPlans, request.PageSize ?? 0, request.PageIndex ?? 0);

            return new ServiceActionResult(true) { Data = paginationResult };
        }

       

        public async Task<MenteePlan> GetOne(Guid mentorPlanId)
        {
            return await _unitOfWork.MentorPlanRepository.FindAsync(mentorPlanId);
        }

        public async Task Update(MenteePlanUpdateRequestModel mentorPlan)
        {
            try
            {
                var repos = _unitOfWork.MentorPlanRepository;
                var existingMentorPlan = await repos.FindAsync(mentorPlan.Id);
                if (existingMentorPlan == null)
                    throw new KeyNotFoundException();
                existingMentorPlan.TotalSlot = mentorPlan.TotalSlot;
                existingMentorPlan.Status = mentorPlan.Status;
                existingMentorPlan.Price = mentorPlan.Price;
                existingMentorPlan.Description = mentorPlan.Description;
           

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public MenteePlanRequestModel GetOneById(Guid id)
        {
            Expression<Func<MenteePlan, bool>> filter = mentorPlan => mentorPlan.Id == id;
            Func<IQueryable<MenteePlan>, IOrderedQueryable<MenteePlan>> orderBy = null;
            MenteePlan result = _unitOfWork.MentorPlanRepository.GetDetail(filter, orderBy, "MenteeApplications", 1, 1).FirstOrDefault();
            var mentorPlan = _mapper.Map<MenteePlanRequestModel>(result);
            return mentorPlan;
        }

        public MenteePlanRequestModel GetByMenteePlanId(Guid id)
        {
            Expression<Func<MenteePlan, bool>> filter = mentorPlan => mentorPlan.Id == id;
            Func<IQueryable<MenteePlan>, IOrderedQueryable<MenteePlan>> orderBy = null;
            MenteePlan result = _unitOfWork.MentorPlanRepository.GetDetail(filter, orderBy, "MenteeApplications", 1, 1).FirstOrDefault();
            var mentorPlan = _mapper.Map<MenteePlanRequestModel>(result);
            return mentorPlan;
        }
        
    }
}
