using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL
{
    public interface IUnitOfWork
    {
        public IMessageRepository MessageRepository { get; }

        public IUserRepository MentorUserRepository { get; }
        public IBookingCallRepository BookingCallRepository { get; }

        public IUserSkillRepository UserSkillRepository { get; }

        public IMentorPlanRepository MentorPlanRepository { get; }

        public ISessionRepository SessionRepository { get; }

        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}
