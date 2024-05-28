namespace TorTee.BLL.Models.Requests.Messages
{
    public class MessageRequest
    {
        public string Content { get; set; } = null!;
        public DateTime SentTime { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public DateTime? DateRead { get; set; }

    }
}
