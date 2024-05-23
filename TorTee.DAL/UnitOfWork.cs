using Microsoft.EntityFrameworkCore;
using TorTee.DAL.Repositories;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public DbContext _dbContext { get; }

        public IMessageRepository MessageRepository => new MessageRepository(_dbContext);

        public IUserRepository MentorUserRepository => new UserRepository(_dbContext);

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            try
            {
                GC.SuppressFinalize(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Rollback()
        {
            Console.WriteLine("Transaction rollback");
        }

        public async Task RollbackAsync()
        {
            Console.WriteLine("Transaction rollback");
            await Task.CompletedTask;
        }
    }
}
