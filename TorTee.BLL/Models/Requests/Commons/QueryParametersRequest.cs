using TorTee.Core.Models;

namespace TorTee.BLL.Models.Requests.Commons
{
    public class QueryParametersRequest : PagingRequest
    {
        public IDictionary<string, object>? Filter { get; set; }
        public string? Search { get; set; }
        public string? OrderBy { get; set; }
        public bool IsDesc { get; set; } = false;
    }
}
