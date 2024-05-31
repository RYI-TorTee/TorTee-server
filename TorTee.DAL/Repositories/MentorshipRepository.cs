using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{
   
    public class MentorshipRepository : GenericRepository<Mentorship>, IMentorshipRepository
    {
        public MentorshipRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
