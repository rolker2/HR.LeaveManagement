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
    public class GetLeaveRequestsListRequestHandler : IRequestHandler<GetLeaveRequestsListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestsListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
           _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestsListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = _leaveRequestRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(leaveRequests);
        }
    }
}
