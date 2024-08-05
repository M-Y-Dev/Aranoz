using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
