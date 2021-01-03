using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _User (int ? level)
        {
            UserModel model = new UserModel
            {
                Name = "小可爱",
                Id = 2,

            };

            ViewBag.level = level;
            return PartialView(model );
        }

        [ChildActionOnly]
        public  PartialViewResult _LogOnStatus()
        {
            return PartialView();
        }
    }
}