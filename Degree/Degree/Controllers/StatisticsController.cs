using Microsoft.AspNetCore.Mvc;

namespace Degree.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Telegram()
        {
            return View();
        }
    }
}
