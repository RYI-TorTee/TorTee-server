using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Skills;

namespace TorTee.BLL.Services.IServices
{
    public interface ISkillService
    {
        Task<ServiceActionResult> GetSkillAsync(string search, Guid userId);
        Task<ServiceActionResult> UpdateSkillsOfAUser(UserSkillsRequest request, Guid userId);
    }
}
