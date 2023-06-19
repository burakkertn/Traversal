using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EnAnnouncementDal : GenericRepo<Haber>, IAnnouncementDal
    {
    }
}
