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
    public class BookingPlanService : IBookingPlanService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingPlanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(BookingCall bookingPlan)
        {
            try
            {
                var repos = _unitOfWork.BookingCallRepository;
                await repos.AddAsync(bookingPlan);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task Delete(Guid bookingPlanId)
        {
            try
            {
                var repos = _unitOfWork.BookingCallRepository;
                var bookingPlan = await repos.GetAsync(bp => bp.Id == bookingPlanId);
                if (bookingPlan == null)
                    throw new KeyNotFoundException();

                await repos.DeleteAsync(bookingPlan);

                await _unitOfWork.CommitAsync();
            }
            catch (Exception)
            {
                await _unitOfWork.RollbackAsync();
                throw;
            }
        }

        public async Task<IList<BookingCall>> GetAll()
        {
            return await _unitOfWork.BookingCallRepository.GetAllAsync();
        }

        public IList<Session> GetDetailOne(Guid id, int pageSize, int pageIndex)
        {

            Expression<Func<Session, bool>> filter = bookingPlan => bookingPlan.MentorId == id;
           
            var result = _unitOfWork.SessionRepository.GetDetail(filter, null, "BookingCalls", pageSize, pageIndex);
            return (IList<Session>)result;
        }

        public async Task<BookingCall> GetOne(Guid bookingPlanId)
        {
            return await _unitOfWork.BookingCallRepository.FindAsync(bookingPlanId);
        }

        public async Task Update(BookingCall bookingPlan)
        {
            try
            {
                var repos = _unitOfWork.BookingCallRepository;
                var existingBookingPlan = await repos.FindAsync(bookingPlan.Id);
                if (existingBookingPlan == null)
                    throw new KeyNotFoundException();

               // existingBookingPlan.Name = bookingPlan.Name;
               // existingBookingPlan.Description = bookingPlan.Description;
               // existingBookingPlan.StartDate = bookingPlan.StartDate;
               // existingBookingPlan.EndDate = bookingPlan.EndDate;

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
