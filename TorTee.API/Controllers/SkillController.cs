using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Services;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class SkillController : BaseApiController
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSkills(string search = "")
        {
            return await ExecuteServiceLogic(
            async () => await _skillService.GetSkillAsync(search).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
