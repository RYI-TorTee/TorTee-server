using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    
    public interface IMentorPlanService
    {
        Task<IList<MenteePlan>> GetAll();
        Task<MenteePlan> GetOne(Guid artistId);

        Task Update(MenteePlanUpdateRequestModel artist);
        Task Add(MenteePlanCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<MenteePlanRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex);

        MenteePlanRequestModel GetOneById(Guid id);

        MenteePlanRequestModel GetByMenteePlanId(Guid id);
        Task<ServiceActionResult> GetAllPaging(PagingRequest request, Guid id);
    }

}
