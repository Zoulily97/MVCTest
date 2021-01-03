using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Models
{
    //[Serializable]
    public class RegisterModel
    {

        public string InvitedBy { get; set; }
     // [Required(ErrorMessage ="用户名不能为空")]
        public string Name { get; set; }
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


    //public enum Hobby
    //{
    //    [Display(Name = "篮球")]
    //    BasketBall,
    //    [Display(Name = "球")]
    //    Ball,
    //    [Display(Name = "足球")]
    //    FootBall
    //}
    //public class RestItem
    //{
    //    public bool Selected { get; set; }
    //    public DayOfWeek DayOfWeek { get; set; }
    //}

    //public class KeywordModel
    //{
    //    public int Id { get; set; }
    //    public string Content { get; set; }
    //    public int UserId { get; set; }
    //}
}