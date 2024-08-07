﻿using Microsoft.EntityFrameworkCore;
using TorTee.Core.Domains.Entities;
using TorTee.DAL.Repositories.IRepositories;

namespace TorTee.DAL.Repositories
{

    public class BookingCallRepository : GenericRepository<BookingCall>, IBookingCallRepository
    {
        public BookingCallRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
