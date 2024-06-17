using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Commons
{
    public class MessageParams 
    {
        
    }

    public class ChatBoxParams 
    {
        [Required]
        public Guid ChatPartnerId { get; set; } 
    }
}
