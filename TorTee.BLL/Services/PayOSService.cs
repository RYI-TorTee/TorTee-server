﻿using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Net.payOS;
using Net.payOS.Types;
using TorTee.API.SignalR;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Notifications;
using TorTee.BLL.Models.Requests.PayOs;
using TorTee.BLL.Models.Responses.Notifications;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Settings;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class PayOSService(PayOS _payOS,
        IOptions<PayOSSettings> payOsSettings,
        IUnitOfWork _unitOfWork,
        IMapper _mapper,
        IHubContext<NotificationHub> _hubContext, IUserClaimsService userClaimsService) : IPayOSService
    {
        private readonly PayOSSettings _payOsSettings = payOsSettings.Value;
        private readonly UserClaims _user = userClaimsService.GetUserClaims();
        public async Task<ServiceActionResult> CreatePaymentLink(PayOsRequest request)
        {
            //TODO: check if user is already in relationship with mentee
            var application = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Where(a => a.Id == request.OrderCode)
                .Include(a => a.MenteePlan)
                .ThenInclude(p => p.Mentor)
                .FirstOrDefault() ?? throw new ArgumentNullException("The application is currently invalid");

            var isInRelationship = (await _unitOfWork.MenteeApplicationRepository.GetAllAsyncAsQueryable())
                .Include(a => a.MenteePlan)
                .Any(a => a.UserId == _user.UserId && a.MenteePlan.MentorId == application.MenteePlan.MentorId && a.EndDate > DateTime.Now);

            if (isInRelationship)
                return new ServiceActionResult(false) { Detail = "You and this mentor currently in mentorship" };

            int orderCode = int.Parse(DateTimeOffset.Now.ToString("ffffff"));

            ItemData item = new ItemData("Mentee Application", 1, request.Amount);
            List<ItemData> items = new List<ItemData>();
            items.Add(item);
            PaymentData paymentData = new PaymentData(orderCode, request.Amount, request.Description, items, _payOsSettings.CancelUrl, _payOsSettings.ReturnUrl);

            CreatePaymentResult createPayment = await _payOS.createPaymentLink(paymentData);
            await _payOS.confirmWebhook(_payOsSettings.WebhookUrl);

            application.OrderCode = orderCode;
            await _unitOfWork.CommitAsync();

            return new ServiceActionResult { Data = createPayment };
        }

        public async Task<ServiceActionResult> Webhook(WebhookType webhookBody)
        {
            WebhookData webhookData = _payOS.verifyPaymentWebhookData(webhookBody);

            if (webhookData != null && webhookData.code == "00")
            {
                var application = await _unitOfWork.MenteeApplicationRepository.GetAsync(a => a.OrderCode == webhookData.orderCode) ?? throw new Exception("Invalid application");

                if (application.Status == Core.Domains.Enums.ApplicationStatus.PAID)
                {
                    return new ServiceActionResult(false)
                    {
                        Detail = "Application is already paid"
                    };
                }

                application.Transaction = new Core.Domains.Entities.Transaction()
                {
                    Id = new Guid(),
                    Total = webhookData.amount,
                    MenteeApplicationId = application.Id
                };
                application.Status = Core.Domains.Enums.ApplicationStatus.PAID;

                application.StartDate = DateTime.Now;
                application.EndDate = DateTime.Now.AddMonths(1);

                //Send notification to mentor
                var sender = await _unitOfWork.UserRepository.FindAsync(application.UserId);
                var menteePlan = await _unitOfWork.MentorPlanRepository.FindAsync(application.MenteePlanId);
                var receiver = await _unitOfWork.UserRepository.FindAsync(menteePlan.MentorId);
                var newNoti = new NotificationRequest()
                {
                    Content = $"Mentee {sender.FullName} has pay for application. Start work with {sender.FullName} ASAP.",
                    SenderId = application.UserId,
                    ReceiverId = receiver.Id,
                };
                var noti = _mapper.Map<Notification>(newNoti);
                await _unitOfWork.NotificationRepository.AddAsync(noti);
                await _unitOfWork.CommitAsync();

                var notiToReturn = _mapper.Map<NotificationResponse>(noti);
                notiToReturn.SenderAvatar = application.User.ProfilePic;

                if (NotificationHub.TryGetConnectionId(noti.ReceiverId.ToString(), out var connectionId))
                {
                    await _hubContext.Clients.Client(connectionId).SendAsync("ReceiveNotification", notiToReturn);
                }

                return new ServiceActionResult(true)
                {
                    Data = webhookData
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
    }
}
