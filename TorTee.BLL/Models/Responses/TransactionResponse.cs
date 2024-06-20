namespace TorTee.BLL.Models.Responses
{
    public class TransactionResponse
    {
        public DateTime CreatedDate { get; set; }
        public double Total { get; set; }
        public Guid MenteeApplicationId { get; set; }
        public Guid MenteeId { get; set; }
        public Guid MentorId { get; set; }
        public string? MentorName { get; set; }
        public string? MenteeName { get; set; }
    }
}
