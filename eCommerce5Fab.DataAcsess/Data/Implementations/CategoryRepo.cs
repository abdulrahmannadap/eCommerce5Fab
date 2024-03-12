using ClassLibrary1eCommerce5Fab.Models;
using eCommerce5Fab.DataAcsess.Data.Interfaces;

namespace eCommerce5Fab.DataAcsess.Data.Implementations
{
    public class CategoryRepo : Repository<Category>, ICategoryRepo
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public void Delete(int id)
        {
            var productTobeDelete = _context.Products.Find(id);
            productTobeDelete.IsActive = false;
        }
    }
}
