using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
 
    public interface IMenteeApplicationAnswerService
    {
        Task<IList<MenteeApplicationAnswer>> GetAll();
        Task<MenteeApplicationAnswer> GetOne(Guid artistId);

        Task Update(MenteeApplicationAnswerUpdateRequestModel artist);
        Task Add(MenteeApplicationAnswerCreateRequestModel artist);
        Task Delete(Guid artist);

        IList<MenteeApplicationAnswer> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }
}
