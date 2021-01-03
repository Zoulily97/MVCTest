using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Models
{

    public class StudentModel
    {
        public string InvitedBy { get; set; }
        [Required(ErrorMessage = "用户名不能空")]
        public string Name { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "密码不能空")]
        public string Password { get; set; }
        public string ComfirmPassword { get; set; }
        //public bool? IsMale { get; set; }
        //public DateTime Time { get; set; }
        //public IList<RestItem> RestDay { get; set; }
        //public int BirthMonth { get; set; }
        //public IList<KeywordModel> Keywords { get; set; }
        ////public IList<SelectListItem> Keywords { get; set; }


        //public DayOfWeek Ondute { get; set; }
        //public Hobby Hobby { get; set;  }
    }




}