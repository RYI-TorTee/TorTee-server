using Net.payOS.Types;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.PayOs;

namespace TorTee.BLL.Services.IServices
{
    public interface IPayOSService
    {
        Task<ServiceActionResult> CreatePaymentLink(PayOsRequest request);
        Task<ServiceActionResult> Webhook(WebhookType request);
    }
}
