﻿namespace TorTee.Core.Dtos
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
