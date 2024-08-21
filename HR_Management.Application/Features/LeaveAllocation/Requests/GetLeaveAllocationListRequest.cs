using HR_Management.Application.Dtos.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Requests
{
    public class GetLeaveAllocationListRequest:IRequest<List<LeaveAllocationDto>>
    {

    }
}
