using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.DefaultViewComponents
{
    public class DefaultBestSellerComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
