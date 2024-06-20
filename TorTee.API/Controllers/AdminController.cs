using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Users;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class AdminController : BaseApiController
    {
        private readonly IAccountService _accountService;
        private readonly ITransactionService _transactionService;

        public AdminController(IAccountService accountService, ITransactionService transactionService)
        {
            _accountService = accountService;
            _transactionService = transactionService;
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers([FromQuery]QueryParametersRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _accountService.GetAll(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpPost("staff-creation")]
        public async Task<IActionResult> GetUsers([FromBody] CreateStaffAccountRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _accountService.AddStaffAccount(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpGet("staffs")]
        public async Task<IActionResult> GetStaffs([FromQuery]QueryParametersRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _accountService.GetAllStaffAccount(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpGet("mentors")]
        public async Task<IActionResult> GetMentors([FromQuery] QueryParametersRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _accountService.GetAllMentorAccount(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }

        [HttpGet("transaction")]
        public async Task<IActionResult> GetTransaction([FromQuery] QueryParametersRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _transactionService.GetAll(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }
    }
}
