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
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles));
            /* services.AddScoped<IUserService, UserService>();
             services.AddScoped<IAuthService, AuthService>();*/
            services.AddScoped<IMentorUserService,MentorUserService>();
            services.AddScoped<IUserSkillService , UserSkillService>();
            services.AddScoped<IMentorPlanService, MentorPlanService>();
            services.AddScoped<IBookingPlanService, BookingPlanService>();
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<UserToLoginDTOValidator>();

           
        }
    }
}
