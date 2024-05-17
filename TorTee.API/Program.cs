using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;
using TorTee.DAL.DataContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddIdentity<User, Role>()
                      .AddRoleManager<RoleManager<Role>>()
            .AddEntityFrameworkStores<TorTeeDbContext>()
            .AddDefaultTokenProviders();

builder.Services.RegisterDALDependencies(builder.Configuration);


builder.Services.RegisterBLLDependencies(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
EnsureMigrate(app);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void EnsureMigrate(WebApplication webApp)
{
    using var scope = webApp.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<TorTeeDbContext>();
    context.Database.Migrate();
}

