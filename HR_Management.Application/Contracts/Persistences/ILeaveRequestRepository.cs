﻿using HR_Management.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Contracts.Persistences
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task ChangeApprovalStatus(LeaveRequest request, bool? ApprovalStatus);
    }
}
