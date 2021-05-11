using System;
using System.Collections.Generic;

namespace vacation_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();

        T FindById(int Id);

        bool Create(T Entity);

        bool Update(T Entity);

        bool Delete(T Entity);

        bool Save();
    }
}
