using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MessagesController : BaseApiController
    {
        private readonly IMessageService _messageService;
        private readonly IUserClaimsService _userClaimsService;
        private UserClaims _userClaims;

        public MessagesController(IMessageService messageService, IUserClaimsService userClaimsService)
        {
            _messageService = messageService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpPost("send-message")]
        [Authorize]
        public async Task<IActionResult> SendMessage(CreateMessageRequest messageRequest)
        {           
            return await ExecuteServiceLogic(
           async () => await _messageService.SendMessage(messageRequest, _userClaims.UserId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("my-chats")]
        [Authorize]
        public async Task<IActionResult> GetMyChatBoxs()
        {
            return await ExecuteServiceLogic(
           async () => await _messageService.GetMyChatBoxs(_userClaims.UserId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("messages")]
        [Authorize]
        public async Task<IActionResult> GetMessagesFromChatBox([FromQuery]ChatBoxParams chatBoxParams)
        {
            return await ExecuteServiceLogic(
           async () => await _messageService.GetMessagesOfAChat(chatBoxParams, _userClaims.UserId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("search-chat")]
        [Authorize]
        public async Task<IActionResult> SearchMessages([FromQuery] string search)
        {            
            return await ExecuteServiceLogic(
           async () => await _messageService.SearchChat(search).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }
    }
}
