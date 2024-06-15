using AutoMapper;
using AutoMapper.QueryableExtensions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Responses.Skills;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class SkillService : ISkillService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> GetSkillAsync(string search = "")
        {
            var skills = string.IsNullOrEmpty(search) 
                ? (await _unitOfWork.SkillRepository.GetAllAsyncAsQueryable()).Take(8) 
                : (await _unitOfWork.SkillRepository.GetAllAsyncAsQueryable())
                .Where(s => s.SkillName.ToLower().Contains(search.ToLower()));

            return new ServiceActionResult(true) { Data = skills.ProjectTo<SkillReponse>(_mapper.ConfigurationProvider) };
        }
    }
}
