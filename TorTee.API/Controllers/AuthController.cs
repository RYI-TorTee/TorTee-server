using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Dtos;
using TorTee.Core.Dtos;

namespace TorTee.API.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserToRegisterDTO request)
        {
            return await ExecuteServiceLogic(
                async () => await _authService.RegisterAsync(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserToLoginDTO request)
        {
            return await ExecuteServiceLogic(
                async () => await _authService.LoginAsync(request).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            return await ExecuteServiceLogic(
                async () => await _authService.ConfirmEmail(userId, token).ConfigureAwait(false)
            ).ConfigureAwait(false);
        }

        [HttpPost("logout")]
        [Authorize]
        public IActionResult Logout()
        {
            // Remove the JWT token cookie
            HttpContext.Response.Cookies.Delete("token");
            return Ok();
        }

        [HttpPost("forgot-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            return await ExecuteServiceLogic(
               async () => await _authService.ForgotPassword(request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPost("reset-password")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            return await ExecuteServiceLogic(
              async () => await _authService.ResetPassword(request).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }
    }
}
