using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _Testmonial : ViewComponent
    {

        TestimonialManager _testimonialManager = new TestimonialManager(new EnTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = _testimonialManager.GetListAll();
            return View(values);
        }
    }
}
