using HR_Management.Application.Dtos.Common;
using HR_Management.Application.Dtos.LeaveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Dtos.LeaveAllocation
{
    public class UpdateLeaveAllocationDto:BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
