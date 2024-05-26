namespace TorTee.BLL.Models.Responses.Messages
{
    public class MessageResponse
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public string SenderName { get; set; } = null!;
        public string ReceiverName { get; set; } = null!;
        public string SenderPhotoUrl { get; set; } = null!;
        public string ReceiverPhotoUrl { get; set; } = null!;
        public DateTime SentTime { get; set; }
        public DateTime? DateRead { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        
    }
}
