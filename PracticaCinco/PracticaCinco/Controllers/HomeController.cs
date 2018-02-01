using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace PracticaCinco.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Monitoreo]
        public ActionResult Index()
        {
            return View();
        }
    }

}