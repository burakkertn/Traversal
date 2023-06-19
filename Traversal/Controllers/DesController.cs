using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class DesController : Controller
    {
        DesManager DesManager = new DesManager(new EnDesDal());
        private readonly UserManager<AppUser> _userManager;
        public DesController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = DesManager.GetListAll();
            return View(values);
        }

        //[HttpGet]
        public async Task<IActionResult> DesDetay(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userID = value.Id;
            var values = DesManager.TGetDestWithTeam(id);
            return View(values);
        }
        //[HttpPost]
        //public IActionResult DestinationDetails(Destination p)
        //{
        //    return View();
        //}
    }
}
