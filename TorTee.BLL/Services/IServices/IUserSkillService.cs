using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;

namespace TorTee.BLL.Services.IServices
{
   
    public interface IUserSkillService
    {
        Task<IList<UserSkill>> GetAll();
        Task<UserSkill> GetOne(Guid artistId);

        Task Update(UserSkill artist);
        Task Add(UserSkill artist);
        Task Delete(UserSkill artist);

        IList<UserSkill> GetDetailOne(Guid id, int pageSize, int pageIndex);
    }
}
