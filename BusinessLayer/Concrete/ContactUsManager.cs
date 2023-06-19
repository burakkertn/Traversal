using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void ContactUsFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactUs t)
        {
           _contactUsDal.Delete(t); 
        }

        public ContactUs GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetListAll()
        {
           return _contactUsDal.GetListAll();
        }

        public void Insert(ContactUs t)
        {
         _contactUsDal.Insert(t);
        }

        public List<ContactUs> TGetListFalse()
        {
            return _contactUsDal.GetListFalse();
        }

        public List<ContactUs> TGetListTrue()
        {
            return _contactUsDal.GetListTrue();
        }

        public void Update(ContactUs t)
        {
            _contactUsDal.Update(t);
        }
    }
}
