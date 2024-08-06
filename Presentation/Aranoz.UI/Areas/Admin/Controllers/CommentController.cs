using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
