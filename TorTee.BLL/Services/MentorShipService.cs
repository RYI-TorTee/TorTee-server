using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Mentorship;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorShipService : IMentorShipService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MentorShipService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(MentorshipCreateRequestModel mentorShipCreate)
        {
            try
            {
                var mentorShip = _mapper.Map<Mentorship>(mentorShipCreate);
                var repos = _unitOfWork.MentorshipRepository;
                await repos.AddAsync(mentorShip);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid mentorShipId)
        {
            try
            {
                var repos = _unitOfWork.MentorshipRepository;
                var mentorShip = await repos.GetAsync(ms => ms.Id == mentorShipId);
                if (mentorShip == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(mentorShip);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<Mentorship>> GetAll()
        {
            return await _unitOfWork.MentorshipRepository.GetAllAsync();
        }

        public IList<MentorshipRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<Mentorship, bool>> filter = mentorShip => mentorShip.MentorId == id;
            Func<IQueryable<Mentorship>, IOrderedQueryable<Mentorship>> orderBy = null;
            IList<Mentorship> result = (IList<Mentorship>)_unitOfWork.MentorshipRepository.GetDetail(filter, orderBy, null, pageSize, pageIndex);
            var mentorShip = _mapper.Map<IList<MentorshipRequestModel>>(result);
            return mentorShip;
        }


        public async Task<ServiceActionResult> GetAllPaging(PagingRequest request, Guid id)
        {
            //Code nay hoi nguu vi getall duoi db len lun , co ma do hoi va time huhuhuuh
            IQueryable<Mentorship> mentorships = _unitOfWork.MentorshipRepository.GetAll().AsQueryable();
            var filteredPlans = mentorships.Where(mentorship => mentorship.MentorId == id);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<Mentorship, MentorshipRequestModel>(_mapper, filteredPlans, request.PageSize ?? 0, request.PageIndex ?? 0);

            return new ServiceActionResult(true) { Data = paginationResult };
        }
        public async Task<Mentorship> GetOne(Guid mentorShipId)
        {
            return await _unitOfWork.MentorshipRepository.FindAsync(mentorShipId);
        }

        public async Task Update(MentorshipUpdateRequestModel mentorShip)
        {
            try
            {
                var repos = _unitOfWork.MentorshipRepository;
                var existingMentorShip = await repos.FindAsync(mentorShip.Id);
                if (existingMentorShip == null)
                    throw new KeyNotFoundException();
                existingMentorShip.MenteeId = mentorShip.MenteeId;
                existingMentorShip.MentorId = mentorShip.MenteeId;
                existingMentorShip.StartDate = mentorShip.StartDate;
                existingMentorShip.EndDate = mentorShip.EndDate;

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public MentorshipRequestModel GetOneById(Guid id)
        {
            Expression<Func<Mentorship, bool>> filter = mentorShip => mentorShip.Id == id;
            Func<IQueryable<Mentorship>, IOrderedQueryable<Mentorship>> orderBy = null;
            Mentorship result = _unitOfWork.MentorshipRepository.GetDetail(filter, orderBy, null, 1, 1).FirstOrDefault();
            var mentorShip = _mapper.Map<MentorshipRequestModel>(result);
            return mentorShip;
        }
    }
}
