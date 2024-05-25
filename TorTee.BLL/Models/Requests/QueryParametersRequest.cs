using TorTee.Core.Models;

namespace TorTee.BLL.Models.Requests
{
    public class QueryParametersRequest: PagingRequest
    {        
        public FilterBase? Filter { get; set; }
        public string? Search { get; set; }
        public string? OrderBy { get; set; }
        public bool IsDesc { get; set; } = false;
    }
}
