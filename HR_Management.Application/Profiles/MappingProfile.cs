using AutoMapper;
using HR_Management.Application.Dtos.LeaveAllocation;
using HR_Management.Application.Dtos.LeaveRequest;
using HR_Management.Application.Dtos.LeaveTypes;
using HR_Management.Domain.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            #region LeaveType
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, UpdateLeaveTypesDto>().ReverseMap();
            #endregion


            #region LeaveRequest
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, ChangeLeaveRequestApprovalDto>().ReverseMap();
            #endregion

            #region LeaveAllocation
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

            #endregion





        }
    }
}
