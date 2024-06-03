using Microsoft.AspNetCore.Mvc;
using TorTee.API.Controllers.Base;
using TorTee.BLL.Models.Requests.VnPays;
using TorTee.BLL.Models.Responses.VnPays;
using TorTee.BLL.Services.IServices;

namespace TorTee.API.Controllers
{
    public class PaymentController : BaseApiController
    {
        private readonly IVnPayService _vnPayService;
        public PaymentController(IVnPayService vnPayService)
        {
            _vnPayService = vnPayService;
        }

        [HttpPost("create-payment-url")]
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

    }
}
