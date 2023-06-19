using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.ViewComponents.MemberDashboard
{
    public class _TeamList : ViewComponent
    {
        TeamManager _teamManager = new TeamManager(new EnTeamDal());

        

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = _teamManager.GetListAll();
            return View(values);
        }
    }
}
