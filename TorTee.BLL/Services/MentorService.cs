using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests;
using TorTee.BLL.Models.Responses.Mentors;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
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
            var mentorQuery = await _unitOfWork.UserRepository.GetAllMentorAsync();

            return new ServiceActionResult(true) { Data = null };
        }

        public async Task<ServiceActionResult> RecommendationMentorList(PagingRequest request)
        {
            var mentorQuery = (await GetMentorOrderByRating()).Include(m => m.UserSkills).ThenInclude(uk => uk.Skill);

            var paginationResult = PaginationHelper
                .BuildPaginatedResult<User, MentorOverviewResponse>(_mapper, mentorQuery, request.PageSize ?? 0, request.PageIndex ?? 5);

            return new ServiceActionResult(true) { Data = paginationResult };
        }

        private async Task<IQueryable<User>> GetMentorOrderByRating()
        {
            var mentorQuery = await _unitOfWork.UserRepository.GetAllMentorAsync();
            var mentorQueryOrderByRating = mentorQuery.Include(m => m.FeedbacksReceived)
                        .Select(m => new
                        {
                            Mentor = m,
                            AverageRating = m.FeedbacksReceived.Any() ? m.FeedbacksReceived.Average(f => f.Rating) : 0
                        })
                        .OrderByDescending(m => m.AverageRating)
                        .Select(m => m.Mentor);
            return mentorQueryOrderByRating;
        }
    }
}
