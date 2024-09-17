using HR.Leavemanagement.domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.domain
{
    public class LeaveType : BaseDomaineEntity
    {
        public string Name { get; set; }
        public string DefaultDays { get; set; }
    }
}
