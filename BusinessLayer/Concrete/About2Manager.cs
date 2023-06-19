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
    public class About2Manager :  IAbout2Service
    {
        IAbout2Dal _about2Dal;

        public About2Manager(IAbout2Dal about2Dal)
        {
            _about2Dal = about2Dal;
        }

        public void Delete(About2 t)
        {
            _about2Dal.Delete(t);
        }

        public About2 GetById(int id)
        {
            return _about2Dal.GetById(id);
        }

        public List<About2> GetListAll()
        {
            return _about2Dal.GetListAll();
        }

        public void Insert(About2 t)
        {
           _about2Dal.Insert(t);
        }

        public void Update(About2 t)
        {
            _about2Dal.Update(t);
        }
    }
}
