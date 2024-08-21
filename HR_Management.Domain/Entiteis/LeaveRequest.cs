﻿using HR_Management.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Domain.Entiteis
{
    public class LeaveRequest:BaseDomainEntity
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public LeaveType leaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime? DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Aporived { get; set; }
        public bool Cancelled { get; set; }
    }
}
