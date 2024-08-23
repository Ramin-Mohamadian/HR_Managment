using HR_Management.Application.Persistence.Contracts;
using HR_Management.Domain.Entiteis;
using HR_Managment.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
