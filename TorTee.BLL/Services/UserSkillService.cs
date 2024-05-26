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
    public class UserSkillService : IUserSkillService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserSkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(UserSkill userSkill)
        {
            try
            {
                var repos = _unitOfWork.UserSkillRepository;
                await repos.AddAsync(userSkill);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid userSkillId)
        {
            try
            {
                var repos = _unitOfWork.UserSkillRepository;
                var userSkill = await repos.GetAsync(us => us.Id == userSkillId);
                if (userSkill == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(userSkill);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public Task Delete(UserSkill artist)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<UserSkill>> GetAll()
        {
            return await _unitOfWork.UserSkillRepository.GetAllAsync();
        }

        public IList<UserSkill> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {
            Expression<Func<UserSkill, bool>> filter = userSkill => userSkill.UserId == id;
            Func<IQueryable<UserSkill>, IOrderedQueryable<UserSkill>> orderBy = null;
            IList<UserSkill> result = (IList<UserSkill>)_unitOfWork.UserSkillRepository.GetDetail(filter, orderBy, "Skill",  pageSize,  pageIndex);
            return result;
        }

        public UserSkill GetDetailOne(UserSkill id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserSkill> GetOne(Guid userSkillId)
        {
            return await _unitOfWork.UserSkillRepository.FindAsync(userSkillId);
        }

        public async Task Update(UserSkill userSkill)
        {
            try
            {
                var repos = _unitOfWork.UserSkillRepository;
                var existingUserSkill = await repos.FindAsync(userSkill.Id);
                if (existingUserSkill == null)
                    throw new KeyNotFoundException();

                // Update properties of existingUserSkill based on userSkillUpdateRequestModel

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
