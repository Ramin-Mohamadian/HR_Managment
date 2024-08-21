
using HR_Management.Application.Dtos.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestsCommand:IRequest<Unit>
    {
        public int Id { get; set; }
        public ChangeLeaveRequestApprovalDto changeLeaveRequestApprovalDto { get; set; }
        public UpdateLeaveRequestDto  UpdateLeaveRequestDto { get; set; }
    }
}
