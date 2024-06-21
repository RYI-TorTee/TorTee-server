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
            var mentorQuery = isSortByRating && queryParameters.IsDesc == false ? await GetMentorOrderByRating(false) : await GetMentorOrderByRating();

            mentorQuery.Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);

            if (!string.IsNullOrEmpty(queryParameters.Search))
            {
                mentorQuery = mentorQuery.Where(m => m.FullName.Contains(queryParameters.Search));
            }

            if (queryParameters?.Filter?.Count > 0)
            {
                mentorQuery = mentorQuery.ApplyFilters(queryParameters.Filter);
            }

            if (!string.IsNullOrEmpty(queryParameters?.OrderBy) && (!queryParameters.OrderBy?.Equals("AverageRating") ?? false))
            {
                mentorQuery = mentorQuery.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc);
            }

            var paginationResult = PaginationHelper
            .BuildPaginatedResult<User, MentorOverviewResponse>(_mapper, mentorQuery, queryParameters.PageSize, queryParameters.PageIndex);
            return new ServiceActionResult(true) { Data = paginationResult };
        }

        public async Task<ServiceActionResult> RecommendationMentorList(PagingRequest request)
        {
            var mentorQuery = (await GetMentorOrderByRating()).Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<User, MentorOverviewResponse>(_mapper, mentorQuery, request.PageSize, request.PageIndex);

            return new ServiceActionResult(true) { Data = paginationResult };
        }

        private async Task<IQueryable<User>> GetMentorOrderByRating(bool isDesc = true)
        {
            var mentors = await _unitOfWork.UserRepository.GetAllMentorAsync();

            // Include related entities to get the feedbacks through MenteePlan and MenteeApplications
            var mentorQuery = mentors
                    .Include(m => m.MenteePlan)?
                    .ThenInclude(p => p.MenteeApplications)
                    .ThenInclude(a => a.Feedback);

            // Compute the average rating for each mentor

            var mentorQueryOrderByRating = mentors
                  .Select(m => new
                  {
                      Mentor = m,
                      AverageRating = m.MenteePlan.MenteeApplications
                          .Where(a => a.Feedback != null)
                          .Select(a => (double?)a.Feedback.Rating) // Use nullable double
                          .Average() ?? 0 // Default to 0 if there are no feedbacks
                  });

            // Order mentors by average rating
            var orderedMentors = isDesc
                ? mentorQueryOrderByRating.OrderByDescending(m => m.AverageRating)
                : mentorQueryOrderByRating.OrderBy(m => m.AverageRating);

            // Project the result to only include mentors
            var sortedMentors = orderedMentors.Select(m => m.Mentor);

            return sortedMentors;
        }
    }
}
