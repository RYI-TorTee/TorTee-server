using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;
using Microsoft.EntityFrameworkCore;

namespace TorTee.BLL.Services
{
    public class StaffMentorApplicationService : IStaffMentorApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StaffMentorApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task Delete(Guid staffMentorApplicationId)
        {
            try
            {
                var repos = _unitOfWork.MentorApplicationRepository;
                var staffMentorApplication = await repos.GetAsync(sma => sma.Id == staffMentorApplicationId);
                if (staffMentorApplication == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(staffMentorApplication);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<MentorApplication>> GetAll()
        {
            return await _unitOfWork.MentorApplicationRepository.GetAllAsync();
        }

        public IList<MentorApplicationRequestModel> GetDetailOne( int pageSize, int pageIndex)
        {
            Func<IQueryable<MentorApplication>, IOrderedQueryable<MentorApplication>> orderBy = null;
            IList<MentorApplication> result = (IList<MentorApplication>)_unitOfWork.MentorApplicationRepository.GetDetail(null, orderBy, "", pageSize, pageIndex);
            var staffMentorApplication = _mapper.Map<IList<MentorApplicationRequestModel>>(result);
            return staffMentorApplication;
        }

        public async Task<ServiceActionResult> GetAllPaging(PagingRequest request)
        {
          //  var mentorQuery = (await GetMentorOrderByRating()).Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);
            IQueryable<MentorApplication> x = (IQueryable<MentorApplication>)_unitOfWork.MentorApplicationRepository.GetAll();
            var paginationResult = PaginationHelper
                .BuildPaginatedResult<MentorApplication, MentorApplicationRequestModel>(_mapper, x, request.PageSize ?? 0, request.PageIndex ?? 0);
            return new ServiceActionResult(true) { Data = paginationResult };
        }
        private async Task<IQueryable<User>> GetMentorOrderByRating(bool isDesc = true)
        {
            var mentorQuery = await _unitOfWork.UserRepository.GetAllMentorAsync();
            var mentorQueryOrderByRating = mentorQuery.Include(m => m.FeedbacksReceived)
                        .Select(m => new
                        {
                            Mentor = m,
                            AverageRating = m.FeedbacksReceived.Any() ? m.FeedbacksReceived.Average(f => f.Rating) : 0
                        });

            mentorQueryOrderByRating = isDesc
                                   ? mentorQueryOrderByRating.OrderByDescending(m => m.AverageRating)
                                   : mentorQueryOrderByRating.OrderBy(m => m.AverageRating);


            var sortedMentors = mentorQueryOrderByRating.Select(m => m.Mentor);

            return sortedMentors;
        }
        public async Task<MentorApplication> GetOne(Guid staffMentorApplicationId)
        {
            return await _unitOfWork.MentorApplicationRepository.FindAsync(staffMentorApplicationId);
        }

        public async Task Update(MentorApplicationUpdateRequestModel staffMentorApplication)
        {
            try
            {
                var repos = _unitOfWork.MentorApplicationRepository;
                var existingStaffMentorApplication = await repos.FindAsync(staffMentorApplication.Id);
                if (existingStaffMentorApplication == null)
                    throw new KeyNotFoundException();
                existingStaffMentorApplication.Status = staffMentorApplication.Status;


                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public MentorApplicationRequestModel GetOneById(Guid id)
        {
            Expression<Func<MentorApplication, bool>> filter = staffMentorApplication => staffMentorApplication.Id == id;
            Func<IQueryable<MentorApplication>, IOrderedQueryable<MentorApplication>> orderBy = null;
            MentorApplication result = _unitOfWork.MentorApplicationRepository.GetDetail(filter, orderBy, "", 1, 1).FirstOrDefault();
            var staffMentorApplication = _mapper.Map<MentorApplicationRequestModel>(result);
            return staffMentorApplication;
        }

      


    }
}
