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
    public class FeatureManager: IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Delete(Feature t)
        {
            _featureDal.Delete(t);  
        }

        public Feature GetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> GetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void Insert(Feature t)
        {
           _featureDal.Insert(t);
        }

        public void Update(Feature t)
        {
            _featureDal.Update(t);  
        }
    }
}
