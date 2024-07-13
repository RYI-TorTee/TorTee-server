﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Net.payOS;
using System.Text;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Exceptions;
using TorTee.Core.Settings;
using TorTee.DAL.DataContext;

namespace TorTee.API.Extensions
{
    public static class ServiceCollectionExtensions
    { 
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.User.RequireUniqueEmail = true;
                opt.SignIn.RequireConfirmedEmail = true;     
            })
              .AddRoles<Role>()
              .AddRoleManager<RoleManager<Role>>()
              .AddSignInManager<SignInManager<User>>()
              .AddRoleValidator<RoleValidator<Role>>()
              .AddEntityFrameworkStores<TorTeeDbContext>()
              .AddDefaultTokenProviders(); 

            var jwtSettings = configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>() ?? throw new MissingJwtSettingsException();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                    options.Cookie.SameSite = SameSiteMode.Strict;
                    options.Cookie.Name = "token";
                    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                    options.SlidingExpiration = true;
                })
                .AddJwtBearer(options =>
                {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    //ValidIssuer = jwtSettings.Issuer,
                    ValidateIssuer = jwtSettings.ValidateIssuer,
                    //ValidAudience = jwtSettings.Audience,
                    ValidateAudience = jwtSettings.ValidateAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SigningKey)),
                    ValidateIssuerSigningKey = jwtSettings.ValidateIssuerSigningKey,
                    //ValidateLifetime = jwtSettings.ValidateLifetime,
                    //ClockSkew = TimeSpan.Zero
                };

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Cookies["token"] ?? context.Request.Query["access_token"];

                        if (!string.IsNullOrEmpty(accessToken))
                        {
                            context.Token = accessToken;
                        }

                        return Task.CompletedTask;
                    }
                };
            });

            services.AddAuthorization(opt =>
            {
                opt.AddPolicy("RequireAdminRole", policy => policy.RequireRole("Admin"));
                opt.AddPolicy("ModeratePhotoRole", policy => policy.RequireRole("Admin", "Moderator"));
            });

            return services;
        }

     

        public static IServiceCollection AddCookieConfiguration(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);
                options.LoginPath = "/auth/login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/auth/logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/auth/accessdenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = true;
            });
            return services;
        }      

        public static IServiceCollection AddCorsPolicy(this IServiceCollection services, IConfiguration configuration)
        {
            var corsSettings = configuration.GetSection(nameof(CorsSettings)).Get<CorsSettings>() ??
                               throw new NullReferenceException("Missing cors settings");
            services.AddCors(options =>
            {
                options.AddPolicy(corsSettings.PolicyName, builder =>
                {
                    builder.WithOrigins(corsSettings.WithOrigins)
                        .WithHeaders(corsSettings.WithHeaders)
                        .WithMethods(corsSettings.WithMethods);
                    if (corsSettings.AllowCredentials)
                    {
                        builder.AllowCredentials();
                    }
                });
            });

            return services;
        }

        public static IServiceCollection AddVNPaySettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<VNPaySettings>(configuration.GetSection(nameof(VNPaySettings)));
            return services;
        }
        public static IServiceCollection AddPayOSSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var payOSSettings = configuration.GetSection(nameof(PayOSSettings)).Get<PayOSSettings>() ?? throw new NullReferenceException("Missing payOS settings");
            services.Configure<PayOSSettings>(configuration.GetSection(nameof(PayOSSettings)));
            PayOS payOS = new PayOS(payOSSettings.ClientId, payOSSettings.ApiKey, payOSSettings.ChecksumKey);           
            
            services.AddSingleton(payOS);
            return services;
        }

    }
}
