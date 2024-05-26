using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Extensions;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorService : IMentorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MentorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> BrowseMentorList(QueryParametersRequest queryParameters)
        {
            var isSortByRating = queryParameters.OrderBy?.Equals("AverageRating") ?? false;
            var mentorQuery = isSortByRating && queryParameters.IsDesc == false ? await GetMentorOrderByRating(false) :await GetMentorOrderByRating();

            mentorQuery.Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);

            if (!string.IsNullOrEmpty(queryParameters.Search))
            {
                mentorQuery.Where(m=>m.FullName.Contains(queryParameters.Search));
            }
            
            if(queryParameters?.Filter?.Count > 0)
            {
                mentorQuery.ApplyFilters(queryParameters.Filter);
            }
            try
            {
                if (!string.IsNullOrEmpty(queryParameters?.OrderBy))
                {
                    mentorQuery.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc);
                }
            }
            catch
            {

            }
           


            var paginationResult = PaginationHelper
            .BuildPaginatedResult<User, MentorOverviewResponse>(_mapper, mentorQuery, queryParameters.PageSize ?? 0, queryParameters.PageIndex ?? 0);
            return new ServiceActionResult(true) { Data = paginationResult };
        }

        public async Task<ServiceActionResult> RecommendationMentorList(PagingRequest request)
        {
            var mentorQuery = (await GetMentorOrderByRating()).Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<User, MentorOverviewResponse>(_mapper, mentorQuery, request.PageSize ?? 0, request.PageIndex ?? 0);

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
    }
}
