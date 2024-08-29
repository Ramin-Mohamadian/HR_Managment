using HR_Managment.MVC.Models;
using HR_Managment.MVC.Services.Base;

namespace HR_Managment.MVC.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeVM>> GetLeaveTyps();
        Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
        Task<Response<int>>  CreateLeaveType(LeaveTypeVM leaveType);
        Task<Response<int>> UpdateLeaveType(int id,LeaveTypeVM leaveType);
        Task<Response<int>> DeleteLeaveType(int id);
    }
}
