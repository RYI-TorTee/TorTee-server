using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MenteeApplicationService : IMenteeApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenteeApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(MenteeApplicationCreateRequestModel menteeApplicationCreate)
        {
            try
            {
                var menteeApplication = _mapper.Map<MenteeApplication>(menteeApplicationCreate);
                var repos = _unitOfWork.MenteeApplicationRepository;
                await repos.AddAsync(menteeApplication);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid menteeApplicationId)
        {
            try
            {
                var repos = _unitOfWork.MenteeApplicationRepository;
                var menteeApplication = await repos.GetAsync(ma => ma.Id == menteeApplicationId);
                if (menteeApplication == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(menteeApplication);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<MenteeApplication>> GetAll()
        {
            return await _unitOfWork.MenteeApplicationRepository.GetAllAsync();
        }

        public IList<MenteeApplication> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<MenteeApplication, bool>> filter = ma => ma.Id == id;
            Func<IQueryable<MenteeApplication>, IOrderedQueryable<MenteeApplication>> orderBy = null;
            IList<MenteeApplication> result = (IList<MenteeApplication>)_unitOfWork.MenteeApplicationRepository.GetDetail(filter, orderBy, "MenteeApplicationAnswers", pageSize, pageIndex);
            return result;
        }
        public IList<MenteeApplicationRequestModel> GetListMenteeApplicationofMentee(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<MenteeApplication, bool>> filter = ma => ma.UserId == id;
            Func<IQueryable<MenteeApplication>, IOrderedQueryable<MenteeApplication>> orderBy = null;
            IList<MenteeApplication> result = (IList<MenteeApplication>)_unitOfWork.MenteeApplicationRepository.GetDetail(filter, orderBy, "MenteeApplicationAnswers", pageSize, pageIndex);
            var menteeApplication = _mapper.Map<IList<MenteeApplicationRequestModel>>(result);
            return menteeApplication;
        }
        public async Task<MenteeApplication> GetOne(Guid menteeApplicationId)
        {
            return await _unitOfWork.MenteeApplicationRepository.FindAsync(menteeApplicationId);
        }

        public async Task Update(MenteeApplication menteeApplication)
        {
            try
            {
                var repos = _unitOfWork.MenteeApplicationRepository;
                var existingMenteeApplication = await repos.FindAsync(menteeApplication.Id);
                if (existingMenteeApplication == null)
                    throw new KeyNotFoundException();

                existingMenteeApplication.Status = menteeApplication.Status;

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<ServiceActionResult> GetAllPaging(PagingRequest request, Guid id)
        {
            //Code nay hoi nguu vi getall duoi db len lun , co ma do hoi va time huhuhuuh
            IQueryable<MenteeApplication> MenteeApplications = _unitOfWork.MenteeApplicationRepository.GetAll().AsQueryable();
            var filteredPlans = MenteeApplications.Where(menteeApplication => menteeApplication.UserId == id);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<MenteeApplication, MenteeApplicationRequestModel>(_mapper, filteredPlans, request.PageSize ?? 0, request.PageIndex ?? 0);

            return new ServiceActionResult(true) { Data = paginationResult };
        }
    }
}
