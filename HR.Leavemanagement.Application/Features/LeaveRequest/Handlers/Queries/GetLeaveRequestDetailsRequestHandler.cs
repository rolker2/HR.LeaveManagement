using AutoMapper;
using HR.Leavemanagement.Application.DTOS.LeaveRequestDtos;
using HR.Leavemanagement.Application.Features.LeaveRequest.Requests.Queries;
using HR.Leavemanagement.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestDetailsRequestHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {

        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailsRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = _leaveRequestRepository.Get(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);  
        }
    }
}
