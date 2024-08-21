using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
