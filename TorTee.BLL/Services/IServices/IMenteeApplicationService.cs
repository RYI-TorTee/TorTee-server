using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.MenteeApplication;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
  
    public interface IMenteeApplicationService
    {
        Task<IList<MenteeApplication>> GetAll();
        Task<MenteeApplication> GetOne(Guid artistId);

        Task Update(MenteeApplication artist);
        Task Add(MenteeApplicationCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<MenteeApplication> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }
}
