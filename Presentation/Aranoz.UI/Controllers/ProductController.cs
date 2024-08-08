using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            return View();
        }
    }
}
