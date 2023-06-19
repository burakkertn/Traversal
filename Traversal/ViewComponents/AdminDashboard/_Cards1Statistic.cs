using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        TraversalContext c = new TraversalContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Dess.Count();
            ViewBag.v2 = c.Users.Count();
            return View();
        }
    }
}
