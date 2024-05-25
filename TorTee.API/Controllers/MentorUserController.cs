using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Helpers;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api/MentorUser")]
    public class MentorUserController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;
        private readonly IUserSkillService _userSkillService;
        private readonly IBookingPlanService _bookingPlanService;
        private readonly IMentorPlanService _mentorPlanService;

        public MentorUserController(IMentorUserService MentorUserService, IUserSkillService userSkillService, IBookingPlanService bookingPlanService, IMentorPlanService mentorPlanService)
        {
            _mentorUserService = MentorUserService;
            _userSkillService = userSkillService;
            _bookingPlanService = bookingPlanService;
            _mentorPlanService = mentorPlanService;
        }

        // GET: api/MentorUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllMentors()
        {
            var mentors = await _mentorUserService.GetAll();
            return Ok(mentors);
        }

        // GET: api/MentorUser/{id}
        [HttpGet("GetMentorById/{{id}}")]
        public async Task<ActionResult<User>> GetMentorById(Guid id)
        {
            var mentor =  _mentorUserService.GetDetailOne(id);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        [HttpGet("GetAllSkillMentorById/{{id}}")]
        public async Task<ActionResult<UserSkill>> GetAllUserSkillById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _userSkillService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        [HttpGet("GetAllBookingCallMentorById/{{id}}")]
        public async Task<ActionResult<Session>> GetAlBookingCallById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _bookingPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }
        [HttpGet("GetAllMentorPlanMentorById/{{id}}")]
        public async Task<ActionResult<MenteePlan>> GetAllMentorPlanById(Guid id, [FromQuery] FormSearch search)
        {
            var mentor = _mentorPlanService.GetDetailOne(id, search.currentPage, search.pageSize);
            if (mentor == null)
            {
                return NotFound();
            }
            return Ok(mentor);
        }

        // POST: api/MentorUser
        [HttpPost]
        public async Task<ActionResult> AddMentor([FromBody] User mentor)
        {
            if (mentor == null)
            {
                return BadRequest();
            }

            await _mentorUserService.Add(mentor);
            return CreatedAtAction(nameof(GetMentorById), new { id = mentor.Id }, mentor);
        }

        // PUT: api/MentorUser/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateMentor(Guid id, [FromBody] MentorProfileUpdateRequestModel mentor)
        {
            //if (mentor == null || id != mentor.Id)
            //{
            //    return BadRequest();
            //}

            //var existingMentor = await _mentorUserService.GetOne(id);
            //if (existingMentor == null)
            //{
            //    return NotFound();
            //}

            await _mentorUserService.Update(mentor);
            return NoContent();
        }

        // DELETE: api/MentorUser/{id}
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMentor(Guid id)
        {
            var mentor = await _mentorUserService.GetOne(id);
            if (mentor == null)
            {
                return NotFound();
            }

            await _mentorUserService.Delete(id);
            return NoContent();
        }

    }
}
