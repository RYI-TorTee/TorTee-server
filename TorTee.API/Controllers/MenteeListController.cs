using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.Mentorship;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{
   

    [ApiController]
    [Route("api/Mentee-List")]
    public class MenteeListController : BaseApiController
    {

        private readonly ILogger<MenteeListController> _logger;
        private readonly IMentorShipService _mentorShipService;

        public MenteeListController(
      
            ILogger<MenteeListController> logger, IMentorShipService mentorShipService)
        {
       
            _mentorShipService = mentorShipService;
            _logger = logger;
        }

   

        [HttpGet("GetAll-Mentee-By-MentorId")]
        public async Task<IActionResult> GetAllMentee(Guid id, [FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
           async () => await _mentorShipService.GetAllPaging(request, id).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

    }

    }
