using AutoMapper;
using HR_Management.Application.Dtos.LeaveAllocation;
using HR_Management.Application.Features.LeaveAllocation.Requests.Queries;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationHandler : IRequestHandler<GetLeaveAllocationRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public GetLeaveAllocationHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;

        }
        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocatin=await _leaveAllocationRepository.Get(request.Id);
            return _mapper.Map<LeaveAllocationDto>(leaveAllocatin); 
        }
    }
}
