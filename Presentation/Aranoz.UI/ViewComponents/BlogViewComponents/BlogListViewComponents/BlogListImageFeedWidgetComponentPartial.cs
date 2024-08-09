using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListImageFeedWidgetComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
