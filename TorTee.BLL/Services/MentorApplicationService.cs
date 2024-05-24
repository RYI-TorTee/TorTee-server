using AutoMapper;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorApplicationService : IMentorApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MentorApplicationService(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest)
        {
            var mentorApplication = _mapper.Map<MentorApplication>(applicationRequest);
            await _unitOfWork.MentorApplicationRepository.AddAsync(mentorApplication);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult();
        }
    }
}
