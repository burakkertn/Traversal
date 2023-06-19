  using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Traversal.CQRS.Commands.TeamCommands;

namespace Traversal.CQRS.Handlers.TeamHandlers
{
    public class CreateTeamCommanHandler : IRequestHandler<CreateTeamCommand>
    {
        private readonly TraversalContext _context;

        public CreateTeamCommanHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            _context.Teams.Add(new Team
            {
                Name = request.Name,
                Des = request.Description,
                Status = true             
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
