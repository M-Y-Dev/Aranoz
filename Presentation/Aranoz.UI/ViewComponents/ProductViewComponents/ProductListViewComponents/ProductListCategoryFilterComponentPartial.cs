using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductListViewComponents
{
    public class ProductListCategoryFilterComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}
