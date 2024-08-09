using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListAllPartComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
