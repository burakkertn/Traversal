using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager _subAboutManager = new SubAboutManager(new EnSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = _subAboutManager.GetListAll();
            return View(values);
        }
    }
}
