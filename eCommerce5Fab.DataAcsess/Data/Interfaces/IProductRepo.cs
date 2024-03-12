using ClassLibrary1eCommerce5Fab.Models;

namespace eCommerce5Fab.DataAcsess.Data.Interfaces
{
    public interface IProductRepo : IRepository<Product>
    {

        void Delete(int id);
    }
}
