using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class ApplicationQuestionRepository : GenericRepository<ApplicationQuestion>, IApplicationQuestionRepository
    {
        public ApplicationQuestionRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
