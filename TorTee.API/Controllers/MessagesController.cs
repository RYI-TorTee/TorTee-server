﻿using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Requests.Messages;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class MessagesController : BaseApiController
    {
        private readonly IMessageService _messageService;
        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPost("send-message")]
        public async Task<IActionResult> SendMessage(CreateMessageRequest messageRequest)
        {
            var userId = new Guid();
            return await ExecuteServiceLogic(
           async () => await _messageService.SendMessage(messageRequest, userId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("my-chats")]
        public async Task<IActionResult> GetMyChatBoxs()
        {
            //get id from cookie
            var userId = new Guid("34e51525-5b2c-4b66-29cd-08dc7b8919db");
            return await ExecuteServiceLogic(
           async () => await _messageService.GetMyChatBoxs(userId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("messages")]
        public async Task<IActionResult> GetMessagesFromChatBox([FromQuery]ChatBoxParams chatBoxParams)
        {
            //get id from cookie
            var userId = new Guid("34e51525-5b2c-4b66-29cd-08dc7b8919db");
            return await ExecuteServiceLogic(
           async () => await _messageService.GetMessagesOfAChat(chatBoxParams, userId).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }

        [HttpGet("search-chat")]
        public async Task<IActionResult> SearchMessages([FromQuery] string search)
        {            
            return await ExecuteServiceLogic(
           async () => await _messageService.SearchChat(search).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }
    }
}
