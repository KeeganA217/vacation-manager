using System;
using System.Collections.Generic;
using vacation_management.Contracts;
using vacation_management.Data;

namespace vacation_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation Entity)
        {
            throw new NotImplementedException();
        }
    }
}
