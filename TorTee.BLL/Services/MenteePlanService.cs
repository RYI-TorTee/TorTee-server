using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Responses.MenteePlans;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MenteePlanService : IMenteePlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MenteePlanService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceActionResult> GetPlan(Guid mentorId, Guid? userId = null)
        {
            var mentor = await _unitOfWork.UserRepository.FindAsync(mentorId) ?? throw new UserNotFoundException("Mentor not found");

            var plan = (await _unitOfWork.MentorPlanRepository.GetAllAsyncAsQueryable())
                .Include(mp => mp.MenteeApplications)
                .Where(mp => mp.MentorId == mentorId).FirstOrDefault() ?? throw new NullReferenceException();

            bool isInMentorPlan = false;
            if (userId.HasValue)
            {
                isInMentorPlan = plan.MenteeApplications?.Any(ma => ma.UserId == userId 
                && ma.EndDate > DateTime.Now 
                && ma.Status == Core.Domains.Enums.ApplicationStatus.PAID) ?? false;
            }
            var planResponse = _mapper.Map<MenteePlanResponse>(plan);
            planResponse.IsInMentorship = isInMentorPlan;            

            return new ServiceActionResult() { Data =  planResponse};
        }
    }
}
