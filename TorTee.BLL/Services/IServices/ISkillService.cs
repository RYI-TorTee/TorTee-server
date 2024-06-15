using TorTee.BLL.Models;

namespace TorTee.BLL.Services.IServices
{
    public interface ISkillService
    {
        Task<ServiceActionResult> GetSkillAsync(string search);
    }
}
