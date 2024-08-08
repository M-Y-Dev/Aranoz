using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.DefaultViewComponents
{
    public class DefaultProductListSliderComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
