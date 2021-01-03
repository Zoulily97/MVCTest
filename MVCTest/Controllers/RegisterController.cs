using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTest.Models;
using BLL.Repositories;
using BLL.Entities;
using MVCTest.Filters;

namespace MVCTest.Controllers
{
    public class RegisterController : Controller
    {
        private UserRepository registerRepository;

        public RegisterController()
        {
            registerRepository = new UserRepository();
        }

        // GET: Register
        //[Route("Home/Contact")]
        [ModelErrorTransferFilter]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {

            //----生成一个cookie
            ////首先有一个cookie，名字为user
            //HttpCookie cookie = new HttpCookie("user");

            ////在cookie中添加若干（2个）键值对
            //cookie.Values.Add("id", "98");
            //cookie.Values.Add("pwd", "1234");

            //cookie.Expires = DateTime.Now.AddDays(14);


            //Response.Cookies.Add(cookie);

            //不会新生成一个cookie
            // Request.Cookies.Add(cookie);
            //不会将名为user的Cookie值删除
            // Request.Cookies["user"].Values.Clear();

            //------/要（在客户端）改变cookie，需要在Response.Cookies中处理，比如：

            //  要删除客户端cookie的删除，也需要我们自己处理：首先将cookie取出来
            //HttpCookie cookie1 = Request.Cookies["user"];
            //cookie1.Expires = DateTime.Now.AddDays(-1);
            //Response.Cookies.Add(cookie1);


            //session
            Session["User"] = new RegisterModel { Name = "飞哥" };//mvc中，session存一个对象，下次可以用

            //RegisterModel model = new RegisterModel()
            //{

            //    InvitedBy = new UserModel { Name = "zoulily123", Id = 1 },
            //    Name = "zoulily",
            //    Password = "123",
            //    RestDay = new List<RestItem> {
            //        new RestItem
            //        {
            //            DayOfWeek=DayOfWeek.Monday
            //        },
            //        new RestItem
            //        {
            //            DayOfWeek=DayOfWeek.Tuesday
            //        },
            //        new RestItem
            //        {
            //            DayOfWeek=DayOfWeek.Wednesday }

            //        },
            //    Keywords = new List<KeywordModel>
            //        {
            //            new KeywordModel
            //            {
            //                Id=1,Content="C#"
            //            },
            //            new KeywordModel
            //            {
            //                Id=2,Content="UI"
            //            },
            //            new KeywordModel
            //            {
            //                Id=3,Content="SQL"
            //            }
            //        }


            //    Keywords = new List<SelectListItem>
            //        {
            //            new SelectListItem
            //            {
            //              Text="C#",
            //            },
            //            new SelectListItem
            //            {
            //                Text="UI"
            //            },
            //            new SelectListItem
            //            {
            //               Text="SQL"
            //            }
            //        }



            //};

            if (TempData["e"] != null)
            {
                ModelState.Merge(TempData["e"] as ModelStateDictionary);
            }
            return View();
        }
        [HttpPost]
        //public ActionResult Index(int? id, string name, RegisterModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {

        //        TempData["e"] = ModelState;
        //        return RedirectToAction(nameof(Index));

        //        // return View(model);
        //    }



        //    return View();
        //}
        [ModelErrorTransferFilter]
        public ActionResult Index(RegisterModel model)
        {
            //if (!ModelState.IsValid)
            //{

            //    TempData["e"] = ModelState;
            //    return RedirectToAction(nameof(Index));

            //    // return View(model);
            //}

            if (!ModelState.IsValid)
            {

                return View(model);
            }

            if (registerRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "用户名不能重复");
            }

            User user1 = new User
            {
                Name = model.Name,
                Password = model.Password,
                Id = 1,


            };
            // user1.Register();
            registerRepository.Save(user1);
            return View();
        }
    }
}