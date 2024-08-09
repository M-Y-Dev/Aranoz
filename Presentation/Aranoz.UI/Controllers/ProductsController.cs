using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
    }
}
