using HR_Management.Application.Persistence.Contracts;
using HR_Management.Domain.Entiteis;
using HR_Managment.Persistence.Contexts;

namespace HR_Managment.Persistence.Repositories
{
    public class LeaveRequestRepository:GenericRepository<LeaveRequest>,ILeaveRequestRepository
    {
        private readonly LeaveManagmentContext _context;
        public LeaveRequestRepository(LeaveManagmentContext context):base(context) 
        {
            _context = context;
        }

        public async Task ChangeApprovalStatus(LeaveRequest request, bool? ApprovalStatus)
        {
            request.Approved=ApprovalStatus;
            await _context.SaveChangesAsync();
        }
    }
}
