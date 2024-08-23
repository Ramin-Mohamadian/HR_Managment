using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestsCommandHandler : IRequestHandler<UpdateLeaveRequestsCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public UpdateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(UpdateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);
            if (request.UpdateLeaveRequestDto != null)
            {
                _mapper.Map(request.UpdateLeaveRequestDto, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);
                return Unit.Value;
            }
            else if (request.changeLeaveRequestApprovalDto != null)
            {
                await _leaveRequestRepository.ChangeApprovalStatus(leaveRequest, request.changeLeaveRequestApprovalDto.Approved);

            }
            return Unit.Value;
        }
    }
}
