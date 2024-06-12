using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace TorTee.BLL.Models.Requests.MentorApplications
{
    public class CreateMentorApplicationRequest
    {        
        public string FirstName { get; set; } = null!;     
        public string LastName { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Phone]
        public string PhoneNumber { get; set; } = null!;
        public string Category { get; set; } = null!;
        public IFormFile CV { get; set; } = null!;
        public string? Company { get; set; }
        public string? JobTille { get; set; }
        [Length(100, 10000, ErrorMessage = "Please type at least 100 words")]
        public string Bio { get; set; } = null!;
        [Length(100, 10000, ErrorMessage = "Please type at least 100 words")]
        public string Reason { get; set; } = null!;
        [Length(50, 10000, ErrorMessage = "Please type at least 50 words")]
        public string Achievement { get; set; } = null!;
        public string? DescriptionOfPlan { get; set; }
        [Range(1,100, ErrorMessage = "The accepted number is in 1 to 100")]
        public int CallPerMonth { get; set; }
        [Range(30, 1000, ErrorMessage = "The accepted number is in 30 to 1000")]
        public int DurationOfMeeting { get; set; }
        [Range(1, 100, ErrorMessage = "The accepted number is in 1 to 100")]
        public int TotalSlot { get; set; }
        public double Price { get; set; }
    }

}
