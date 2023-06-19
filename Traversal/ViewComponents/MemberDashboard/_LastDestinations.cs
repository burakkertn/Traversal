using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        private readonly IDesService _desService;

        public _LastDestinations(IDesService destinationService)
        {
            _desService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _desService.TGetLast4Dess();
            return View(values);
        }
    }
}
