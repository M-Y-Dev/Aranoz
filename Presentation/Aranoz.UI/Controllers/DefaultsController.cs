using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class DefaultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
