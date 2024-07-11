namespace TorTee.BLL.Models.Requests.PayOs
{
    public class PayOsRequest
    {
        public Guid OrderCode { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
