using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;
using TorTee.BLL.Models.Responses;
using TorTee.BLL.Models.Responses.Users;
using TorTee.BLL.Services.IServices;
using TorTee.Common.Helpers;
using TorTee.Core.Domains.Constants;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Extensions;
using TorTee.DAL;

namespace TorTee.BLL.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ServiceActionResult> GetAll(QueryParametersRequest queryParameters)
        {
            var transactionQueryable = (await _unitOfWork.TransactionRepository.GetAllAsyncAsQueryable());

            transactionQueryable = !string.IsNullOrEmpty(queryParameters.OrderBy)
                ? transactionQueryable.OrderByDynamic(queryParameters.OrderBy, queryParameters.IsDesc)
                : transactionQueryable.OrderByDescending(u => u.CreatedDate);

            return new ServiceActionResult()
            {
                Data = PaginationHelper.BuildPaginatedResult<Transaction, TransactionResponse>
                (_mapper,
                transactionQueryable.Include(t=>t.MenteeApplication).ThenInclude(a => a.User).Include(t=>t.MenteeApplication).ThenInclude(a=>a.MenteePlan).ThenInclude(p=>p.Mentor),
                queryParameters.PageSize, queryParameters.PageIndex)
            };
        }
    }
}
