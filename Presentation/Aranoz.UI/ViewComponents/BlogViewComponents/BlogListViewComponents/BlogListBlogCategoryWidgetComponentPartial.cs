using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListBlogCategoryWidgetComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
