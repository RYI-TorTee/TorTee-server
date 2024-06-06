using TorTee.Core.Domains.Entities;

namespace TorTee.DAL.Repositories.IRepositories
{

    public interface IMentorshipRepository : IGenericRepository<Mentorship>
    {
        Task<IQueryable<Mentorship>> GetAvailableMentorshipByMenteeId(Guid menteeId);
        Task<IQueryable<Mentorship>> GetMentorshipByMenteeId(Guid menteeId);
        Task<IQueryable<Mentorship>> GetMentorshipByMentorId(Guid mentorId);
        Task<IQueryable<Mentorship>> GetAvailableMentorshipByMentorId(Guid mentorId);
    }
}
