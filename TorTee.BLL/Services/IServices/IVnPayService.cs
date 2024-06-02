using Microsoft.AspNetCore.Http;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.VnPays;

namespace TorTee.BLL.Services.IServices
{
    public interface IVnPayService
    {
        ServiceActionResult CreatePaymentUrl(HttpContext context, VnPayRequest);
        ServiceActionResult PaymentExecute(IQueryCollection collections);
    }
}
