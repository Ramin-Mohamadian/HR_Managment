using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Requests.Commands
{
    public class DeleteLeaveRequestsCommand:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
