using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.AssignmentSubmission;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
 
    public interface IAssignmentSubmissionService
    {
        Task<IList<AssignmentSubmission>> GetAll();
        Task<AssignmentSubmission> GetOne(Guid artistId);

        Task Update(AssignmentSubmissionUpdateRequestModel artist);
        Task Add(AssignmentSubmissionCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<AssignmentSubmissionRequestModel> GetDetailOne(Guid id, int pageSize, int pageIndex);

        AssignmentSubmissionRequestModel GetOneById(Guid id);
    }
}
