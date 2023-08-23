using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities.Repository;
using System.Linq.Expressions;

namespace MovieManagement.DataAccess.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly MovieManagementDbContext _context;
        public GenericRepository(MovieManagementDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> prediacte)
        {
            return _context.Set<T>().Where(prediacte);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveAll(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }
}
