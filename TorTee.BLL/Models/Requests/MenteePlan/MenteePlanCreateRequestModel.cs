using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.MenteePlan
{
    public class MenteePlanCreateRequestModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TotalSlot { get; set; }
        public double Price { get; set; }
        public MenteePlanStatus Status { get; set; } = MenteePlanStatus.AVAILABLE;

        public Guid MentorId { get; set; }

    }
}
