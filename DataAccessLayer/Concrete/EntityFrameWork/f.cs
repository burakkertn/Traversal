using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EfDestinationDal : GenericRepo<Des>, IDesDal
    {


        public Des GetDestWithTeam(int id)
        {
            using (var c = new TraversalContext())
            {
                return c.Dess.Where(x => x.Id == id).Include(x => x.Team).FirstOrDefault();
            }
        }

        public List<Des> GetLast4Dess()
        {
            using (var context = new TraversalContext())
            {
                var values = context.Dess.Take(4).OrderByDescending(x => x.Id).ToList();
                return values;
            }
        }


    }
}
