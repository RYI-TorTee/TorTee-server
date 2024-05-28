using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;

namespace TorTee.BLL.Services.IServices
{
    public interface IMentorUserService
    {
        Task<IList<MentorDTO>> GetAll();
        Task<MentorDTO> GetOne(Guid artistId);

        Task Update(MentorProfileUpdateRequestModel artist);
        Task Add(MentorDTO artist);
        Task Delete(Guid artist);

        MentorDTO GetDetailOne(Guid id );
    }
}
