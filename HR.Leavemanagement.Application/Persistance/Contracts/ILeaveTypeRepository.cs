using HR.Leavemanagement.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Leavemanagement.Application.Persistance.Contracts
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
    }
}
