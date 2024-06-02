using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorTee.BLL.Models.Requests.MenteeApplicationAnswer
{
    public class MenteeApplicationAnswerCreateRequestModel
    {
    
        public string? ResponseContent { get; set; }

        public Guid QuestionId { get; set; }
        // public ApplicationQuestion Question { get; set; } = null!;
        public Guid MenteeApplicationId { get; set; }
        //public MenteeApplication MenteeApplication { get; set; } = null!;
    }
}
