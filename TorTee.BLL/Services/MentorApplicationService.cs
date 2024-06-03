using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Helpers;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Responses.MentorApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
using TorTee.Core.Dtos;
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
        private readonly IEmailService _emailService;

        public MentorApplicationService(IUnitOfWork unitOfWork,
            IMapper mapper, IFileStorageService fileStorageService, UserManager<User> userManager, IEmailService emailService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _userManager = userManager;
            _emailService = emailService;
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

        public async Task<ServiceActionResult> ReviewApplication(Guid id, string status)
        {
            var application = await _unitOfWork.MentorApplicationRepository.FindAsync(id) ?? throw new ArgumentNullException("Application is not exist");

            if(status.Equals(ApplicationStatus.ACCEPTED.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                application.Status = ApplicationStatus.ACCEPTED;
                await _emailService.SendEmailAsync(application.Email, "NEW INFORM FROM TORTEE", EmailHelper.GetAcceptedEmailBody("totementoring@gmail.com", application.Email, ""), true);
            }

            if (status.Equals(ApplicationStatus.DENIED.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                application.Status = ApplicationStatus.DENIED;
                await _emailService.SendEmailAsync(application.Email, "NEW INFORM FROM TORTEE", EmailHelper.GetRejectedEmailBody(application.FullName, "Tortee"), true);
            }

            

            return new ServiceActionResult();
        }

        //private async bool RegisterMentorAsync(MentorApplication application)
        //{
        //    var userEntity = new User { Email = application.Email };

        //    var result = await _userManager.CreateAsync(userEntity, userToRegisterDTO.Password);
        //    if (!result.Succeeded)
        //    {
        //        var error = result.Errors.First();
        //        return new ServiceActionResult(false, error.Description);
        //    }

        //    if (!await _roleManager.RoleExistsAsync(UserRoleConstants.MENTEE))
        //    {
        //        await _roleManager.CreateAsync(new Role { Name = UserRoleConstants.MENTEE });
        //    }
        //    var roleResult = await _userManager.AddToRoleAsync(userEntity, UserRoleConstants.MENTEE);
        //    if (!roleResult.Succeeded)
        //    {
        //        await _userManager.DeleteAsync(userEntity);
        //        throw new AddRoleException("Can not create account with role Mentee");
        //    }

        //    var token = await _userManager.GenerateEmailConfirmationTokenAsync(userEntity);
        //    await _emailService.SendEmailConfirmationAsync(userEntity, token);

        //    return new ServiceActionResult(true);
        //}
    }
}
