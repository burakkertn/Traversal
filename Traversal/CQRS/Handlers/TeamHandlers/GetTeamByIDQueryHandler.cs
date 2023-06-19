using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Traversal.CQRS.Queries.TeamQueries;
using Traversal.CQRS.Results.TeamResults;

namespace Traversal.CQRS.Handlers.TeamHandlers
{
    public class GetTeamByIDQueryHandler : IRequestHandler<GetTeamByIDQuery, GetTeamByIDQueryResult>
    {
        private readonly TraversalContext _context;

        public GetTeamByIDQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public async Task<GetTeamByIDQueryResult> Handle(GetTeamByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Teams.FindAsync(request.Id);
            return new GetTeamByIDQueryResult
            {
                IdTeam = values.ID,
                Description = values.Des,
                Name = values.Name
            };
        }
    }
}
