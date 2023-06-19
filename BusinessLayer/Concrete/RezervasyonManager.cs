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
    public class RezervasyonManager : IRezervasyonService
    {
        IRezervasyonDal _rezervasyonDal;

        public RezervasyonManager(IRezervasyonDal rezervasyonDal)
        {
            _rezervasyonDal = rezervasyonDal;
        }

        public void Delete(Rezervasyon t)
        {
            _rezervasyonDal.Delete(t);
        }

        public Rezervasyon GetById(int id)
        {
           return _rezervasyonDal.GetById(id);
        }

        public List<Rezervasyon> getGetListWithRezervasyonByWaitAktif(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByWaitAktif(id);
        }

        public List<Rezervasyon> GetListAll()
        {
            return _rezervasyonDal.GetListAll();    
        }

        public List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByWaitApproval(id);  
        }

     
        public List<Rezervasyon> getListWithRezervasyonByWaitPasif(int id)
        {
            return _rezervasyonDal.GetListWithRezervasyonByWaitPasif(id);
        }

        public void Insert(Rezervasyon t)
        {
           _rezervasyonDal.Insert(t);   
        }

        public void Update(Rezervasyon t)
        {
            _rezervasyonDal.Update(t);
        }
    }
}