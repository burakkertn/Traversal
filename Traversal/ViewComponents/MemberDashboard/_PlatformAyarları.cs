using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _PlatformAyarları : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _PlatformAyarları(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
