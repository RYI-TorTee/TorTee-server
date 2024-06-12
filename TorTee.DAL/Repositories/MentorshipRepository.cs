using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class MentorshipRepository : GenericRepository<Mentorship>, IMentorshipRepository
    {
        public MentorshipRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IQueryable<Mentorship>> GetAvailableMentorshipByMenteeId(Guid menteeId)
        {
            var mentorshipQueryable = (await GetAllAsyncAsQueryable()).Where(m=>m.MenteeId == menteeId)
                .Where(m=>m.EndDate < DateTime.Now);
            return mentorshipQueryable;
        }

        public async Task<IQueryable<Mentorship>> GetAvailableMentorshipByMentorId(Guid mentorId)
        {
            var mentorshipQueryable = (await GetAllAsyncAsQueryable()).Where(m => m.MentorId == mentorId)
                .Where(m => m.EndDate < DateTime.Now);
            return mentorshipQueryable;
        }

        public async Task<IQueryable<Mentorship>> GetMentorshipByMenteeId(Guid menteeId)
        {
            var mentorshipQueryable = (await GetAllAsyncAsQueryable()).Where(m => m.MenteeId == menteeId);
            return mentorshipQueryable;
        }

        public async Task<IQueryable<Mentorship>> GetMentorshipByMentorId(Guid mentorId)
        {
            var mentorshipQueryable = (await GetAllAsyncAsQueryable()).Where(m => m.MentorId == mentorId);
            return mentorshipQueryable;
        }
    }
}
