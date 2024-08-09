using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductDetailViewComponents
{
    public class ProductDetailReviewComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
