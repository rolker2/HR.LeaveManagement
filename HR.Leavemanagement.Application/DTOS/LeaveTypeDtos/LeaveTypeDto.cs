using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.DTOS.LeaveTypeDtos
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        public string DefaultDays { get; set; }
    }
}
