using Microsoft.AspNetCore.Mvc;

namespace omniVus.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookMeeting()
        {
            return View();
        }
    }
}
