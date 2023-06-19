using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EnDesDal : GenericRepo<Des>, IDesDal
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


