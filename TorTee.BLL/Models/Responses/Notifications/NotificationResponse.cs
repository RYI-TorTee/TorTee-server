﻿namespace TorTee.BLL.Models.Responses.Notifications
{
    public class NotificationResponse
    {
        public string? SenderId { get; set; }
        public string? SenderAvatar { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
