using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Commands.DesCommands;

namespace Traversal.CQRS.Handlers.DesHandler
{
    public class UpdateDesCommandHandler
    {
        private readonly TraversalContext _context;

        public UpdateDesCommandHandler(TraversalContext context)
        {
            _context = context;
        }

        public void Handle(UpdateDesCommand command)
        {
            var values = _context.Dess.Find(command.ID);
            values.City = command.City;
            values.DayNight = command.DayNight;
            values.Price = command.Price;
            _context.SaveChanges();
        }
    }
}
