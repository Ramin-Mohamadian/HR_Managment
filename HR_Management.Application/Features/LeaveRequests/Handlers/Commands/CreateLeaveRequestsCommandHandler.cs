using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using HR_Management.Domain.Entiteis;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }


        public async Task<int> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var createLeaveRequest = _mapper.Map<LeaveRequest>(request.CreateLeaveRequest);
            createLeaveRequest=await _leaveRequestRepository.Add(createLeaveRequest);
            return createLeaveRequest.Id;
        }
    }
}
