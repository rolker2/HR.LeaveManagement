using HR.Leavemanagement.Application.DTOS.LeaveAllocationDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest: IRequest<LeaveAllocationDto>
    {
        public int  Id { get; set; }
    }
}
