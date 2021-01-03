using BLL.Entities;
using BLL.Repositories;
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class StudentRegisterController : Controller
    {

        private StudentRepository studentRepository;

        public StudentRegisterController()
        {
            studentRepository = new StudentRepository();
        }
        // GET: StudentRegister
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentModel model)
        {


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (studentRepository.GetByName(model.Name) != null)
            {
                ModelState.AddModelError("Name", "用户名不能重复");
            }

            //存
            Student student = new Student
            {
                Name = model.Name,
                Password = model.Password
            };
            student.Register();
         int id=   studentRepository.Save(student);
            return View();
        }
    }
}