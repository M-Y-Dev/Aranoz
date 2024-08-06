using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
