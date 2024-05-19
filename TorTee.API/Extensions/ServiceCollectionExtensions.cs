﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerGen;
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
            })
              .AddRoles<Role>()
              .AddRoleManager<RoleManager<Role>>()
              .AddSignInManager<SignInManager<User>>()
              .AddRoleValidator<RoleValidator<Role>>()
              .AddEntityFrameworkStores<TorTeeDbContext>();

            var jwtSettings = configuration.GetSection(nameof(JwtSettings)).Get<JwtSettings>() ?? throw new MissingJwtSettingsException();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
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
                        var accessToken = context.Request.Query["access_token"];

                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            path.StartsWithSegments("/hubs"))
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

        public static IServiceCollection AddGgAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            var googleSettings = configuration.GetSection(nameof(GoogleSettings)).Get<GoogleSettings>() ?? throw new MissingGoogleSettingsException();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = GoogleDefaults.AuthenticationScheme;
            }).AddCookie()
                .AddGoogle(GoogleDefaults.AuthenticationScheme, options =>
                {
                    options.ClientId = googleSettings.ClientId;
                    options.ClientSecret = googleSettings.ClientSecret;
                });
            return services;
        }

        //public static IServiceCollection AddDefaultCorsPolicy(this IServiceCollection services, IConfiguration configuration)
        //{
        //    var corsSettings = configuration.GetSection(nameof(CorsSettings)).Get<CorsSettings>() ??
        //                       throw new MissingCorsSettingsException();
        //    services.AddCors(options =>
        //    {
        //        options.AddPolicy(CorsConstants.APP_CORS_POLICY, builder =>
        //        {
        //            builder.WithOrigins(corsSettings.GetAllowedOriginsArray())
        //                .WithHeaders(corsSettings.GetAllowedHeadersArray())
        //                .WithMethods(corsSettings.GetAllowedMethodsArray());
        //            if (corsSettings.AllowCredentials)
        //            {
        //                builder.AllowCredentials();
        //            }

        //            builder.Build();
        //        });
        //    });

        //    return services;
        //}


    }
}