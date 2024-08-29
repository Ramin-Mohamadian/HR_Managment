using AutoMapper;
using HR_Managment.MVC.Models;
using HR_Managment.MVC.Services.Base;

namespace HR_Managment.MVC
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateLeaveTypeDto, CreateLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveTypeDto,LeaveTypeVM>().ReverseMap();
        }
    }
}
