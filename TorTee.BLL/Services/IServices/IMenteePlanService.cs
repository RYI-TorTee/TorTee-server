using TorTee.BLL.Models;

namespace TorTee.BLL.Services.IServices
{
    public interface IMenteePlanService
    {
        Task<ServiceActionResult> GetPlan(Guid mentorId, Guid? userId = null);
    }
}
