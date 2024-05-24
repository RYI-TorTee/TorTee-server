using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    public interface IEmailService 
    {
        Task SendEmailConfirmationAsync(User user, string token);
        Task SendEmailAsync(string ToEmail, string Subject, string Body, bool IsBodyHtml = false);
    }
}
