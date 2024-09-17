using HR.Leavemanagement.domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.domain
{
    public class LeaveAllocation : BaseDomaineEntity
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType LeaveType { get; set; }
        public int Period { get; set; }
    }
}
