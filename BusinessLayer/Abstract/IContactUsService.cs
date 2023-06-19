using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService: IGenericService<ContactUs>
    {
        List<ContactUs> TGetListTrue();
        List<ContactUs> TGetListFalse();

        void ContactUsFalse(int id);
    }
}
