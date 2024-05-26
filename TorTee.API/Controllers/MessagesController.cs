using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MessagesController
    {
        private readonly IMessageService _messageService;
        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }
    }
}
