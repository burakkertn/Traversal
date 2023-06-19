using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EnCommentDal : GenericRepo<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDes()
        {
            using(var c = new TraversalContext())
            {
               return c.Comments.Include(x => x.Des).ToList();
            }
        }
        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {
            using (var c = new TraversalContext())
            {
                return c.Comments.Where(x => x.ID == id).Include(x => x.AppUser).ToList();
            }
        }
    }
}
