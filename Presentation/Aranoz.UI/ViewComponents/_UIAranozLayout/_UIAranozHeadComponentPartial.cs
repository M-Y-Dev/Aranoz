using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents._UIAranozLayout
{
    public class _UIAranozHeadComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
