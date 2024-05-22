using Microsoft.AspNetCore.Mvc;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;

namespace TorTee.API.Controllers
{
    [ApiController]
    [Route("api/MentorUser")]
    public class MentorUserController : ControllerBase
    {
        private readonly IMentorUserService _mentorUserService;

        public MentorUserController(IMentorUserService MentorUserService)
        {
            _mentorUserService = MentorUserService;
        }

        // GET: api/MentorUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllMentors()
        {
            var mentors = await _mentorUserService.GetAll();
            return Ok(mentors);
        }

        // GET: api/MentorUser/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetMentorById(Guid id)
        {
            var mentor = await _mentorUserService.GetOne(id);
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
