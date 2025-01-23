using Microsoft.AspNetCore.Mvc;
using ViewComponent.Context;

namespace ViewComponent.Areas.Admin.Controllers
{

    [Area("Admin")]

    public class HomeController(AppDbContext context ) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }

    public IActionResult GetCategories()
    {
        return Json(context.Categories);
    }
}
