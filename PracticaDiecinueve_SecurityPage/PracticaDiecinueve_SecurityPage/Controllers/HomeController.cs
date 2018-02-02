using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaDiecinueve_SecurityPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string UserName)
        {
            ViewBag.UserName = UserName;
            return View();
        }
    }
}