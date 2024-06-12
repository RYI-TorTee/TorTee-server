using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MenteePlanService : IMenteePlanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenteePlanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceActionResult> GetPlan(Guid mentorId)
        {
            var plan = (await _unitOfWork.MentorPlanRepository.GetAllAsyncAsQueryable())
                .Include(mp=>mp.MenteeApplications)
                .Where(mp => mp.MentorId == mentorId).FirstOrDefault() ?? throw new NullReferenceException();

            return new ServiceActionResult();
        }
    }
}
