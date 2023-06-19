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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial GetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> GetListAll()
        {
            return _testimonialDal.GetListAll();
        }

        public void Insert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
