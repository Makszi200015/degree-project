using Microsoft.AspNetCore.Mvc;

namespace Degree.Controllers
{
    public class HistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
