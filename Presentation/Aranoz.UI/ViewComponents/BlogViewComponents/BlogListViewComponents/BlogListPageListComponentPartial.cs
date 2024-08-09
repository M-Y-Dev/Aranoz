using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.BlogViewComponents.BlogListViewComponents
{
    public class BlogListPageListComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
