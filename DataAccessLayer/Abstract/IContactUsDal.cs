using DataAccessLayer.Concrete.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IContactUsDal : IGenericDal<ContactUs>
    {
        List<ContactUs> GetListTrue();
        List<ContactUs> GetListFalse();

        void ContactUsFalse(int id);
    }
}
