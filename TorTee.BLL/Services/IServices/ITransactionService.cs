using TorTee.BLL.Models;
using TorTee.BLL.Models.Requests.Commons;

namespace TorTee.BLL.Services.IServices
{
    public interface ITransactionService
    {
        Task<ServiceActionResult> GetAll(QueryParametersRequest queryParameters);
      
    }
}
