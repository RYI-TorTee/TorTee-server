using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Skills;
using TorTee.BLL.Models.Responses.Skills;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ServiceActionResult> GetSkillAsync(string search, Guid userId)
        {
            var userSkills = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                            .Where(u => u.Id == userId)
                            .SelectMany(u => u.UserSkills)
                            .Select(us => us.SkillId) ?? throw new ArgumentNullException("User not found");

            // Fetch all skills and exclude the ones the user already has
            var skillsQuery = (await _unitOfWork.SkillRepository.GetAllAsyncAsQueryable())
                .Where(s => !userSkills.Contains(s.Id));
            
            if (!string.IsNullOrEmpty(search))
            {
                skillsQuery = skillsQuery.Where(s => s.SkillName.ToLower().Contains(search.ToLower()));
            }

            var skills = skillsQuery.Take(8);

            return new ServiceActionResult(true) { Data = skills.ProjectTo<SkillReponse>(_mapper.ConfigurationProvider)};
        }

        public async Task<ServiceActionResult> UpdateSkillsOfAUser(UserSkillsRequest request, Guid userId)
        {
            var user = (await _unitOfWork.UserRepository.GetAllAsyncAsQueryable())
                .Include(u=>u.UserSkills).FirstOrDefault() ?? throw new ArgumentNullException("User not found");

            var userSkills = user.UserSkills.Select(us=>us.SkillId);

            foreach (var skill in request.Skills)
            {
                var skilkExist = await _unitOfWork.SkillRepository.FindAsync(skill.Id);
                if (skilkExist == null)
                {
                    return new ServiceActionResult(false, $"Skill with id {skill.Id} not found");
                }
                if (!userSkills.Contains(skill.Id))
                {
                    user.UserSkills.Add(new UserSkill { SkillId = skill.Id, UserId = userId });
                }
            }

            await _unitOfWork.CommitAsync();
            return new ServiceActionResult(true);
        }
    }
}
