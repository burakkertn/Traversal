using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class RezervasyonController : Controller
    {
        DesManager _desManager = new DesManager(new EnDesDal());

        RezervasyonManager _rezervasyonManager = new RezervasyonManager(new EnRezervasyonDal());

        private readonly UserManager<AppUser> _userManager;

        public RezervasyonController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyAktifRezervasyon()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _rezervasyonManager.getGetListWithRezervasyonByWaitAktif(values.Id);
            return View(valuesList);

        }
        public async Task<IActionResult> MyPasiffRezervasyon()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _rezervasyonManager.getListWithRezervasyonByWaitPasif(values.Id);
            return View(valuesList);

        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList =  _rezervasyonManager.GetListWithRezervasyonByWaitApproval(values.Id);
            return View(valuesList);

        }


        [HttpGet]
        public IActionResult NewRezervasyon()
        {
            List<SelectListItem> values = (from x in _desManager.GetListAll() 
                                          select new SelectListItem 
            {
                Text = x.City,
                Value= x.Id.ToString()
            
            }).ToList();


            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewRezervasyon(Rezervasyon p)
        {
            p.AppUserId = 7;
            p.Status = "Onay Bekliyor";
            _rezervasyonManager.Insert(p);
            return RedirectToAction("MyAktifRezervasyon");
            
        }
    }
}
