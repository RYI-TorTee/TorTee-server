using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class AdminController : BaseApiController
    {
        private readonly IAccountService _accountService;

        public AdminController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetUsers([FromQuery]QueryParametersRequest request)
        {
            return await ExecuteServiceLogic(
                               async () => await _accountService.GetAll(request).ConfigureAwait(false)
                                          ).ConfigureAwait(false);
        }
    }
}
