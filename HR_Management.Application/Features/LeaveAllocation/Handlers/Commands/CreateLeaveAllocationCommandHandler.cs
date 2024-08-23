using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveAllocation.Requests.Commands;
using MediatR;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository,IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var createLeaveAllocations = _mapper.Map<Domain.Entiteis.LeaveAllocation>(request.CreateLeaveAllocation);
            createLeaveAllocations=await _leaveAllocationRepository.Add(createLeaveAllocations);
            return createLeaveAllocations.Id;
        }
    }
}
