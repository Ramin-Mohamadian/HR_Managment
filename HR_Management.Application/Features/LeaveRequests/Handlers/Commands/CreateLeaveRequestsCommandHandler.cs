using AutoMapper;
using HR_Management.Application.Contracts.Infrastructure;
using HR_Management.Application.Contracts.Persistences;
using HR_Management.Application.Features.LeaveRequests.Requests.Commands;
using HR_Management.Application.Models;
using HR_Management.Domain.Entiteis;
using MediatR;

namespace HR_Management.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestsCommandHandler : IRequestHandler<CreateLeaveRequestsCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;
        public CreateLeaveRequestsCommandHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper,IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }


        public async Task<int> Handle(CreateLeaveRequestsCommand request, CancellationToken cancellationToken)
        {
            var createLeaveRequest = _mapper.Map<LeaveRequest>(request.CreateLeaveRequest);
            createLeaveRequest=await _leaveRequestRepository.Add(createLeaveRequest);

            var email = new Email
            {
                To = "raminmohamadian2020@gmail.com",
                Subject = "this is Test",
                Body = "Idot have idea"
            };

            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception ex)
            {
                //log
                throw;
            }
            return createLeaveRequest.Id;
        }
    }
}
