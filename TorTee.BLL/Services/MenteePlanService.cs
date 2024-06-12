using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<ServiceActionResult> GetPlan(Guid mentorId)
        {
            var plan = (await _unitOfWork.MentorPlanRepository.GetAllAsyncAsQueryable())
                .Include(mp=>mp.MenteeApplications)
                .Where(mp => mp.MentorId == mentorId).FirstOrDefault() ?? throw new NullReferenceException();

            return new ServiceActionResult() { Data = _mapper.Map<MenteePlanResponse>(plan)};
        }
    }
}
