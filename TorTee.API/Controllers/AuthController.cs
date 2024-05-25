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
    }
}
