using AutoMapper;
using HR.Leavemanagement.Application.DTOS.LeaveAllocationDtos;
using HR.Leavemanagement.Application.Features.LeaveAllocation.Requests.Queries;
using HR.Leavemanagement.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationsListRequestHandler : IRequestHandler<GetLeaveAllocationsRequest, List<LeaveAllocationDto>>
    {

        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationsListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository; 
            _mapper = mapper;
        }
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationsRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocations = await _leaveAllocationRepository.GetAll();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
        }
    }
}
