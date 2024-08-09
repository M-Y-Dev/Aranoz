using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class BlogsController : Controller
    {
        public IActionResult BlogList()
        {
            return View();
        }
    }
}
