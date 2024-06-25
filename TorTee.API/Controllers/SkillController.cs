using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Skills;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class SkillController : BaseApiController
    {
        private readonly ISkillService _skillService;
        private readonly IUserClaimsService _userClaimsService;
        private UserClaims _userClaims;

        public SkillController(ISkillService skillService, IUserClaimsService userClaimsService)
        {
            _skillService = skillService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpGet]
        public async Task<IActionResult> GetSkills(string search = "")
        {
            return await ExecuteServiceLogic(
            async () => await _skillService.GetSkillAsync(search, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        [HttpPut("update-my-skill")]
        [Authorize]
        public async Task<IActionResult> PutSkillsOfAUser([FromBody] UserSkillsRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _skillService.UpdateSkillsOfAUser(request, _userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
