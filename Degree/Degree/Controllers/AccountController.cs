using Microsoft.AspNetCore.Mvc;

namespace Degree.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
