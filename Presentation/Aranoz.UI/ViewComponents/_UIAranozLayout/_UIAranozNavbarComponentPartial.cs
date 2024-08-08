using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents._UIAranozLayout
{
    public class _UIAranozNavbarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
