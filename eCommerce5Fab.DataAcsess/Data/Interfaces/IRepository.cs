using System.Linq.Expressions;

namespace eCommerce5Fab.DataAcsess.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Edit(T entity);
        T Get(int id);
        T Get(Expression<Func<T, bool>> fillter);
        IEnumerable<T> GetAll();
        void Save();
    }
}
