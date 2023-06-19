using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Team")]
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }
        [Route("AddTeam")]
        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }

        [Route("AddTeam")]
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Insert(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }


       [Route("EditTeam")]
        [HttpGet]
        public IActionResult EditTeam(int id)
        {
            var values = _teamService.GetById(id);
            return View(values);
        }



        [Route("EditTeam")]
        [HttpPost]
        public IActionResult EditTeam(Team team)
        {
            _teamService.Update(team);
            return RedirectToAction("Index");
        }


        [Route("ChangeToTrue/{id}")]

        public IActionResult ChangeToTrue(int id)
        {
            _teamService.TChangeToTrueByTeam(id);
            return RedirectToAction("Index", "Team", new { area = "Admin" });
        }
        [Route("ChangeToFalse/{id}")]

        public IActionResult ChangeToFalse(int id)
        {
            _teamService.TChangeToFalseByTeam(id);
            return RedirectToAction("Index", "Team", new { area = "Admin" });
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.GetById(id);
            _teamService.Delete(values);
            return RedirectToAction("Index");

        }

    }
}