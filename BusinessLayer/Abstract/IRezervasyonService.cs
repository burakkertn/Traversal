using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRezervasyonService : IGenericService<Rezervasyon>
    {
        List<Rezervasyon> GetListWithRezervasyonByWaitApproval(int id);

        List<Rezervasyon> getGetListWithRezervasyonByWaitAktif(int id);


        List<Rezervasyon> getListWithRezervasyonByWaitPasif(int id);

    }
}
