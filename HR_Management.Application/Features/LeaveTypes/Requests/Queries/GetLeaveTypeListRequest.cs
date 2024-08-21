using HR_Management.Application.Dtos.LeaveTypes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeListRequest:IRequest<List<LeaveTypeDto>>
    {

    }
}
