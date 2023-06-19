using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Queries.DesQueries
{
    public class GetDesByIDQuery
    {
        public GetDesByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
