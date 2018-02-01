using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaNueve.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //[HandleError(ExceptionType =typeof(NotImplementedException), View ="Chale")]
        //[HandleError]
        public ActionResult Index()
        {
            var num = 0;
            var result = 5 / num;
            return View();
        }

        /*
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
        */
    }
}