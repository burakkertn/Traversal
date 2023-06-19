using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Results.TeamResults;

namespace Traversal.CQRS.Queries.TeamQueries
{
    public class GetAllTeamQuery:IRequest<List<GetAllTeamQueryResult>>
    {
    }
}
