using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class FoodCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
