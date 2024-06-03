using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Responses.MentorApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Extensions;
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

        public async Task<ServiceActionResult> GetAllApplications(QueryParametersRequest queryParameters)
        {
            var applicationQuery = (await _unitOfWork.MentorApplicationRepository.GetAllAsyncAsQueryable()).Include(a => a.User);


            if (!string.IsNullOrEmpty(queryParameters.Search))
            {
                applicationQuery.Where(m => m.FullName.Contains(queryParameters.Search) || m.PhoneNumber.Equals(queryParameters.Search) || m.Email.Equals(queryParameters.Search));
            }

            if (queryParameters?.Filter?.Count > 0)
            {
                applicationQuery.ApplyFilters(queryParameters.Filter);
            }

            if (!string.IsNullOrEmpty(queryParameters?.OrderBy))
            {
                applicationQuery.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc);
            }

            var paginationResult = PaginationHelper
            .BuildPaginatedResult<MentorApplication, MentorApplicationResponse>(_mapper, applicationQuery, queryParameters.PageSize ?? 0, queryParameters.PageIndex ?? 0);
            return new ServiceActionResult(true) { Data = paginationResult };

        }

        public async Task<ServiceActionResult> GetApplication(Guid id)
        {
            var application = await _unitOfWork.MentorApplicationRepository.FindAsync(id) ?? throw new ArgumentNullException("Application is not exist");

            var returnApplication = _mapper.Map<MentorApplicationResponse>(application);

            return new ServiceActionResult(true) { Data = returnApplication };
        }
    }
}
