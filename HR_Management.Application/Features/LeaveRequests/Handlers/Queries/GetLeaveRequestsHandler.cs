using AutoMapper;
using HR_Management.Application.Dtos;
using HR_Management.Application.Features.LeaveRequests.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestsHandler : IRequestHandler<GetLeaveRequestsRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestsHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestsRequest request, CancellationToken cancellationToken)
        {
            var leavereuest=await _leaveRequestRepository.Get(request.Id);
            return _mapper.Map<LeaveRequestDto>(leavereuest);
        }
    }
}
