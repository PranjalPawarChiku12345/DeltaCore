using System.Collections.Generic;
using System.Web.Mvc;

namespace DeltaCore.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            ProductService productService = new ProductService();
            List<Product> products = productService.GetProducts();
            return View(products);
        }
    }
}