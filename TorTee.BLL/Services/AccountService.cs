﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Models.Responses.Users;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
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

        public AccountService(IUnitOfWork unitOfWork, IMapper mapper, IFileStorageService fileStorageService, UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorageService = fileStorageService;
            _userManager = userManager;
        }

        public async Task<ServiceActionResult> GetAll(QueryParametersRequest queryParameters)
        {
            var userQueryable = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable());

            userQueryable = string.IsNullOrEmpty(queryParameters.Search)
                ? userQueryable.Where(u => u.FullName.Contains(queryParameters.Search) || u.Email!.Contains(queryParameters.Search))
                : userQueryable;

            userQueryable = queryParameters.Filter != null ? userQueryable.ApplyFilters(queryParameters.Filter) : userQueryable;
            userQueryable = !string.IsNullOrEmpty(queryParameters.OrderBy)
                ? userQueryable.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc)
                : userQueryable.OrderByDescending(u => u.CreatedDate);

            return new ServiceActionResult()
            {
                Data = PaginationHelper.BuildPaginatedResult<User, UserResponse>
                (_mapper, userQueryable.Include(u => u.UserRoles)!.ThenInclude(r => r.Role), queryParameters.PageSize, queryParameters.PageIndex)
            };
        }

        public async Task<ServiceActionResult> GetDetails(Guid id)
        {
            var entity = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                .Where(u => u.Id == id).Include(u => u.UserSkills)!.ThenInclude(uk => uk.Skill).FirstOrDefault()
                ?? throw new NullReferenceException("User are not found");

            return new ServiceActionResult() { Data = _mapper.Map<UserResponse>(entity) };
        }

        public async Task<ServiceActionResult> UpdateDetails(UserRequest request, Guid userId)
        {
            var user = await _unitOfWork.UserRepository.FindAsync(userId);
            ArgumentNullException.ThrowIfNull(nameof(user));

            _mapper.Map(request, user);

            if (request.ProfilePic != null)
            {
                var imageUrl = await _fileStorageService.UploadFileBlobAsync(request.ProfilePic);
                user.ProfilePic = imageUrl;
            }
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
