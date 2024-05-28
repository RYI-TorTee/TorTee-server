using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class ApplicationQuestionService : IApplicationQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApplicationQuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(ApplicationQuestion applicationQuestion)
        {
            try
            {
                var repos = _unitOfWork.ApplicationQuestionRepository;
                await repos.AddAsync(applicationQuestion);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid applicationQuestionId)
        {
            try
            {
                var repos = _unitOfWork.ApplicationQuestionRepository;
                var applicationQuestion = await repos.GetAsync(aq => aq.Id == applicationQuestionId);
                if (applicationQuestion == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(applicationQuestion);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<ApplicationQuestion>> GetAll()
        {
            return await _unitOfWork.ApplicationQuestionRepository.GetAllAsync();
        }

        public IList<ApplicationQuestion> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<ApplicationQuestion, bool>> filter = aq => aq.Id == id;
            Func<IQueryable<ApplicationQuestion>, IOrderedQueryable<ApplicationQuestion>> orderBy = null;
            IList<ApplicationQuestion> result = (IList<ApplicationQuestion>)_unitOfWork.ApplicationQuestionRepository.GetDetail(filter, orderBy, "Answers", pageSize, pageIndex);
            return result;
        }

        public async Task<ApplicationQuestion> GetOne(Guid applicationQuestionId)
        {
            return await _unitOfWork.ApplicationQuestionRepository.FindAsync(applicationQuestionId);
        }

        public async Task Update(ApplicationQuestion applicationQuestion)
        {
            try
            {
                var repos = _unitOfWork.ApplicationQuestionRepository;
                var existingApplicationQuestion = await repos.FindAsync(applicationQuestion.Id);
                if (existingApplicationQuestion == null)
                    throw new KeyNotFoundException();

        

               
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
