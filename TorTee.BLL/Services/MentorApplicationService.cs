﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Helpers;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.BLL.Models.Responses.MentorApplications;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Dtos;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;
using TorTee.Core.Helpers;
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
        private readonly RoleManager<Role> _roleManager;

        public MentorApplicationService(IUnitOfWork unitOfWork,
            IMapper mapper, IFileStorageService fileStorageService, UserManager<User> userManager, IEmailService emailService, RoleManager<Role> roleManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _userManager = userManager;
            _emailService = emailService;
            _roleManager = roleManager;
        }
        public async Task<ServiceActionResult> CreateMentorApplication(CreateMentorApplicationRequest applicationRequest)
        {
            var mentorApplication = _mapper.Map<MentorApplication>(applicationRequest);

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

        public async Task<ServiceActionResult> GetAllApplications(MentorApplicationRequest queryParameters)
        {
            IQueryable<MentorApplication> applicationQuery = (await _unitOfWork.MentorApplicationRepository.GetAllAsyncAsQueryable()).Include(a => a.User);

            if (!string.IsNullOrEmpty(queryParameters.Status))
            {
                applicationQuery = applicationQuery.Where(m => (int)m.Status == EnumHelper.CompareStatus<ApplicationStatus>(queryParameters.Status));
            }

            if (!string.IsNullOrEmpty(queryParameters.Search))
            {
                applicationQuery = applicationQuery.Where(m => m.FullName.Contains(queryParameters.Search) || m.PhoneNumber.Equals(queryParameters.Search) || m.Email.Equals(queryParameters.Search));
            }

            applicationQuery = queryParameters.IsDesc ? applicationQuery.OrderByDescending(a => a.AppliedDate) : applicationQuery.OrderBy(a => a.AppliedDate);

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

            if (status.Equals(application.Status.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return new ServiceActionResult(false) { Detail = $"Application is already in {status} status" };
            }
            else if (application.Status.ToString().Equals(ApplicationStatus.ACCEPTED.ToString(), StringComparison.OrdinalIgnoreCase)
                || application.Status.ToString().Equals(ApplicationStatus.DENIED.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                return new ServiceActionResult(false) { Detail = $"Application is already in {application.Status.ToString()} status. Can not modify." };
            }
            else if (status.Equals(ApplicationStatus.ACCEPTED.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                var account = await RegisterMentorAsync(application);
                application.Status = ApplicationStatus.ACCEPTED;
                var user = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                    .Where(u => u.Email.ToLower().Equals(account.Email.ToLower())).FirstOrDefault() ?? throw new ArgumentNullException("Can not retrieve this mentor");
                user.MenteePlans = new MenteePlan()
                {
                    Id = new Guid(),
                    CallPerMonth = application.CallPerMonth,
                    DescriptionOfPlan = application.DescriptionOfPlan,
                    Price = application.Price,
                    DurationOfMeeting = application.DurationOfMeeting,
                    TotalSlot = application.TotalSlot
                };
                await _unitOfWork.CommitAsync();
                await _emailService.SendEmailAsync(application.Email, "YOU HAVE NEW INFORMATION FROM TORTEE", EmailHelper.GetAcceptedEmailBody("totementoring@gmail.com", application.Email, account.Password), true);
            }
            else if (status.Equals(ApplicationStatus.DENIED.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                application.Status = ApplicationStatus.DENIED;
                await _unitOfWork.CommitAsync();
                await _emailService.SendEmailAsync(application.Email, "YOU HAVE NEW INFORMATION FROM TORTEE", EmailHelper.GetRejectedEmailBody(application.FullName, "Tortee"), true);
            }

            return new ServiceActionResult();
        }

        private async Task<UserToLoginDTO> RegisterMentorAsync(MentorApplication application)
        {
            var user = await _userManager.FindByEmailAsync(application.Email);

            if (user != null)
            {
                if (!await _roleManager.RoleExistsAsync(UserRoleConstants.MENTOR))
                {
                    await _roleManager.CreateAsync(new Role { Name = UserRoleConstants.MENTOR });
                }
                var roleResultIn = await _userManager.AddToRoleAsync(user, UserRoleConstants.MENTOR);

                if (!roleResultIn.Succeeded)
                {
                    var error = roleResultIn.Errors.First().Description;
                    throw new AddRoleException(error);
                }
                return new UserToLoginDTO() { Email = application.Email, Password = "Your currently password in my system" };
            }

            var userEntity = new User { Email = application.Email, UserName = application.Email, FullName = application.FullName, PhoneNumber = application.PhoneNumber };
            var password = GenerateRandomPassword();

            var result = await _userManager.CreateAsync(userEntity, password);

            if (!result.Succeeded)
            {
                var error = result.Errors.First().Description;
                throw new Exception(error);
            }

            if (!await _roleManager.RoleExistsAsync(UserRoleConstants.MENTOR))
            {
                await _roleManager.CreateAsync(new Role { Name = UserRoleConstants.MENTOR });
            }
            var roleResult = await _userManager.AddToRoleAsync(userEntity, UserRoleConstants.MENTOR);
            if (!roleResult.Succeeded)
            {
                await _userManager.DeleteAsync(userEntity);
                throw new AddRoleException("Can not create account with role Mentor");
            }

            userEntity.EmailConfirmed = true;
            await _userManager.UpdateAsync(userEntity);

            return new UserToLoginDTO() { Email = application.Email, Password = password };
        }

        private string GenerateRandomPassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string numericChars = "0123456789";
            const string specialChars = "!@#$%^&*()_+";

            string allChars = upperChars + lowerChars + numericChars + specialChars;

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // Ensure at least one character from each character set
            password.Append(upperChars[random.Next(upperChars.Length)]);
            password.Append(lowerChars[random.Next(lowerChars.Length)]);
            password.Append(numericChars[random.Next(numericChars.Length)]);

            // Fill the remaining characters randomly
            for (int i = 3; i < 8; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Shuffle the password characters
            string shuffledPassword = new string(password.ToString().OrderBy(c => random.Next()).ToArray());

            return shuffledPassword;
        }

    }
}
