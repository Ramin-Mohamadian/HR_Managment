using HR_Management.Application.Dtos.LeaveTypes;
using HR_Management.Application.Features.LeaveTypes.Requests.Commands;
using HR_Management.Application.Features.LeaveTypes.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR_Managment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypesController : ControllerBase
    {

        private readonly IMediator _mediator;
        public LeaveTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<LeaveTypesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LeaveTypeDto>>> Get()
        {
            var listType =await _mediator.Send(new GetLeaveTypeListRequest());
            return Ok(listType);
        }

        // GET api/<LeaveTypesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDto>> Get(int id)
        {
            var leaveType=await _mediator.Send(new GetLeaveTypeRequest{ Id=id});
            return Ok(leaveType);
        }

        // POST api/<LeaveTypesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateLeaveTypeDto createLeaveType)
        {
            var command = await _mediator.Send(new CreateLeaveTypeCommand { CreateLeaveType = createLeaveType });
            return Ok(command);
        }

        // PUT api/<LeaveTypesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateLeaveTypesDto updateLeave)
        {
            var updateleave=await _mediator.Send(new UpdateLeaveTypesCommand { UpdateLeaveTypesDto = updateLeave });
            return NoContent();

        }

        // DELETE api/<LeaveTypesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id)
        {
            var command=await _mediator.Send(new DeleteLeaveTypesCommand { Id=id });
            return NoContent();
        }
    }
}
