﻿using System.Linq.Expressions;
using TorTee.DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using TorTee.Common.Helpers;
using TorTee.Common.Models;


namespace TorTee.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        public GenericRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public virtual DbSet<T> Entities => DbContext.Set<T>();

        public DbContext DbContext { get; }

        public void Add(T entity)
        {
            DbContext.Add(entity);
        }


        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await DbContext.AddAsync(entity, cancellationToken);
        }


        public void AddRange(IEnumerable<T> entities)
        {
            DbContext.AddRange(entities);
        }


        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            await DbContext.AddRangeAsync(entities, cancellationToken);
        }


        public T Get(Expression<Func<T, bool>> expression)
        {
            return Entities.FirstOrDefault(expression);
        }



        public PaginatedResult GetPaginatedResult(
            int pageSize,
            int pageIndex,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Entities;
            return PaginationHelper.BuildPaginatedResultFullOptions(query, pageSize, pageIndex, filter, orderBy, includeProperties);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }


        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return Entities.Where(expression).AsEnumerable();
        }


        public async Task<IList<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await Entities.ToListAsync(cancellationToken);
        }


        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression,
            CancellationToken cancellationToken = default)
        {
            return await Entities.Where(expression).ToListAsync(cancellationToken);
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await Entities.FirstOrDefaultAsync(expression, cancellationToken);
        }

        public async Task DeleteAsync(Guid id, bool saveChanges = true)
        {
            var entity = await Entities.FindAsync(id);
            await DeleteAsync(entity);

            if (saveChanges) await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity, bool saveChanges = true)
        {
            Entities.Remove(entity);
            if (saveChanges) await DbContext.SaveChangesAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities, bool saveChanges = true)
        {
            var enumerable = entities as T[] ?? entities.ToArray();
            if (enumerable.Any()) Entities.RemoveRange(enumerable);

            if (saveChanges) await DbContext.SaveChangesAsync();
        }

        public T Find(params object[] keyValues)
        {
            return Entities.Find(keyValues);
        }

        public virtual async Task<T?> FindAsync(params object[] keyValues)
        {
            return await Entities.FindAsync(keyValues);
        }

        public async Task<IQueryable<T>> FindAsyncAsQueryable(Expression<Func<T, bool>> predicate)
        {
            return await Task.FromResult(Entities.Where(predicate).AsQueryable());
        }
        public async Task<IQueryable<T>> GetAllAsyncAsQueryable()
        {
            return await Task.FromResult(Entities.AsQueryable());
        }
    }
}
