using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class MenteeApplicationRepository : GenericRepository<MenteeApplication>, IMenteeApplicationRepository
    {
        public MenteeApplicationRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
