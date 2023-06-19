using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DesManager _desManager = new DesManager(new EnDesDal());
        public IViewComponentResult Invoke()
        {
            var values = _desManager.GetListAll();
            return View(values);
        }
    }
}
