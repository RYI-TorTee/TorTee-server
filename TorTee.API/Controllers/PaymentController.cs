using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Net.payOS.Types;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.PayOs;
using TorTee.BLL.Models.Requests.VnPays;
using TorTee.BLL.Models.Responses.VnPays;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class PaymentController(IVnPayService _vnPayService, IPayOSService _payOSService) : BaseApiController
    {

        [HttpPost("create-payment-url")]
        [Authorize]
        public async Task<IActionResult> CreatePaymentUrl(VnPayRequest request)
        {
            var context = HttpContext;
            return await ExecuteServiceLogic(
               async () => await _vnPayService.CreatePaymentUrl(context, request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpGet("payment-callback")]
        public async Task<IActionResult> PaymentCallBack([FromQuery] VnPayResponse response)
        {
            return await ExecuteServiceLogic(
               async () => await _vnPayService.PaymentExecute(response).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpGet("/IPN")]
        public async Task<IActionResult> IPN([FromQuery] VnPayResponse response)
        {
            return await ExecuteServiceLogic(
               async () => await _vnPayService.PaymentExecute(response, true).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }

        [HttpPost("create-payment-url-payOs")]
        [Authorize]
        public async Task<IActionResult> CreatePaymentUrlPayOs(PayOsRequest request)
        {
            return await ExecuteServiceLogic(
               async () => await _payOSService.CreatePaymentLink(request).ConfigureAwait(false)
           ).ConfigureAwait(false);
        }
        [HttpPost("webhook")]
        public async Task<IActionResult> Webhook([FromBody] WebhookType webhookBody)
        {
            return await ExecuteServiceLogic(
              async () => await _payOSService.Webhook(webhookBody).ConfigureAwait(false)
          ).ConfigureAwait(false);
        }
    }
}
