using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.Leavemanagement.Application.DTOS.LeaveTypeDtos;

namespace HR.Leavemanagement.Application.DTOS.LeaveAllocationDtos
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveTypeDto { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
