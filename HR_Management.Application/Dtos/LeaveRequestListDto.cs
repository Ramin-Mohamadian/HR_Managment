using HR_Management.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Dtos
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto leaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Aporived { get; set; }

    }
}
