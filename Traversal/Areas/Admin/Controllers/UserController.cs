using BusinessLayer.Abstract;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IRezervasyonService _rezervasyonService;

        public UserController(IAppUserService appUserService, IRezervasyonService rezervasyonService)
        {
            _appUserService = appUserService;
            _rezervasyonService = rezervasyonService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetListAll();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.Delete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.GetListAll();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            var values = _rezervasyonService.getGetListWithRezervasyonByWaitAktif(id);
            return View(values);
        }
    }
}
