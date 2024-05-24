﻿using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IQueryable<User>> GetAllMentorAsync()
        {           
            var mentorQuery = (await GetAllAsyncAsQueryable())
                .Include(user => user.UserRoles)
                .ThenInclude(ur => ur.Role)
                .Where(user => user.UserRoles.Any(ur => ur.Role.Name.Equals(UserRoleConstants.MENTOR, StringComparison.OrdinalIgnoreCase)));
            return mentorQuery;
        }
    }
}