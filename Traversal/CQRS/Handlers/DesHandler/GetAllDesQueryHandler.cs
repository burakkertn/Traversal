using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Traversal.CQRS.Results.DesResults;

namespace Traversal.CQRS.Handlers.DesHandler
{
    public class GetAllDesQueryHandler
    {
        private readonly TraversalContext _context;

        public GetAllDesQueryHandler(TraversalContext context)
        {
            _context = context;
        }

        public List<GetAllDesQueryResult> Handle()
        {
            var values = _context.Dess.Select(x => new GetAllDesQueryResult
            {
                ID = x.Id,
                capacity = x.Capacity,
                city = x.City,
                daynight = x.DayNight,
                price = x.Price

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
