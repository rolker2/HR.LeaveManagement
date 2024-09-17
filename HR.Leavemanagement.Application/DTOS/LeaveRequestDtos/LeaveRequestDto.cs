using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Leavemanagement.Application.DTOS.LeaveTypeDtos;

namespace HR.Leavemanagement.Application.DTOS.LeaveRequestDtos
{
    public class LeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveTypeDto { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestComments { get; set; }
        public DateTime ActionedDate { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsCanceled { get; set; }
    }
}
