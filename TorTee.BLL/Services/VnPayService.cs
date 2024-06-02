using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using TorTee.BLL.Constants;
using TorTee.BLL.Helpers;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.VnPays;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Settings;

namespace TorTee.BLL.Services
{
    public class VnPayService : IVnPayService
    {
        private readonly VNPaySettings _vnPaySettings;
        public VnPayService(IOptions<VNPaySettings> vnPaySettings)
        {
            _vnPaySettings = vnPaySettings.Value;
        }

        public ServiceActionResult CreatePaymentUrl(HttpContext context, VnPayRequest vnPayRequest)
        {
            var tick = DateTime.Now.Ticks.ToString();

            var vnpay = new VnPayLibrary();

            vnpay.AddRequestData(VnPayConstansts.VERSION, _vnPaySettings.Version);
            vnpay.AddRequestData(VnPayConstansts.COMMAND, _vnPaySettings.Command);
            vnpay.AddRequestData(VnPayConstansts.TMN_CODE, _vnPaySettings.TmnCode);
            vnpay.AddRequestData(VnPayConstansts.AMOUNT, (vnPayRequest.Amount * 100).ToString());              
            vnpay.AddRequestData(VnPayConstansts.CREATE_DATE, vnPayRequest.CreatedDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData(VnPayConstansts.CURR_CODE, _vnPaySettings.CurrencyCode);
            vnpay.AddRequestData(VnPayConstansts.IP_ADDRESS, Utils.GetIpAddress(context));           
            vnpay.AddRequestData(VnPayConstansts.LOCALE, _vnPaySettings.Locale);           
            vnpay.AddRequestData(VnPayConstansts.ORDER_INFOR, vnPayRequest.OrderInfo);
            vnpay.AddRequestData(VnPayConstansts.ORDER_TYPE, vnPayRequest.OrderType); 
            vnpay.AddRequestData(VnPayConstansts.RETURN_URL, _vnPaySettings.ReturnUrl);
            vnpay.AddRequestData(VnPayConstansts.TXN_REF, tick);        

            string paymentUrl = vnpay.CreateRequestUrl(_vnPaySettings.BaseUrl, _vnPaySettings.HashSecret);

            return new ServiceActionResult(){ Data = paymentUrl };
        }

        public ServiceActionResult PaymentExecute(IQueryCollection collections)
        {
            var vnpay = new VnPayLibrary();

            foreach(var(key,value) in collections)
            {
                if (!string.IsNullOrEmpty(key) && key.StartsWith("vnp_"))
                {
                    vnpay.AddResponseData(key, value.ToString());
                }
            }

            var vnpOrderId = Convert.ToInt64(vnpay.GetResponseData(VnPayConstansts.TXN_REF));
            var vnpTransactionId = Convert.ToInt64(vnpay.GetResponseData(VnPayConstansts.))

            bool checkSignature = vnpay.ValidateSignature()
        }
    }
}
