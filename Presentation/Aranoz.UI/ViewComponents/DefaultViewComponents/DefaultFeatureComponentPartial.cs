using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.DefaultViewComponents
{
    public class DefaultFeatureComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
