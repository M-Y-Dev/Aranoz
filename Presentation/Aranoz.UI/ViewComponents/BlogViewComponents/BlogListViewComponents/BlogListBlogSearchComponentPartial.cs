using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListBlogSearchComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
