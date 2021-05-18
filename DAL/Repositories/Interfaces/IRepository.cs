using System;
using System.Collections.Generic;

namespace Lab.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate, int pageNumber = 0, int pageSize = 10);

        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
