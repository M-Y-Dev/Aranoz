using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductDetailViewComponents
{
    public class ProductDetailAboutNavbarComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
