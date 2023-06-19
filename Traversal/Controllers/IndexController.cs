using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
