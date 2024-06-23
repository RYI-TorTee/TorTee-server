namespace TorTee.BLL.Models.Requests.Notifications
{
    public class NotificationRequest
    {
        public string Content { get; set; } = null!;        
        public Guid? SenderId { get; set; }     
        public Guid? ReceiverId { get; set; }  
    }
}
