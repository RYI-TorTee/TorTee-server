using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Assignment;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
  
    public interface IAssignmentService
    {
        Task<IList<Assignment>> GetAll();
        Task<Assignment> GetOne(Guid artistId);

        Task Update(AssignmentUpdateRequestModel artist);
        Task Add(AssignmentCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<AssignmentRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex);

        AssignmentRequestModel GetOneById(Guid id);
    }
}
