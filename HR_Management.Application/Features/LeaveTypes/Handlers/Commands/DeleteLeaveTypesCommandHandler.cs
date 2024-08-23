using AutoMapper;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using MediatR;

namespace HR_Management.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypesCommandHandler : IRequestHandler<DeleteLeaveTypesCommand, Unit>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypesCommandHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveTypesCommand request, CancellationToken cancellationToken)
        {
            var deleteLeavetype = await _leaveTypeRepository.Get(request.Id);
            await _leaveTypeRepository.Delete(deleteLeavetype);
            return Unit.Value;
        }
    }
}
