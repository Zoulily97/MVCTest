using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Filters
{
    public class ModelErrorTransferFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            ModelStateDictionary modelstate = ((Controller)filterContext.Controller).ModelState;


            if (filterContext.HttpContext.Request.HttpMethod=="Post")
            {
                if (!modelstate.IsValid)
                {
                    filterContext.Controller.TempData[Keys.ErrorInMode] = modelstate;
                    filterContext.Result = new RedirectResult(filterContext.HttpContext.Request.Url.PathAndQuery);
                }

            }
            else if(filterContext.HttpContext.Request.HttpMethod == "Get")
            {
                ModelStateDictionary errors = filterContext.Controller.TempData[Keys.ErrorInMode] as ModelStateDictionary;
                if (errors!=null)
                {
                    modelstate.Merge(errors);


                }

            }
            //else
            //{
            //    throw new NotImplementedException("");
            //}
            base.OnActionExecuting(filterContext);
        }
    }
}