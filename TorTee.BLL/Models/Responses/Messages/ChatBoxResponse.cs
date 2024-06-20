namespace TorTee.BLL.Models.Responses.Messages
{
    public class ChatBoxResponse
    {
        public Guid? CurrentUserId { get; set; }
        public Guid? ChatPartnerId { get; set; }
        public string ChatPartnerName { get; set; }
        public string ChatPartnerPhoto { get; set; }
        public List<MessageResponse> Messages { get; set; }
    }
}
