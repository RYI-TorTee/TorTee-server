using Microsoft.EntityFrameworkCore;
using TorTee.BLL;
using TorTee.DAL;
using TorTee.DAL.DataContext;
using TorTee.API.Extensions;
using TorTee.API.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddIdentityServices(builder.Configuration);
//builder.Services.AddGgAuthentication(builder.Configuration);
//builder.Services.AddCookieConfiguration();
builder.Services.AddLogging();
builder.Services.AddSignalR();
builder.Services.RegisterDALDependencies(builder.Configuration);
builder.Services.RegisterBLLDependencies(builder.Configuration);
builder.Services.AddCorsPolicy(builder.Configuration);
builder.Services.AddVNPaySettings(builder.Configuration);
 builder.Services.AddPayOSSettings(builder.Configuration);
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

app.UseCors("AllowReactApp");

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<MessageHub>("/chathub");
app.MapHub<NotificationHub>("/notificationhub");

app.Run();

void EnsureMigrate(WebApplication webApp)
{
    using var scope = webApp.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<TorTeeDbContext>();
    context.Database.Migrate();
}

