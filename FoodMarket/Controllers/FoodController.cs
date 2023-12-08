using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
