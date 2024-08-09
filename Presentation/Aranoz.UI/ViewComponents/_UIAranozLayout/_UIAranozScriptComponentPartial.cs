using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents._UIAranozLayout
{
    public class _UIAranozScriptComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
