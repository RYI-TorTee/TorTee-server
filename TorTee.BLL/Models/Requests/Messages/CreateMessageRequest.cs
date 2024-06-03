namespace TorTee.BLL.Models.Requests.Messages
{
    public class CreateMessageRequest
    {
        public Guid ReceiverId { get; set; }
        public string Content { get; set; } = null!;
    }
}
