using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _ProfilBilgisi : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfilBilgisi(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        //FeatureManager _featureManager = new FeatureManager(new EnFeatureDal());
        public async Task <IViewComponentResult> InvokeAsync()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.MemberName = values.Name + " " + values.SurName;
            ViewBag.MemberNumber = values.PhoneNumber;
            ViewBag.MemberMail = values.Email;
            return View();
        }
    }
}
