using Microsoft.AspNetCore.Mvc;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Product");
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Popular()
        {
            return View();
        }
    }
}
