using Microsoft.AspNetCore.Mvc;

namespace Grocery_shop_web.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Basic()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult LockScreen()
        {
            return View();
        }
        public IActionResult Buttons()
        {
            return View();
        }
        public IActionResult Typography()
        {
            return View();
        }
        public IActionResult Icons()
        {
            return View();
        }
        public IActionResult Charts()
        {
            return View();
        }
    }
}
