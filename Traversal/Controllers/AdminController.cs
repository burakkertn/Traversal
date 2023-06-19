using Microsoft.AspNetCore.Mvc;

namespace Traversal.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialBrandDemo()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }
        public PartialViewResult ParitalSideBar()
        {
            return PartialView();
        }
        public PartialViewResult ParitalFooter()
        {
            return PartialView();
        }
        public PartialViewResult ParitalJs()
        {
            return PartialView();
        }
    }
}
