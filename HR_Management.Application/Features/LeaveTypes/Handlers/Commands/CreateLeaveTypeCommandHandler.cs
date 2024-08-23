using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using HR_Management.Domain.Entiteis;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var createLeaveType= _mapper.Map<LeaveType>(request.CreateLeaveType);
            createLeaveType=await _leaveTypeRepository.Add(createLeaveType);
            return createLeaveType.Id;
        }
    }
}
