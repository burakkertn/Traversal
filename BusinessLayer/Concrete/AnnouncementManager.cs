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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Delete(Haber t)
        {
           _announcementDal.Delete(t);
        }

        public Haber GetById(int id)
        {
           return _announcementDal.GetById(id); 
        }

        public List<Haber> GetListAll()
        {
           return _announcementDal.GetListAll();
        }

        public void Insert(Haber t)
        {
           _announcementDal.Insert(t);  
        }

        public void Update(Haber t)
        {
            _announcementDal.Update(t); 
        }
    }
}
