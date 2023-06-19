using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinationsController : Controller
    {
        private readonly IDesService _desService;
        public LastDestinationsController(IDesService destinationService)
        {
            _desService = destinationService;
        }
        public IActionResult Index()
        {
            var values = _desService.TGetLast4Dess();
            return View(values);
        }
    }
}
