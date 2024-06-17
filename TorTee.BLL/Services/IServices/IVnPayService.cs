using Microsoft.AspNetCore.Http;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.VnPays;
using TorTee.BLL.Models.Responses.VnPays;

namespace TorTee.BLL.Services.IServices
{
    public interface IVnPayService
    {
        Task<ServiceActionResult> CreatePaymentUrl(HttpContext context, VnPayRequest request);       
        Task<ServiceActionResult> PaymentExecute(VnPayResponse response, bool isIPN = false);
    }
}
