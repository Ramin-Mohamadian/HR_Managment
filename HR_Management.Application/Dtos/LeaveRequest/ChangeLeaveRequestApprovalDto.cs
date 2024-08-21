using HR_Management.Application.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Dtos.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto:BaseDto
    {
        public bool? Approved { get; set; }
    }
}
