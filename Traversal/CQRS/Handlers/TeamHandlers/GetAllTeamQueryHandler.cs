using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Traversal.CQRS.Queries.TeamQueries;
using Traversal.CQRS.Results.TeamResults;

namespace TraversalCoreProje.CQRS.Handlers.TeamHandlers
{
    public class GetAllTeamQueryHandler:IRequestHandler<GetAllTeamQuery,List<GetAllTeamQueryResult>>
    {
        private readonly TraversalContext _context;
        public GetAllTeamQueryHandler(TraversalContext context)
        {
            _context = context;
        }
        public async Task<List<GetAllTeamQueryResult>> Handle(GetAllTeamQuery request, CancellationToken cancellationToken)
        {
            return await _context.Teams.Select(x => new GetAllTeamQueryResult
            {
                Idteam = x.ID,
                Description = x.Des,
                Image = x.Image,
                Name = x.Name
            }).AsNoTracking().ToListAsync();
        }
    }
}
