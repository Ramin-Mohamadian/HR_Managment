using HR_Management.Application.Dtos.LeaveRequest;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using HR_Management.Application.Features.LeaveRequests.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR_Managment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeaveRequestController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<LeaveRequestController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveRequestDto>>> Get()
        {
            var leaveRequests = await _mediator.Send(new GetLeaveRequestsListRequest());
            return Ok(leaveRequests);
        }

        // GET api/<LeaveRequestController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveRequestDto>> Get(int id)
        {
            var leaveRequest = await _mediator.Send(new GetLeaveRequestsRequest { Id = id });

            return Ok(leaveRequest);
        }

        // POST api/<LeaveRequestController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveRequestDto createLeaveRequest)
        {
            var command = new CreateLeaveRequestsCommand { CreateLeaveRequest = createLeaveRequest };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        //PUT api/<LeaveRequestController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveRequestDto updateLeaveRequestDto)
        {

            var command = await _mediator.Send(new UpdateLeaveRequestsCommand { UpdateLeaveRequestDto = updateLeaveRequestDto, Id = id });
            return NoContent();
        }

        // DELETE api/<LeaveRequestController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = await _mediator.Send(new DeleteLeaveRequestsCommand { Id = id });

            return NoContent();
        }
    }
}
