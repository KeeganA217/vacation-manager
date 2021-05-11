using System;
using System.Collections.Generic;
using vacation_management.Contracts;
using vacation_management.Data;

namespace vacation_management.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {


        private readonly ApplicationDbContext _db;

        public LeaveHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveHistory Entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveHistory Entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveHistory> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveHistory FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveHistory Entity)
        {
            throw new NotImplementedException();
        }
    }
}
