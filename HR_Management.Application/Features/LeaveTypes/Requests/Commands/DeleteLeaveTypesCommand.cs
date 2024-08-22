using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveTypes.Requests.Commands
{
    public class DeleteLeaveTypesCommand:IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
