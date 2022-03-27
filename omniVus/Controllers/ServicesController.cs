using Microsoft.AspNetCore.Mvc;

namespace omniVus.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
