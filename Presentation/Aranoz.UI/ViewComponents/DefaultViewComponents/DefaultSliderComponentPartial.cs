using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.DefaultViewComponents
{
    public class DefaultSliderComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
