using HR_Management.Application.Contracts.Persistences;
using HR_Management.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Persistence.Repositories
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        public Task<LeaveAllocation> Add(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LeaveAllocation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
