using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Aranoz.UI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
    public class AdminLayoutLogoutModalComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
