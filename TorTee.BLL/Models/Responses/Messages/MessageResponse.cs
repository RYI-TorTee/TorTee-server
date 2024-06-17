namespace TorTee.BLL.Models.Responses.Messages
{
    public class MessageResponse
    {        
        public Guid Id { get; set; }
        public string Content { get; set; } = null!;
        public string SenderName { get; set; } = null!;
        public string SenderId { get; set; } = null!;
        public string SenderPhotoUrl { get; set; } = null!;
        public DateTime SentTime { get; set; }
        public DateTime? DateRead { get; set; }
        public bool IsSentByCurrentUser { get; set; }

    }
}
