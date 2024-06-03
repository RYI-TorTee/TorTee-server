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
  
            services.AddScoped<IMentorUserService,MentorUserService>();
            services.AddScoped<IUserSkillService , UserSkillService>();
            services.AddScoped<IMentorPlanService, MentorPlanService>();
            services.AddScoped<IBookingPlanService, BookingPlanService>();
            services.AddScoped<IMenteeApplicationAnswerService, MenteeApplicationAnswerService>();
            services.AddScoped<IMenteeApplicationService, MenteeApplicationService>();
            services.AddScoped<IApplicationQuestionService, ApplicationQuestionService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICookieService, CookieService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IMentorApplicationService, MentorApplicationService>();
            services.AddScoped<IMentorService, MentorService>();
            services.AddScoped<IMessageService, MessageService>();
            services.AddScoped<INotificationService, NotificationService>();
            services.AddScoped<IFileStorageService, FileStorageService>();
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IAssignmentSubmissionService, AssignmentSubmissionService>();
            services.AddScoped<IMentorShipService, MentorShipService>();
            services.AddScoped<IStaffMentorApplicationService, StaffMentorApplicationService>();

            services.AddScoped<IVnPayService, VnPayService>();
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<UserToLoginDTOValidator>();

           
        }
    }
}
