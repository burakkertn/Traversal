using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Controllers
{
    [AllowAnonymous]
    public class TeamController : Controller
    {
        TeamManager teamManager = new TeamManager(new EnTeamDal());
        public IActionResult Index()
        {
            var values = teamManager.GetListAll();
            return View(values);
        }
    }
}
