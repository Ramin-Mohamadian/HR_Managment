using HR_Management.Application.Dtos.LeaveAllocation;
using HR_Management.Application.Features.LeaveAllocation.Requests;
using HR_Management.Application.Features.LeaveAllocation.Requests.Commands;
using HR_Management.Application.Features.LeaveAllocation.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Managment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveAllocationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeaveAllocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveAllocationDto>>> Get()
        {
            var leaveAllocations = await _mediator.Send(new GetLeaveAllocationListRequest());

            return Ok(leaveAllocations);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveAllocationDto>> Get(int id)
        {
            var LeaveAllocation=await _mediator.Send(new GetLeaveAllocationRequest { Id = id });
            return Ok(LeaveAllocation);
        }



        [HttpPost]
        public async Task<ActionResult> Post(CreateLeaveAllocationDto createLeaveAllocationDto)
        {
            var commandPost=await _mediator.Send(new CreateLeaveAllocationCommand { CreateLeaveAllocation = createLeaveAllocationDto });    
            return Ok(commandPost);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, UpdateLeaveAllocationDto updateLeaveAllocationDto)
        {
            var updateCommand=await _mediator.Send(new UpdateLeaveAllocationCommand { UpdateLeaveAllocationDto = updateLeaveAllocationDto });
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var DeleteCommand=await _mediator.Send(new DeleteLeaveAllocationCommand { Id = id });
            return NoContent();
        }
    }
}
