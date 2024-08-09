using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductDetailViewComponents
{
    public class ProductDetailCommentComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
