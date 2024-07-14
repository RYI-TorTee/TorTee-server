using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Models.Responses.Roles;
using TorTee.BLL.Models.Responses.Users;
using TorTee.BLL.Services.IServices;
using TorTee.BLL.Utilities;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Extensions;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _fileStorageService;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper,
            IFileStorageService fileStorageService,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<ServiceActionResult> AddStaffAccount(CreateStaffAccountRequest request)
        {
            var userEntity = _mapper.Map<User>(request);
            var password = AccountCreationHelper.GenerateRandomPassword();
            userEntity.PassAutoGenerate = password;
            var result = _userManager.CreateAsync(userEntity, password).Result;
            if (!result.Succeeded)
            {
                var error = result.Errors.First();
                return new ServiceActionResult(false, error.Description);
            }

            if (!await _roleManager.RoleExistsAsync(UserRoleConstants.STAFF))
            {
                await _roleManager.CreateAsync(new Role { Name = UserRoleConstants.STAFF });
            }
            var roleResult = await _userManager.AddToRoleAsync(userEntity, UserRoleConstants.STAFF);
            if (!roleResult.Succeeded)
            {
                await _userManager.DeleteAsync(userEntity);
                throw new AddRoleException($"Can not create account with role {UserRoleConstants.STAFF}");
            }

            userEntity.EmailConfirmed = true;
            await _userManager.UpdateAsync(userEntity);

            return new ServiceActionResult(true) { Data = new { UserName = userEntity.UserName, Password = password, CreatedDate = userEntity.CreatedDate } };
        }

        public async Task<ServiceActionResult> UpdateAvatar(IFormFile newAvatar, Guid userId)
        {
            var user = await _unitOfWork.UserRepository.FindAsync(userId);
            ArgumentNullException.ThrowIfNull(nameof(user));

            var imageUrl = await _fileStorageService.UploadFileBlobAsync(newAvatar);
            user.ProfilePic = imageUrl;

            await _unitOfWork.CommitAsync();
            return new ServiceActionResult() { Data = imageUrl};
        }

        public async Task<ServiceActionResult> GetAll(QueryParametersRequest queryParameters)
        {
            var userQueryable = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable());

            userQueryable = !string.IsNullOrEmpty(queryParameters.Search)
                ? userQueryable.Where(u => u.FullName.Contains(queryParameters.Search) || u.Email!.Contains(queryParameters.Search))
                : userQueryable;

            userQueryable = !string.IsNullOrEmpty(queryParameters.OrderBy)
                ? userQueryable.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc)
                : userQueryable.OrderByDescending(u => u.CreatedDate);

            return new ServiceActionResult()
            {
                Data = PaginationHelper.BuildPaginatedResult<User, UserResponse>
                (_mapper, userQueryable.Include(u => u.UserRoles)!.ThenInclude(r => r.Role), queryParameters.PageSize, queryParameters.PageIndex)
            };
        }

        public async Task<ServiceActionResult> GetAllMentorAccount(QueryParametersRequest queryParameters)
        {
            var userQueryable = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable());

            userQueryable = !string.IsNullOrEmpty(queryParameters.Search)
                ? userQueryable.Where(u => u.FullName.Contains(queryParameters.Search) || u.Email!.Contains(queryParameters.Search))
                : userQueryable;


            userQueryable = !string.IsNullOrEmpty(queryParameters.OrderBy)
                ? userQueryable.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc)
                : userQueryable.OrderByDescending(u => u.CreatedDate);

            return new ServiceActionResult()
            {
                Data = PaginationHelper.BuildPaginatedResult<User, UserResponse>
                (_mapper,
                userQueryable.Include(u => u.UserRoles)!.ThenInclude(r => r.Role)
                .Where(u => u.UserRoles.Any(r => r.Role.Name.Equals(UserRoleConstants.MENTOR))),
                queryParameters.PageSize, queryParameters.PageIndex)
            };
        }

        public async Task<ServiceActionResult> GetAllStaffAccount(QueryParametersRequest queryParameters)
        {
            var userQueryable = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable());

            userQueryable = !string.IsNullOrEmpty(queryParameters.Search)
                ? userQueryable.Where(u => u.FullName.Contains(queryParameters.Search) || u.UserName!.Contains(queryParameters.Search))
                : userQueryable;


            userQueryable = !string.IsNullOrEmpty(queryParameters.OrderBy)
                ? userQueryable.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc)
                : userQueryable.OrderByDescending(u => u.CreatedDate);

            return new ServiceActionResult()
            {
                Data = PaginationHelper.BuildPaginatedResult<User, UserResponse>
                (_mapper,
                userQueryable.Include(u => u.UserRoles)!.ThenInclude(r => r.Role)
                .Where(u => u.UserRoles.Any(r => r.Role.Name.Equals(UserRoleConstants.STAFF))),
                queryParameters.PageSize, queryParameters.PageIndex)
            };
        }

        public async Task<ServiceActionResult> GetDetails(Guid id)
        {
            var entity = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())                
                .Where(u => u.Id == id)
                .Include(u => u.UserRoles)!.ThenInclude(ur => ur.Role)
                .Include(u => u.UserSkills)!.ThenInclude(uk => uk.Skill).FirstOrDefault()
                ?? throw new NullReferenceException("User are not found");

            var returnUser = _mapper.Map<UserResponse>(entity);
            returnUser.UserRoles = entity.UserRoles.Select(ur => ur.Role).Select(r => new RoleResponse { Name = r.Name }).ToList();

            return new ServiceActionResult() { Data =  returnUser};
        }

        public async Task<ServiceActionResult> UpdateDetails(UserRequest request, Guid userId)
        {
            var user = await _unitOfWork.UserRepository.FindAsync(userId);
            ArgumentNullException.ThrowIfNull(nameof(user));

            _mapper.Map(request, user);

            await _unitOfWork.CommitAsync();
            return new ServiceActionResult();
        }

        public async Task<ServiceActionResult> UpdatePassword(UpdatePasswordRequest request, Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return new ServiceActionResult(false, "User not found");
            }

            var result = await _userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);

            if (!result.Succeeded)
            {
                var error = result.Errors.First();
                return new ServiceActionResult(false, error.Description);
            }

            return new ServiceActionResult();
        }
    }
}
