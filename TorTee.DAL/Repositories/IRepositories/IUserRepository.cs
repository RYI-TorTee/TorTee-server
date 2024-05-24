using TorTee.Core.Domains.Entities;

namespace TorTee.DAL.Repositories.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<IQueryable<User>> GetAllMentorAsync();
    }
}
