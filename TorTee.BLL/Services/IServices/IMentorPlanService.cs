using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    
    public interface IMentorPlanService
    {
        Task<IList<MenteePlan>> GetAll();
        Task<MenteePlan> GetOne(Guid artistId);

        Task Update(MenteePlan artist);
        Task Add(MenteePlan artist);
        Task Delete(Guid artist);

        IList<MenteePlan> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }

}
