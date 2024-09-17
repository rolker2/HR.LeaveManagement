using HR.Leavemanagement.Application.DTOS.LeaveRequestDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestsListRequest:IRequest<List<LeaveRequestDto>>
    {
    }
}
