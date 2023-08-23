using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Entities.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T,bool>> prediacte);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveAll(IEnumerable<T> entities);   

    }
}
