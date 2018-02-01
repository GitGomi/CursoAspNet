using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaCuatro.Controllers
{
    public class AAA : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Mensaje = "Ejecutando Accion de AAA";
            return View();
        }
    }
}