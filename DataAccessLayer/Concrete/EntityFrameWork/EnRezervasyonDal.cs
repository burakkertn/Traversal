using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFrameWork
{
    public class EnRezervasyonDal : GenericRepo<Rezervasyon>, IRezervasyonDal
    {
        public List<Rezervasyon> GetListWithRezervasyonByWaitAktif(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Rezervasyons.Include(x => x.Des).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();

            }
        }

        public List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id)
        {
           using (var context = new TraversalContext())
            {
                return context.Rezervasyons.Include(x => x.Des).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();

            }
        }

      

        public List<Rezervasyon> GetListWithRezervasyonByWaitPasif(int id)
        {
            using (var context = new TraversalContext())
            {
                return context.Rezervasyons.Include(x => x.Des).Where(x => x.Status == "Geçmiş" && x.AppUserId == id).ToList();

            }
        }
    }
}
