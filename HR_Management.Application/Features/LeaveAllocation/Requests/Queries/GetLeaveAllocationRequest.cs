using HR_Management.Application.Dtos.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
