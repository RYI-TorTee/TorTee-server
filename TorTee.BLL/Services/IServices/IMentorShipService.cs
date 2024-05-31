using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.Mentorship;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
  
    public interface IMentorShipService
    {
        Task<IList<Mentorship>> GetAll();
        Task<Mentorship> GetOne(Guid artistId);

        Task Update(MentorshipUpdateRequestModel artist);
        Task Add(MentorshipCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<MentorshipRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex);

        MentorshipRequestModel GetOneById(Guid id);
    }
}
