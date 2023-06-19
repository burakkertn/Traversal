using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EnCommentDal());
        private readonly UserManager<AppUser> _userManager;
        public CommentController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
           // ViewBag.destID = id;
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = 5;
           // ViewBag.a = "merhaba";
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.State = true;
            commentManager.Insert(p);
            return RedirectToAction("Index", "Des");
        }
    }
}
