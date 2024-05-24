using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL
{
    public interface IUnitOfWork
    {
        public IMessageRepository MessageRepository { get; }
        public IMentorApplicationRepository MentorApplicationRepository { get; }
        public IUserRepository UserRepository { get; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}
