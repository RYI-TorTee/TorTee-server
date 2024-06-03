using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.Commons
{
    public class MessageParams : PagingRequest
    {
        
    }

    public class ChatBoxParams : PagingRequest
    {
        [Required]
        public Guid ChatPartnerId { get; set; } 
    }
}
