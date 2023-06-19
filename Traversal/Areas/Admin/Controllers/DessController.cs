using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessController : Controller
    {
        DesManager _desManager = new DesManager(new EnDesDal());
        public IActionResult Index()
        {
            var values = _desManager.GetListAll();
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult AddDes()

        {

            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AddDes(Des des)
        {
            _desManager.Insert(des);
            return RedirectToAction("Index");
           
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public IActionResult DeleteDes(int id)
        {
            var values = _desManager.GetById(id);
            _desManager.Delete(values);
            return RedirectToAction("Index");

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult UpdateDes(int id)
        {
            var values = _desManager.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateDes(Des des)
        {


            _desManager.Update(des);

            return RedirectToAction("Index");



        }
    }
}
