using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EnTeamDal: GenericRepo<Team>, ITeamDal
    {
        TraversalContext context = new TraversalContext();

        public void ChangeToFalseByTeam(int id)
        {
            var values = context.Teams.Find(id);
            values.Status = false;
            context.Update(values);
            context.SaveChanges();
        }

        public void ChangeToTrueByTeam(int id)
        {
            var values = context.Teams.Find(id);
            values.Status = true;
            context.Update(values);
            context.SaveChanges();
        }

 
    }
}
