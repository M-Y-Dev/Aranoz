using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductDetailViewComponents
{
    public class ProductDetailIAddBasketButonComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
