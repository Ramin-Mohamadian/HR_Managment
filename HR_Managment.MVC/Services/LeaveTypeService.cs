using AutoMapper;
using HR_Management.Application.Dtos.LeaveTypes;
using HR_Managment.MVC.Contracts;
using HR_Managment.MVC.Models;
using HR_Managment.MVC.Services.Base;

namespace HR_Managment.MVC.Services
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        private readonly IMapper mapper;
        private readonly IClient client;
        private readonly IlocalStorageService localstorageService;

        public LeaveTypeService(IMapper mapper, IClient client, IlocalStorageService localstorageService)
            : base(client, localstorageService)
        {
            this.mapper = mapper;
            this.client = client;
            this.localstorageService = localstorageService;
        }


        public async Task<Response<int>> CreateLeaveType(LeaveTypeVM leaveType)
        {
            try
            {
                var response = new Response<int>();
                CreateLeaveTypeDto createLeaveTypeDto =
                    mapper.Map<CreateLeaveTypeDto>(leaveType);

                //TODO Auth

                var apiResponse = client.LeaveTypesPOSTAsync(createLeaveTypeDto);

                if (apiResponse.IsCompletedSuccessfully)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {

                }
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }

        }

        public async Task<Response<int>> DeleteLeaveType(int id)
        {
            try
            {
                await client.LeaveTypesDELETEAsync(id);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptions<int>(ex);
            }
        }

        public async Task<LeaveTypeVM> GetLeaveTypeDetails(int id)
        {
            var leavetype = await client.LeaveTypesGETAsync(id);
            return mapper.Map<LeaveTypeVM>(leavetype);
        }

        public async Task<List<LeaveTypeVM>> GetLeaveTyps()
        {
            var leavetypes = await client.LeaveTypesAllAsync();
            return mapper.Map<List<LeaveTypeVM>>(leavetypes);
        }

        public async Task<Response<int>> UpdateLeaveType(int id, LeaveTypeVM leaveType)
        {
            //try
            //{
            //    UpdateLeaveTypesDto updateLeaveTypes = mapper.Map<UpdateLeaveTypesDto>(leaveType);
            //    client.LeaveTypesPUTAsync(id, updateLeaveTypes);
            //    return new Response<int> { Success = true};
            //}
            //catch (ApiException ex)
            //{
            //    return ConvertApiExceptions<int>(ex);
            //}
            return null;
        }
    }
}
