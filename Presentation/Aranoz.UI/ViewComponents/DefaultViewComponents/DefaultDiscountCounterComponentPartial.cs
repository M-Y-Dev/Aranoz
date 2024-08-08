using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.DefaultViewComponents
{
    public class DefaultDiscountCounterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    } 
}
