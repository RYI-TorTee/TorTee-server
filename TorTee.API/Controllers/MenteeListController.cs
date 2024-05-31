using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.Mentorship;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{
   

    [ApiController]
    [Route("api/Mentee-List")]
    public class MenteeListController : ControllerBase
    {

        private readonly ILogger<MenteeListController> _logger;
        private readonly IMentorShipService _mentorShipService;

        public MenteeListController(
      
            ILogger<MenteeListController> logger, IMentorShipService mentorShipService)
        {
       
            _mentorShipService = mentorShipService;
            _logger = logger;
        }

        // GET: api/GetAllMenteeByMentorId/{id}
        [HttpGet("GetAllMenteeByMentorId")]
        public async Task<ActionResult<MentorshipRequestModel>> GetAllMenteeByMentorId(Guid id, [FromQuery] FormSearch search)
        {
            try
            {
                var mentorPlans = _mentorShipService.GetDetailOne(id, search.currentPage, search.pageSize);
                if (mentorPlans == null)
                {
                    return NotFound();
                }
                return Ok(mentorPlans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all mentor plans for mentor by id.");
                return StatusCode(500, "Internal server error");
            }
        }

        
        }

    }
