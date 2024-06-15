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
        public async Task<IActionResult> UpdateProfile(UserRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdateDetails(request, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePassword(UpdatePasswordRequest request)
        {
            var user = _userClaimsService.GetUserClaims();
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdatePassword(request, new Guid("34E51525-5B2C-4B66-29CD-08DC7B8919DB")).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
