using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class AssignmentRepository : GenericRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
