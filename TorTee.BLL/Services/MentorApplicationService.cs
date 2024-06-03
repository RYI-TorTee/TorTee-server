using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TorTee.BLL.Exceptions;
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
        private readonly UserManager<User> _userManager;
        public MentorApplicationService(IUnitOfWork unitOfWork,
            IMapper mapper, IFileStorageService fileStorageService, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _userManager = userManager;
        }
        public async Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest)
        {
            var mentorApplication = _mapper.Map<MentorApplication>(applicationRequest);

            var user = await _userManager.FindByEmailAsync(applicationRequest.Email);

            if (user != null)
                throw new BusinessRuleException($"This email has used in our system");

            try
            {
                var CV = await _fileStorageService.UploadFileBlobAsync(applicationRequest.CV);
                mentorApplication.CV = CV;
                await _unitOfWork.MentorApplicationRepository.AddAsync(mentorApplication);
                await _unitOfWork.CommitAsync();
                return new ServiceActionResult();
            }
            catch
            {
                throw new BusinessRuleException("Can not upload your CV");
            }
            
        }
    }
}
