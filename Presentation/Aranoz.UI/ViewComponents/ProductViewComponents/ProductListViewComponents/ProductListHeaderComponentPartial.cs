using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.Product.ProductListViewComponents
{
    public class ProductListHeaderComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
