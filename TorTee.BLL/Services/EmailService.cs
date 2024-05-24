using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Mvc.Routing;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace TorTee.BLL.Services
{
    public class EmailService : IEmailService
    {
        private readonly IUrlHelperFactory _urlHelperFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public EmailService(IConfiguration configuration)
        {

            _configuration = configuration;
            _httpContextAccessor = new HttpContextAccessor();
            _urlHelperFactory = new UrlHelperFactory();

        }

        public Task SendEmailAsync(string ToEmail, string Subject, string Body, bool IsBodyHtml = false)
        {
            var MailServer = _configuration["EmailSettings:MailServer"];
            var FromEmail = _configuration["EmailSettings:FromEmail"];
            var Password = _configuration["EmailSettings:Password"];
            var Port = int.Parse(_configuration["EmailSettings:MailPort"]);
            var client = new SmtpClient(MailServer, Port)
            {
                Credentials = new NetworkCredential(FromEmail, Password),
                EnableSsl = true
            };
            var mailMessage = new MailMessage(FromEmail, ToEmail, Subject, Body)
            {
                IsBodyHtml = IsBodyHtml
            };
            return client.SendMailAsync(mailMessage);
        }

        public async Task SendEmailConfirmationAsync(User user, string token = "")
        {
            var urlHelper = _urlHelperFactory.GetUrlHelper(new ActionContext(_httpContextAccessor.HttpContext, new RouteData(), new ActionDescriptor()));
            var confirmationLink = urlHelper.Action("ConfirmEmail", "Auth", new { userId = user.Id, token }, _httpContextAccessor.HttpContext.Request.Scheme);
            await SendEmailAsync(user.Email, "Confirm your email", $"Please confirm your email by clicking <a href='{confirmationLink}'>here</a>", true);
        }
    }
}
