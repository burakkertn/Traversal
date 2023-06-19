using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Delete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id); 
        }

        public List<Comment> GetListAll()
        {
            return _commentDal.GetListAll();
        }

        public void Insert(Comment t)
        {
           _commentDal.Insert(t);
        }

        public List<Comment> GetDesById(int id)
        {
            return _commentDal.GetListByFilter(x=> x.DesId == id);
        }
        public void Update(Comment t)
        {
            _commentDal.Update(t);
        }

        public List<Comment> GetListCommentWithDes()
        {
            return _commentDal.GetListCommentWithDes();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);
             
        }
    }
}
