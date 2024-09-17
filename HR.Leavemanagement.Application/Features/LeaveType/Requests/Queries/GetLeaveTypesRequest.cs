using HR.Leavemanagement.Application.DTOS.LeaveTypeDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypesRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
