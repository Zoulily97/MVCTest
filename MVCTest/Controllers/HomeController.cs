using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return RedirectToAction(nameof(About),"Home",new { id=5});//重定向
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application 描述 page.";


            return View();
        }

        public ActionResult Contact(int? id)
        {
            ViewBag.Message = "你的联系页面.";
            ViewData["id"] = id;

            return View();
        }
    }
}