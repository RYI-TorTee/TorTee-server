using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.Submissions
{
    public class GradeSubmissionRequest
    {
        public Guid Id { get; set; }       
        public string? Description { get; set; }
        public float Grade { get; set; }
    }
}
