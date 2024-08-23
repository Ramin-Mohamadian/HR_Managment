using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Commands
{
    public class UpdateLeaveTypesCommandHandler : IRequestHandler<UpdateLeaveTypesCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public UpdateLeaveTypesCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveTypesCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.UpdateLeaveTypesDto.Id);
            _mapper.Map(request.UpdateLeaveTypesDto, leaveType);
            await _leaveTypeRepository.Update(leaveType);
            return Unit.Value;
        }
    }
}
