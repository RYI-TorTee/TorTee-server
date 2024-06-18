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
using TorTee.BLL.Helpers;

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

        public async Task SendEmailAsync(string ToEmail, string Subject, string Body, bool IsBodyHtml = false)
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
           
            var mailMessage = new MailMessage(FromEmail, ToEmail, Subject, EmailHelper.CreateEmailBody(Body, Subject))
            {
                IsBodyHtml = IsBodyHtml
            };
            await client.SendMailAsync(mailMessage);
        }

        public async Task SendEmailConfirmationAsync(User user, string token = "")
        {
            //var urlHelper = _urlHelperFactory.GetUrlHelper(new ActionContext(_httpContextAccessor.HttpContext, new RouteData(), new ActionDescriptor()));
            //var confirmationLink = urlHelper.Action("ConfirmEmail", "Auth", new { userId = user.Id, token }, _httpContextAccessor.HttpContext.Request.Scheme);
            //will improve this later
            var encodedToken = WebUtility.UrlEncode(token);
            await SendEmailAsync(user.Email, "Confirm Your Account Registration", EmailHelper.GetConfirmEmailBody($"https://torteevn.azurewebsites.net/mentee-signup-success?userId={user.Id}&token={encodedToken}", user.FullName, "totementoring@gmail.com"), true);
        }

        
    }
}
