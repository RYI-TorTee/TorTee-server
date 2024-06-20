using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class MentorPlanRepository : GenericRepository<MenteePlan>, IMentorPlanRepository
    {
        public MentorPlanRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
