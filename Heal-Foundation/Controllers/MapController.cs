using Microsoft.AspNetCore.Mvc;

namespace Heal_Foundation.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}