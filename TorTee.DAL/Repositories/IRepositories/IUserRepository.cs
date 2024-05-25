﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;


namespace TorTee.DAL.Repositories.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {

        Task<IQueryable<User>> GetAllMentorAsync();
    }
}
