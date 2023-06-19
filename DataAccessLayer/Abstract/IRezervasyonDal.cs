using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRezervasyonDal : IGenericDal<Rezervasyon>
    {
        List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id);

        List<Rezervasyon> GetListWithRezervasyonByWaitAktif(int id);

        List<Rezervasyon> GetListWithRezervasyonByWaitPasif(int id);
    }
}
