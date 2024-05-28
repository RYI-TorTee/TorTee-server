﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class MenteeApplicationAnswerRepository : GenericRepository<MenteeApplicationAnswer>, IMenteeApplicationAnswerRepository
    {
        public MenteeApplicationAnswerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
