using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Commands.DesCommands;

namespace Traversal.CQRS.Handlers.DesHandler
{
    public class CreateDesCommandHandler
    {
        private readonly TraversalContext _context;
        public CreateDesCommandHandler(TraversalContext context)
        {
            _context = context;
        }
        public void Handle(CreateDesCommand command)
        {
            _context.Dess.Add(new Des
            {
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Capacity = command.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
