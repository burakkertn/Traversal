using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Commands.DesCommands;
using Traversal.CQRS.Commands.TeamCommands;
using Traversal.CQRS.Handlers.DesHandler;
using Traversal.CQRS.Queries.TeamQueries;

namespace Traversal.Areas.Admin.Controllers
{
   
    [Area("Admin")]
    public class TeamMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public TeamMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllTeamQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetTeam(int id)
        {
            var values = await _mediator.Send(new GetTeamByIDQuery(id));
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> AddTeam(CreateTeamCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
      

    }
}
