using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorUserService
    {
        Task<IList<User>> GetAll();
        Task<User> GetOne(Guid artistId);

        Task Update(MentorProfileUpdateRequestModel artist);
        Task Add(User artist);
        Task Delete(Guid artist);

        User GetDetailOne(Guid id );
    }
}
