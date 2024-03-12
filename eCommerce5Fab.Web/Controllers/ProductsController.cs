using eCommerce5Fab.DataAcsess.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce5Fab.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepo _repo;
        public ProductsController(IProductRepo productreop)
        {
            _repo = productreop;
        }
        public IActionResult List()
        {
            var productInDb = _repo.GetAll().Where(c => c.IsActive == true);
            return View(productInDb);
        }
    }
}
