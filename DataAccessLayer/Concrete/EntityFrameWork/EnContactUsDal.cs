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
    public class EnContactUsDal : GenericRepo<ContactUs>, IContactUsDal
    {
        public void ContactUsFalse(int id)
        {
          
        }

        public List<ContactUs> GetListFalse()
        {
            using (var context = new TraversalContext())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListTrue()
        {
            using (var context = new TraversalContext())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }
    }
}
