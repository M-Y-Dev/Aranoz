﻿using Microsoft.AspNetCore.Mvc;

namespace Aranoz.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
