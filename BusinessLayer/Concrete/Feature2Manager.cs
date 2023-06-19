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
    public class Feature2Manager : IFeature2Service
    {
        IFeature2Dal _feature2Dal;

        public Feature2Manager(IFeature2Dal feature2Dal)
        {
            _feature2Dal = feature2Dal;
        }

        public void Delete(Feature2 t)
        {
            _feature2Dal.Delete(t);
        }

        public Feature2 GetById(int id)
        {
           return _feature2Dal.GetById(id);
        }

        public List<Feature2> GetListAll()
        {
           return _feature2Dal.GetListAll();
        }

        public void Insert(Feature2 t)
        {
            _feature2Dal.Insert(t);
        }

        public void Update(Feature2 t)
        {
            _feature2Dal.Update(t);
        }
    }
}
