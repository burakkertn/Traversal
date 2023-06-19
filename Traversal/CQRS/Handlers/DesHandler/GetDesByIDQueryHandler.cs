using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traversal.CQRS.Queries.DesQueries;
using Traversal.CQRS.Results.DesResults;

namespace Traversal.CQRS.Handlers.DesHandler
{
    public class GetDesByIDQueryHandler
    {
        private readonly TraversalContext _context;

        public GetDesByIDQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public GetDesByIDQueryResult Handle(GetDesByIDQuery query)
        {
            var values = _context.Dess.Find(query.id);
            return new GetDesByIDQueryResult
            {
                IdDes = values.Id,
                City = values.City,
                DayNight = values.DayNight,
                Price=values.Price
            };
        }
    }
}
