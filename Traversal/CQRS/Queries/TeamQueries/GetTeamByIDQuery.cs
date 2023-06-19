using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Results.TeamResults;

namespace Traversal.CQRS.Queries.TeamQueries
{
    public class GetTeamByIDQuery : IRequest<GetTeamByIDQueryResult>
    {
        public GetTeamByIDQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
