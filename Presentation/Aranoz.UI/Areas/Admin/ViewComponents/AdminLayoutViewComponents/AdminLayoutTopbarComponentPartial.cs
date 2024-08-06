using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutTopbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}