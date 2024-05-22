using TorTee.API.Controllers.Base;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MentorController : BaseApiController
    {
        private readonly IMentorService _mentorService;
        public MentorController(IMentorService mentorService)
        {
            _mentorService = mentorService;
        }S
    }
}
