using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;

namespace TorTee.Core.Dtos
{
     public class MenteeApplicationAnswerDTO
    {
        public Guid Id { get; set; }
        public string? ResponseContent { get; set; }

        public Guid QuestionId { get; set; }
        public ApplicationQuestion Question { get; set; } = null!;
        public Guid MenteeApplicationId { get; set; }
        public MenteeApplication MenteeApplication { get; set; } = null!;
    }
}
