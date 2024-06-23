using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class NotificationsController : BaseApiController
    {
        private readonly INotificationService _notificationService;
        private readonly IUserClaimsService _userClaimsService;
        private readonly UserClaims _userClaims;

        public NotificationsController(INotificationService notificationService, IUserClaimsService userClaimsService)
        {
            _notificationService = notificationService;
            _userClaimsService = userClaimsService;
            _userClaims = _userClaimsService.GetUserClaims();
        }

        [HttpGet]
        public async Task<IActionResult> GetMyNotifications([FromQuery] PagingRequest request)
        {
            return await ExecuteServiceLogic(
            async () => await _notificationService.GetAllPaging(_userClaims.UserId, request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpGet("unread-notification")]
        public async Task<IActionResult> GetCountUnreadNoti()
        {
            return await ExecuteServiceLogic(
            async () => await _notificationService.CountUnreadNotification(_userClaims.UserId).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
    }
}
