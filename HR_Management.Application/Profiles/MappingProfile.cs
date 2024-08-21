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
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();
            CreateMap <LeaveRequest,LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();
        }
    }
}
