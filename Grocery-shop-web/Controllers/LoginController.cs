using Microsoft.AspNetCore.Mvc;

namespace Grocery_shop_web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
