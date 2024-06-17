using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Reflection;
using TorTee.BLL.Constants;
using TorTee.BLL.Helpers;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.VnPays;
using TorTee.BLL.Models.Responses.VnPays;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Settings;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class VnPayService : IVnPayService
    {
        private readonly VNPaySettings _vnPaySettings;
        private readonly IUnitOfWork _unitOfWork;

        public VnPayService(IOptions<VNPaySettings> vnPaySettings, IUnitOfWork unitOfWork)
        {
            _vnPaySettings = vnPaySettings.Value;
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceActionResult> CreatePaymentUrl(HttpContext context, VnPayRequest vnPayRequest)
        {
            var applicationId = new Guid(vnPayRequest.OrderInfo ?? throw new Exception("Invalid application"));
            var application = await _unitOfWork.MenteeApplicationRepository.FindAsync(applicationId) ?? throw new Exception("Invalid application");
            if (application.Status == Core.Domains.Enums.ApplicationStatus.PAID)
            {
                return new ServiceActionResult(false)
                {
                    Detail = "Application is already paid"
                };
            }
            var tick = DateTime.Now.Ticks.ToString();

            var vnpay = new VnPayLibrary();

            vnpay.AddRequestData(VnPayConstansts.VERSION, _vnPaySettings.Version);
            vnpay.AddRequestData(VnPayConstansts.COMMAND, _vnPaySettings.Command);
            vnpay.AddRequestData(VnPayConstansts.TMN_CODE, _vnPaySettings.TmnCode);
            vnpay.AddRequestData(VnPayConstansts.AMOUNT, (vnPayRequest.Amount * 100).ToString());
            vnpay.AddRequestData(VnPayConstansts.CREATE_DATE, DateTime.UtcNow.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData(VnPayConstansts.CURR_CODE, _vnPaySettings.CurrencyCode);
            vnpay.AddRequestData(VnPayConstansts.IP_ADDRESS, Utils.GetIpAddress(context));
            vnpay.AddRequestData(VnPayConstansts.LOCALE, _vnPaySettings.Locale);
            vnpay.AddRequestData(VnPayConstansts.ORDER_INFOR, vnPayRequest.OrderInfo);
            vnpay.AddRequestData(VnPayConstansts.ORDER_TYPE, vnPayRequest.OrderType);
            vnpay.AddRequestData(VnPayConstansts.RETURN_URL, _vnPaySettings.ReturnUrl);
            vnpay.AddRequestData(VnPayConstansts.TXN_REF, tick);

            string paymentUrl = vnpay.CreateRequestUrl(_vnPaySettings.BaseUrl, _vnPaySettings.HashSecret);
            await Task.CompletedTask;

            return new ServiceActionResult() { Data = paymentUrl };
        }

        public async Task<ServiceActionResult> PaymentExecute(VnPayResponse response, bool isIPN = false)
        {
            var vnpay = new VnPayLibrary();

            Type type = response.GetType();

            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                vnpay.AddResponseData(property.Name, property.GetValue(response).ToString());
            }

            bool checkSignature = vnpay.ValidateSignature(response.vnp_SecureHash, _vnPaySettings.HashSecret);

            if (!checkSignature)
            {
                return new ServiceActionResult(false);
            }

            if (isIPN)
            {
                Double.TryParse(response.vnp_Amount, out double result);
                var applicationId = new Guid(response.vnp_OrderInfo ?? throw new Exception("Invalid application"));
                var application = await _unitOfWork.MenteeApplicationRepository.FindAsync(applicationId) ?? throw new Exception("Invalid application");

                if (application.Status == Core.Domains.Enums.ApplicationStatus.PAID)
                {
                    return new ServiceActionResult(false)
                    {
                        Detail = "Application is already paid"
                    };
                }

                var isPaySucceed = (response.vnp_ResponseCode?.Equals("00") ?? false)
                    && (response.vnp_TransactionStatus?.Equals("00") ?? false);

                if (isPaySucceed)
                {
                    application.Transaction = new Core.Domains.Entities.Transaction()
                    {
                        Id = new Guid(),
                        Total = result,
                        MenteeApplicationId = applicationId
                    };
                    application.Status = Core.Domains.Enums.ApplicationStatus.PAID;

                    application.StartDate = DateTime.Now;
                    application.EndDate = DateTime.Now.AddMonths(1);

                    await _unitOfWork.CommitAsync();
                    return new ServiceActionResult(true)
                    {
                        Data = response
                    };
                }
                else
                {
                    return new ServiceActionResult(false)
                    {
                        Detail = "Payment failed"
                    };
                }

            }
            return new ServiceActionResult(true)
            {
                Data = response
            };


        }
    }
}
