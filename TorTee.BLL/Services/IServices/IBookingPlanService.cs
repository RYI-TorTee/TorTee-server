using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{

    public interface IBookingPlanService
    {
        Task<IList<BookingCall>> GetAll();
        Task<BookingCall> GetOne(Guid artistId);

        Task Update(BookingCall artist);
        Task Add(BookingCall artist);
        Task Delete(Guid artist);

        IList<Session> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }
}
