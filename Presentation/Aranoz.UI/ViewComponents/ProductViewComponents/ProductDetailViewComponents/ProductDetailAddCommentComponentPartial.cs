﻿using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.ViewComponents.ProductViewComponents.ProductDetailViewComponents
{
    public class ProductDetailAddCommentComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
