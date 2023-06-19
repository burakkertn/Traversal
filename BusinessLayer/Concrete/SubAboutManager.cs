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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void Delete(SubAbout t)
        {
           _subAboutDal.Delete(t);
        }

        public SubAbout GetById(int id)
        {
            return _subAboutDal.GetById(id);
        }

        public List<SubAbout> GetListAll()
        {
           return _subAboutDal.GetListAll();
        }

        public void Insert(SubAbout t)
        {
            _subAboutDal.Insert(t);
        }

        public void Update(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
