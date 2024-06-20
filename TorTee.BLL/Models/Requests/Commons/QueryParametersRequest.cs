namespace TorTee.BLL.Models.Requests.Commons
{
    public class QueryParametersRequest : PagingRequest
    {
        public IDictionary<string, object>? Filter { get; set; }
        public string Search { get; set; } = string.Empty;
        public string? OrderBy { get; set; }
        public bool IsDesc { get; set; } = false;
    }
}
