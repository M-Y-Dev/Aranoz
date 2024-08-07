using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
