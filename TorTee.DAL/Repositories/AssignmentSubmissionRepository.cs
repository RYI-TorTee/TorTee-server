using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class AssignmentSubmissionRepository : GenericRepository<AssignmentSubmission>, IAssignmentSubmissionRepository
    {
        public AssignmentSubmissionRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
