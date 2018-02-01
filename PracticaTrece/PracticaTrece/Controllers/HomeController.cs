using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaTrece.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Para integrar Ajax tenemos que agregar las siguientes librerias
        //jQuery
        //Microsoft.jQuery.Unobtrusive.Ajax
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Parcial()
        {
            return PartialView();
        }
    }
}