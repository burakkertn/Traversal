using BusinessLayer.Concrete;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _IstatistikPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new TraversalContext();
            ViewBag.v1 = c.Dess.Count();
            ViewBag.v2 = c.Teams.Count();
            ViewBag.v3 = "285";
            ViewBag.v4 = "2385";
            return View();
        }
    }
}
 