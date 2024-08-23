using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Dtos.LeaveTypes;
using HR_Management.Application.Features.LeaveTypes.Requests.Queries;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }


        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var getList=await _leaveTypeRepository.GetAll();

            return _mapper.Map<List<LeaveTypeDto>>(getList);
        }
    }

}
