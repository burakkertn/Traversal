using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.Des
{
    public class _TeamDetails:ViewComponent
    {
        private readonly ITeamService _teamService;
        public _TeamDetails(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _teamService.GetById(1);
            return View(values);
        }
    }
}
