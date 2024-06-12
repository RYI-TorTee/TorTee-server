using AutoMapper;
using AutoMapper.QueryableExtensions;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Responses.ApplicationQuestions;
using TorTee.BLL.Services.IServices;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class ApplicationQuestionService : IApplicationQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ApplicationQuestionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> GetAllQuestions()
        {
            var questions = (await _unitOfWork.ApplicationQuestionRepository.GetAllAsyncAsQueryable())
                .ProjectTo<ApplicationQuestionResponse>(_mapper.ConfigurationProvider).ToList();

            return new ServiceActionResult(true) { Data = questions };
        }
    }
}
