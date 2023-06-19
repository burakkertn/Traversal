using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFrameWork;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EnCommentDal());
        TraversalContext context = new TraversalContext();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.commentCount = context.Comments.Where(x => x.ID == id).Count();
            var values = commentManager.TGetListCommentWithDestinationAndUser(id);
            return View(values);
        }
    }
}