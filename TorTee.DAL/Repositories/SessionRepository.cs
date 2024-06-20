using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class SessionRepository : GenericRepository<Session>, ISessionRepository
    {
        public SessionRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
