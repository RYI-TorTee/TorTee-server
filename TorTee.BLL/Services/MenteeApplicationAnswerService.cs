using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.Models.Requests.MenteeApplicationAnswer;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MenteeApplicationAnswerService : IMenteeApplicationAnswerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public MenteeApplicationAnswerService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(MenteeApplicationAnswerCreateRequestModel menteeApplicationAnswer)
        {
            try
            {
                // Map the request model to entity
                var answerEntity = _mapper.Map<MenteeApplicationAnswer>(menteeApplicationAnswer);

                var repos = _unitOfWork.MenteeApplicationAnswerRepository;
                await repos.AddAsync(answerEntity);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid menteeApplicationAnswerId)
        {
            try
            {
                var repos = _unitOfWork.MenteeApplicationAnswerRepository;
                var menteeApplicationAnswer = await repos.GetAsync(maa => maa.Id == menteeApplicationAnswerId);
                if (menteeApplicationAnswer == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(menteeApplicationAnswer);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<MenteeApplicationAnswer>> GetAll()
        {
            return await _unitOfWork.MenteeApplicationAnswerRepository.GetAllAsync();
        }

        public IList<MenteeApplicationAnswer> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<MenteeApplicationAnswer, bool>> filter = maa => maa.Id == id;
            Func<IQueryable<MenteeApplicationAnswer>, IOrderedQueryable<MenteeApplicationAnswer>> orderBy = null;
            IList<MenteeApplicationAnswer> result = (IList<MenteeApplicationAnswer>)_unitOfWork.MenteeApplicationAnswerRepository.GetDetail(filter, orderBy, "ApplicationQuestion", pageSize, pageIndex);
            return result;
        }

        public async Task<MenteeApplicationAnswer> GetOne(Guid menteeApplicationAnswerId)
        {
            return await _unitOfWork.MenteeApplicationAnswerRepository.FindAsync(menteeApplicationAnswerId);
        }

        public async Task Update(MenteeApplicationAnswerUpdateRequestModel menteeApplicationAnswer)
        {
            try
            {
                var repos = _unitOfWork.MenteeApplicationAnswerRepository;
                var existingMenteeApplicationAnswer = await repos.FindAsync(menteeApplicationAnswer.MenteeApplicationId);
                if (existingMenteeApplicationAnswer == null)
                    throw new KeyNotFoundException();
                
                
               
                //repos.Update(existingMenteeApplicationAnswer);
                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }
    }
}
