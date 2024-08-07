﻿using Microsoft.AspNetCore.Identity.Data;
using TorTee.BLL.Models;
using TorTee.Common.Dtos;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Services.IServices
{
    public interface IAuthService
    {
        Task<ServiceActionResult> LoginAsync(UserToLoginDTO userToLoginDTO);
        Task<ServiceActionResult> RegisterAsync(UserToRegisterDTO userToRegisterDTO);
        Task<ServiceActionResult> ConfirmEmail(string userId, string token);
        Task<ServiceActionResult> ForgotPassword(ForgotPasswordRequest request);
        Task<ServiceActionResult> ResetPassword(ResetPasswordRequest request);
    }
}
