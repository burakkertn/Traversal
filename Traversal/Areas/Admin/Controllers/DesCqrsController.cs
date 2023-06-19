using Microsoft.AspNetCore.Mvc;
using Traversal.CQRS.Commands.DesCommands;
using Traversal.CQRS.Handlers.DesHandler;
using Traversal.CQRS.Queries.DesQueries;
using Traversal.CQRS.Results.DesResults;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DesCqrsController : Controller 
    {
        private readonly GetAllDesQueryHandler _getAllDesQueryHandler;
        private readonly GetDesByIDQueryHandler _getDesByIDQueryHandler;
        private readonly CreateDesCommandHandler _createDesCommandHandler;
        private readonly RemoveDesCommandHandler _removeDesCommandHandler;
        private readonly UpdateDesCommandHandler _updateDesCommandHandler;

        public DesCqrsController(GetAllDesQueryHandler getAllDesQueryHandler, GetDesByIDQueryHandler getDesByIDQueryHandler, CreateDesCommandHandler createDesCommandHandler, RemoveDesCommandHandler removeDesCommandHandler, UpdateDesCommandHandler updateDesCommandHandler)
        {
            _getAllDesQueryHandler = getAllDesQueryHandler;
            _getDesByIDQueryHandler = getDesByIDQueryHandler;
            _createDesCommandHandler = createDesCommandHandler;
            _removeDesCommandHandler = removeDesCommandHandler;
            _updateDesCommandHandler = updateDesCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDesQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDes(int id)
        {
            var values = _getDesByIDQueryHandler.Handle(new GetDesByIDQuery(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDes(UpdateDesCommand p)
        {
           _updateDesCommandHandler.Handle(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddDes()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDes(CreateDesCommand command)
        {
            _createDesCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDes(int id)
        {
            _removeDesCommandHandler.Handle(new RemoveDesCommand(id));
            return RedirectToAction("Index");
        }
    }
}
