using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;
        private readonly IUserClaimsService _userClaimsService;
        private UserClaims _userClaims;
        public AccountController(IAccountService accountService, IUserClaimsService userClaimsService)
        {
            _accountService = accountService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpGet("my-profile")]
        [Authorize]
        public async Task<IActionResult> GetMyProfile()
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.GetDetails(_userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserDetails(Guid id)
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.GetDetails(id).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateProfile([FromForm] UserRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdateDetails(request, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPut("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(UpdatePasswordRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdatePassword(request, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPut("update-avatar")]
        [Authorize]
        public async Task<IActionResult> UpdateAvatar([FromForm] IFormFile request)
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdateAvatar(request, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
