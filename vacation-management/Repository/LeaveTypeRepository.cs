using System;
using System.Collections.Generic;
using vacation_management.Contracts;
using vacation_management.Data;

namespace vacation_management.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveType Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveType Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveType FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveId(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveType Entity)
        {
            throw new NotImplementedException();
        }
    }
}
