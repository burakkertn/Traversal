using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager _featureManager = new FeatureManager(new EnFeatureDal());
        public IViewComponentResult Invoke()
        {
            //ViewBag.v1= 
            return View();
        }
    }
}
