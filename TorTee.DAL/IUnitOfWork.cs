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

        public IMentorApplicationRepository MentorApplicationRepository { get; }
        public IUserRepository UserRepository { get; }

        public IApplicationQuestionRepository ApplicationQuestionRepository { get; }

        public IMenteeApplicationAnswerRepository MenteeApplicationAnswerRepository { get; }
        public IMenteeApplicationRepository MenteeApplicationRepository { get; }

        public IAssignmentRepository AssignmentRepository { get; }
        public IAssignmentSubmissionRepository AssignmentSubmissionRepository { get; }
        void Commit();
        Task CommitAsync();
        void Rollback();
        Task RollbackAsync();
    }
}
