﻿using Microsoft.AspNetCore.Mvc;

namespace Grocery_shop_web.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
