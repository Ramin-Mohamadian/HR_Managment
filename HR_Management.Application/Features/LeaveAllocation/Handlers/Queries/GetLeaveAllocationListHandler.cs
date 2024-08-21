using AutoMapper;
using HR_Management.Application.Dtos.LeaveAllocation;
using HR_Management.Application.Features.LeaveAllocation.Requests;
using HR_Management.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Management.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {

        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public GetLeaveAllocationListHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;

        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var getlist=await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveAllocationDto>>(getlist);
        }
    }
}
