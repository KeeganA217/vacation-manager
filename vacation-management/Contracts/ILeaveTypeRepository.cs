using System;
using System.Collections.Generic;
using vacation_management.Data;

namespace vacation_management.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveId(int Id);
    }
}
