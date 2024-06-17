namespace TorTee.BLL.Models.Requests.VnPays
{
    public class VnPayRequest
    {
        public string OrderInfo { get; set; }
        public string FullName { get; set; }
        public string OrderType { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}
