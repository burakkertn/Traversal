using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class DesController : Controller
    {
        DesManager desManager = new DesManager(new EnDesDal());
        public IActionResult Index()
        {
            var values = desManager.GetListAll();
            return View(values);
        }
        public IActionResult GetCitiesSearchByName(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var values = from x in desManager.GetListAll() select x;
            if (!string.IsNullOrEmpty(searchString))
            {
                values = values.Where(y => y.City.Contains(searchString));
            }
            return View(values.ToList());
        }

        public IActionResult Test()
        {
            return View();

        }
    }
}
