using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{

    public interface IApplicationQuestionService
    {
        Task<IList<ApplicationQuestion>> GetAll();
        Task<ApplicationQuestion> GetOne(Guid artistId);

        Task Update(ApplicationQuestion artist);
        Task Add(ApplicationQuestion artist);
        Task Delete(Guid artist);

        IList<ApplicationQuestion> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }
}
