using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> GetDesById(int id);
        List<Comment> GetListCommentWithDes();
        public List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}
