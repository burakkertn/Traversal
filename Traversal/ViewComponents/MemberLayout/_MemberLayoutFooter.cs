﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.ViewComponents.MemberLayout
{
    public class _MemberLayoutFooter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
