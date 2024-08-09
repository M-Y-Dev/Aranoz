using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListTagWidgetComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
