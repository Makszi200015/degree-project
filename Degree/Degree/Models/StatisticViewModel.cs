using Microsoft.AspNetCore.Mvc;

namespace Degree.Models
{
    public class StatisticViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
