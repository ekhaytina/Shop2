using Microsoft.AspNetCore.Mvc;

namespace Shop2.Data.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
