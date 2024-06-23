using Microsoft.Extensions.DependencyInjection;
using TorTee.BLL.Utilities.AutoMapperProfiles;
using TorTee.BLL.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using TorTee.BLL.Services.IServices;
using TorTee.BLL.Services;


namespace TorTee.BLL
{
    public static class DependencyInjection
    {
        public static void RegisterBLLDependencies(this IServiceCollection services, IConfiguration Configuration)
        {;
            services.AddAutoMapper(typeof(AutoMapperProfiles));
  
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICookieService, CookieService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IMentorApplicationService, MentorApplicationService>();
            services.AddScoped<IMentorService, MentorService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserClaimsService, UserClaimsService>();
            services.AddScoped<IApplicationQuestionService, ApplicationQuestionService>();
            services.AddScoped<IMenteePlanService, MenteePlanService>();
            services.AddScoped<IMenteeApplicationService, MenteeApplicationService>();
            services.AddScoped<IWorkspaceService, WorkspaceService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<IFeedbackService, FeedbackService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IVnPayService, VnPayService>();

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<UserToLoginDTOValidator>();

           
        }
    }
}
