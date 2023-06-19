using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Commands.DesCommands;

namespace Traversal.CQRS.Handlers.DesHandler
{
    public class RemoveDesCommandHandler
    {
        private readonly TraversalContext _context;
        public RemoveDesCommandHandler(TraversalContext context)
        {
            _context = context;
        }

        public void Handle(RemoveDesCommand command)
        {
            var values = _context.Dess.Find(command.Id);
            _context.Dess.Remove(values);
            _context.SaveChanges();
        }
    }
}
