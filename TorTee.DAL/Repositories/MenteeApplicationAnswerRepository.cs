using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class MenteeApplicationAnswerRepository : GenericRepository<MenteeApplicationAnswer>, IMenteeApplicationAnswerRepository
    {
        public MenteeApplicationAnswerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
