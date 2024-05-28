using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TorTee.BLL.RequestModel;
using TorTee.BLL.Services.IServices;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Dtos;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class MentorUserService : IMentorUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MentorUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Add(MentorDTO mentor)
        {
            try
            {
                // Map MentorDTO to User entity
                var user = _mapper.Map<User>(mentor);

                var repos = _unitOfWork.MentorUserRepository;
                await repos.AddAsync(user);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid MentorId)
        {
            try
            {

                var repos = _unitOfWork.MentorUserRepository;
                var Mentor = await repos.GetAsync(a => a.Id == MentorId);
                if (Mentor == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(Mentor);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<MentorDTO>> GetAll()
        {
            var users = await _unitOfWork.MentorUserRepository.GetAllAsync();
            var result = _mapper.Map<IList<MentorDTO>>(users);
            return result;
        }


        public MentorDTO GetDetailOne(Guid id)
        {

            Expression<Func<User, bool>> filter = user => user.Id == id;
            Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null;
            var x = _unitOfWork.MentorUserRepository.GetDetail(filter, orderBy, "UserSkills", null, null).FirstOrDefault();
            var result = _mapper.Map<MentorDTO>(x);
            return result;
        }

        public async Task<User> GetOne(Guid MentorId)
        {
            return await _unitOfWork.MentorUserRepository.FindAsync(MentorId);
        }


        public async Task Update(MentorProfileUpdateRequestModel Mentor)
        {
            try
            {
                
                var repos = _unitOfWork.MentorUserRepository;
                var a = await repos.FindAsync(Mentor.Id);
                if (a == null)
                    throw new KeyNotFoundException();
                 a.FullName = Mentor.FullName;
                a.BankAccount = Mentor.BankAccount;
                a.ProfilePic = Mentor.ProfilePic;
                //a.Name = a.Name;

                await _unitOfWork.CommitAsync();
            }
            catch (Exception e)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        Task<MentorDTO> IMentorUserService.GetOne(Guid MentorId)
        {
            throw new NotImplementedException();
        }
    }
}
