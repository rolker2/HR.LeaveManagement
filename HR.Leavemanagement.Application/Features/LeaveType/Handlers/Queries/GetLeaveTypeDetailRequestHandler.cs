using AutoMapper;
using HR.Leavemanagement.Application.DTOS.LeaveTypeDtos;
using HR.Leavemanagement.Application.Features.LeaveType.Requests.Queries;
using HR.Leavemanagement.Application.Persistance.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {

        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveType, IMapper mapper)
        {
            _leaveTypeRepository = leaveType;
            _mapper = mapper;
            
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
