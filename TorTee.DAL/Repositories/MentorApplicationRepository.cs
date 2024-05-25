using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{
    public class MentorApplicationRepository : GenericRepository<MentorApplication>, IMentorApplicationRepository
    {
        public MentorApplicationRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
