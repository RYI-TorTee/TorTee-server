﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TorTee.Core.Domains.Entities;
using TorTee.Core.Domains.Enums;

namespace TorTee.BLL.Models.Requests.MenteeApplication
{
    public class MenteeApplicationCreateRequestModel
    {
        public DateTime AppliedDate { get; set; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.PENDING;

        public Guid UserId { get; set; }

        public Guid MenteePlanId { get; set; }

    }
}