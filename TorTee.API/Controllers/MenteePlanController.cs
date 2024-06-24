using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Exceptions;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MenteePlanController : BaseApiController
    {
        private readonly IMenteePlanService _menteePlanService;
        private readonly IUserClaimsService _userClaimsService;

        public MenteePlanController(IMenteePlanService menteePlanService, IUserClaimsService userClaimsService)
        {
            _menteePlanService = menteePlanService;
            _userClaimsService = userClaimsService;
        }

        [HttpGet("{mentorId}")]
        public async Task<IActionResult> GetMenteePlan(Guid mentorId)
        {
            try
            {
                var userClaims = _userClaimsService.GetUserClaims();
                return await ExecuteServiceLogic(
           async () => await _menteePlanService.GetPlan(mentorId, userClaims.UserId).ConfigureAwait(false)
          ).ConfigureAwait(false);
            }
            catch (UserNotFoundException)
            {
                return await ExecuteServiceLogic(
           async () => await _menteePlanService.GetPlan(mentorId).ConfigureAwait(false)
          ).ConfigureAwait(false);
            }
        }
    }
}
