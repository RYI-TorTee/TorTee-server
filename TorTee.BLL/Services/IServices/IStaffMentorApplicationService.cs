using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.MenteePlan;
using TorTee.BLL.Models.Requests.MentorApplications;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
    
    public interface IStaffMentorApplicationService
    {
        Task<IList<MentorApplication>> GetAll();
        Task<MentorApplication> GetOne(Guid artistId);

        Task Update(MentorApplicationUpdateRequestModel artist);
        Task Delete(Guid artist);

        IList<MentorApplicationRequestModel> GetDetailOne( int pageSize, int pageIndex);

        MentorApplicationRequestModel GetOneById(Guid id);

        Task<ServiceActionResult> GetAllPaging(PagingRequest request);
    }
}
