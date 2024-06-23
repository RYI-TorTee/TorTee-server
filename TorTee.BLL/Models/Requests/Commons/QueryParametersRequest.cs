namespace TorTee.BLL.Models.Requests.Commons
{
    public class QueryParametersRequest : PagingRequest
    {        
        public string? Search { get; set; } 
        public string? OrderBy { get; set; }
        public bool IsDesc { get; set; } = false;
    }
}
