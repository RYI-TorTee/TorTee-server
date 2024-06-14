using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;
        private readonly IUserClaimsService _userClaimsService;

        public AccountController(IAccountService accountService, IUserClaimsService userClaimsService)
        {
            _accountService = accountService;
            _userClaimsService = userClaimsService;
        }

        [HttpGet("my-profile")]
        public async Task<IActionResult> GetMyProfile()
        {
            var user = _userClaimsService.GetUserClaims();
            return await ExecuteServiceLogic(
            async () => await _accountService.GetDetails(user.UserId).ConfigureAwait(false)
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
            var user = _userClaimsService.GetUserClaims();
            return await ExecuteServiceLogic(
            async () => await _accountService.UpdateDetails(request, user.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
