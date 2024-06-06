using TorTee.API.Controllers.Base;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MenteeApplicationController : BaseApiController
    {
        private readonly IMenteeApplicationService _menteeApplicationService;

        public MenteeApplicationController(IMenteeApplicationService menteeApplicationService)
        {
            _menteeApplicationService = menteeApplicationService;
        }
        
    }
}
