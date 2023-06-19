using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager: INewsLetterService
    {
         INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void Delete(NewsLetter t)
        {
           _newsLetterDal.Delete(t);
        }

        public NewsLetter GetById(int id)
        {
           return _newsLetterDal.GetById(id);
        }

        public List<NewsLetter> GetListAll()
        {
            return _newsLetterDal.GetListAll();
        }

        public void Insert(NewsLetter t)
        {
            _newsLetterDal.Insert(t);
        }

        public void Update(NewsLetter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
