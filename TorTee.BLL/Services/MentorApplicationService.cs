using AutoMapper;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorApplicationService : IMentorApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;
        public MentorApplicationService(IUnitOfWork unitOfWork,
            IMapper mapper, IFileStorageService fileStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
        }
        public async Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest)
        {
            var mentorApplication = _mapper.Map<MentorApplication>(applicationRequest);
            var CV = await _fileStorageService.UploadFileBlobAsync(applicationRequest.CV);
            mentorApplication.CV = CV;
            await _unitOfWork.MentorApplicationRepository.AddAsync(mentorApplication);
            await _unitOfWork.CommitAsync();
            return new ServiceActionResult();
        }
    }
}
