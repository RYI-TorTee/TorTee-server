using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteeApplications;
using TorTee.BLL.Models.Responses.MenteeApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
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
        public async Task<ServiceActionResult> CreateMenteeApplication(CreateMenteeApplicationRequest request, Guid currentUserId)
        {
            var applicationEntity = _mapper.Map<MenteeApplication>(request);
            applicationEntity.UserId = currentUserId;

            await _unitOfWork.MenteeApplicationRepository.AddAsync(applicationEntity);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }

        public async Task<ServiceActionResult> GetAllMenteeApplicationsReceived(Guid mentorId)
        {
            var applications = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(a => a.MenteePlan)
                .Where(a => a.MenteePlan.MentorId == mentorId)
                .Include(a => a.User)
                .ProjectTo<MenteeApplicationResponse>(_mapper.ConfigurationProvider);

            return new ServiceActionResult(true) { Data = applications };

        }

        public async Task<ServiceActionResult> GetAllMenteeApplicationsSent(Guid menteeId)
        {
            var applications = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                 .Where(a => a.UserId == menteeId)
                .Include(a => a.MenteePlan)               
                .ProjectTo<MenteeApplicationResponse>(_mapper.ConfigurationProvider);

            return new ServiceActionResult(true) { Data = applications };
        }

        public async Task<ServiceActionResult> GetMenteeApplicationDetails(Guid Id)
        {
            var application = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Where(a=>a.Id == Id)
                .Include(a=>a.User)
                .Include(a=>a.MenteePlan)
                .ThenInclude(p => p.Mentor)
                .Include(a=>a.MenteeApplicationAnswers)
                .FirstOrDefault();
            return new ServiceActionResult(true) { Data = _mapper.Map<MenteeApplicationResponse>(application)};
        }

        public async Task<ServiceActionResult> UpdateMenteeApplicationStatus(UpdateMenteeApplicationRequest request)
        {
            var application = await _unitOfWork.MenteeApplicationRepository.FindAsync(request.Id);

            Enum.TryParse(request.Status, true, out ApplicationStatus status);
            application.Status = status;

            await _unitOfWork.CommitAsync();

            return new ServiceActionResult(true);
        }
    }
}
