using HR_Management.Application.Dtos.LeaveAllocation;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocation.Requests.Commands
{
    public class CreateLeaveAllocationCommand:IRequest<int>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocation { get; set; }
    }
}
