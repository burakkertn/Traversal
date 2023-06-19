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

    public class DesManager : IDesService
    {
        IDesDal _desDal;

        public DesManager(IDesDal desDal)
        {
            _desDal = desDal;
        }

        public void Delete(Des t)
        {
            _desDal.Delete(t);  
        }

        public Des GetById(int id)
        {
            return _desDal.GetById(id); 
        }

        public List<Des> GetListAll()
        {
           return _desDal.GetListAll();
        }

        public void Insert(Des t)
        {
            _desDal.Insert(t);  
        }

        public Des TGetDestWithTeam(int id)
        {
            return _desDal.GetDestWithTeam(id);
        }

        public List<Des> TGetLast4Dess()
        {
            return _desDal.GetLast4Dess();
        }

        public void Update(Des t)
        {
            _desDal.Update(t);
        }
    }
}
