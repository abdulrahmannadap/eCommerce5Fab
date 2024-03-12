using eCommerce5Fab.DataAcsess.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eCommerce5Fab.DataAcsess.Data.Implementations
{
    
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public T Get(int id)
        {
            return _dbSet.Find(id);
        }

        public T Get(Expression<Func<T, bool>> fillter)
        {
            return _dbSet.SingleOrDefault(fillter);
        }

        public IEnumerable<T> GetAll()
        {
            return  _dbSet.ToList();
        }

        public void Edit(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
