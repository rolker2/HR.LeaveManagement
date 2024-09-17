using HR.Leavemanagement.domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.domain
{
    public class LeaveRequest : BaseDomaineEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime RequestedDate { get; set; }
        public string RequestComments { get; set; }
        public DateTime ActionedDate { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsCanceled { get; set; }


    }
}
