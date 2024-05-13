using System.Linq.Expressions;
using TorTee.DAL.DataContext;
using TorTee.DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;


namespace TorTee.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly TorTeeDbContext _torTeeDbContext;
        public GenericRepository(TorTeeDbContext TorTeeDbContext)
        {
            _torTeeDbContext = TorTeeDbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _torTeeDbContext.AddAsync(entity);
            await _torTeeDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> AddRangeAsync(List<TEntity> entity)
        {
            await _torTeeDbContext.AddRangeAsync(entity);
            await _torTeeDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            _ = _torTeeDbContext.Remove(entity);
            return await _torTeeDbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null, CancellationToken cancellationToken = default)
        {
            return await _torTeeDbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter, cancellationToken);
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, CancellationToken cancellationToken = default)
        {
            return await (filter == null ? _torTeeDbContext.Set<TEntity>().ToListAsync(cancellationToken) : _torTeeDbContext.Set<TEntity>().Where(filter).ToListAsync(cancellationToken));
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _ = _torTeeDbContext.Update(entity);
            await _torTeeDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entity)
        {
            _torTeeDbContext.UpdateRange(entity);
            await _torTeeDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
