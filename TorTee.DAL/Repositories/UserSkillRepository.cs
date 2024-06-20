using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class UserSkillRepository : GenericRepository<UserSkill>, IUserSkillRepository
    {
        public UserSkillRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
