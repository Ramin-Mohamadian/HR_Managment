using HR_Management.Application.Contracts.Persistences;
using HR_Management.Domain.Entiteis;
using HR_Managment.Persistence.Contexts;

namespace HR_Managment.Persistence.Repositories
{
    public class LeaveTypeRepository:GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagmentContext _context;
        public LeaveTypeRepository(LeaveManagmentContext context):base(context) 
        {
            _context = context;
        }
    }
}
