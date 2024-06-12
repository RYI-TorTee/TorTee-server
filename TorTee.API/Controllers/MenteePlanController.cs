using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MenteePlanController : BaseApiController
    {
        private readonly IMenteePlanService _menteePlanService;

        public MenteePlanController(IMenteePlanService menteePlanService)
        {
            _menteePlanService = menteePlanService;
        }

        [HttpGet("{mentorId}")]
        public async Task<IActionResult> GetMenteePlan(Guid mentorId)
        {          
            return await ExecuteServiceLogic(
            async () => await _menteePlanService.GetPlan(mentorId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
