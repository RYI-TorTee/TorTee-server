using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Feedbacks;
using TorTee.BLL.Models.Responses.Feedbacks;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> AddFeedback(FeedbackRequest request, Guid menteeId)
        {
            var menteeApplication = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(ma => ma.Feedback).FirstOrDefault()
                ?? throw new ArgumentNullException("Mentorship not found");

            if (menteeApplication.UserId != menteeId)
                throw new ArgumentException("You have no permission to feedback this mentor");

            if (menteeApplication.Status != Core.Domains.Enums.ApplicationStatus.PAID)
                throw new ArgumentException("You can not feedback for this mentor");

            if (menteeApplication.Feedback != null)
                throw new ArgumentException("You have created feedback for this mentor");

            var feedbackEntity = _mapper.Map<Feedback>(request);

            menteeApplication.Feedback = feedbackEntity;
            await _unitOfWork.CommitAsync();

            return new ServiceActionResult();
        }

        public async Task<ServiceActionResult> GetAllFeedbacksOfAMentor(Guid mentorId, PagingRequest request)
        {
            var mentor = (await _unitOfWork.UserRepository.FindAsync(mentorId)) ?? throw new ArgumentNullException("Mentor not found");

            var feedbackQueryable = (await _unitOfWork.FeedbackRepository.GetAllAsyncAsQueryable())
                .Include(a => a.MenteeApplication)
                .ThenInclude(a => a.MenteePlan)
                .Include(a => a.MenteeApplication)
                .ThenInclude(a => a.User)
                .Where(a => a.MenteeApplication.MenteePlan.MentorId == mentorId);

            var paginatedFeedback = PaginationHelper.BuildPaginatedResult<Feedback, FeedbackResponse>(_mapper, feedbackQueryable, request.PageSize, request.PageIndex);

            return new ServiceActionResult() { Data = paginatedFeedback };
        }

        public async Task<ServiceActionResult> GetAllMentorForFeedback(Guid menteeId)
        {
            var mentee = (await _unitOfWork.UserRepository.FindAsync(menteeId)) ?? throw new ArgumentNullException("User not found");

            var menteeApplication = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(ma => ma.MenteePlan)
                .ThenInclude(mp => mp.Mentor)
                .Include(ma => ma.User)
                .Include(ma => ma.Feedback)
                .Where(ma => ma.UserId == menteeId && ma.Status == Core.Domains.Enums.ApplicationStatus.PAID);

            return new ServiceActionResult() { Data = menteeApplication.ProjectTo<MentorForFeedbackResponse>(_mapper.ConfigurationProvider) };
        }
    }
}
