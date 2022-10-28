using Microsoft.AspNetCore.Mvc;

namespace Degree.Controllers
{
    public class CabinetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
