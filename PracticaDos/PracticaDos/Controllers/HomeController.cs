using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaDos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }

        public ActionResult Reporte()
        {
            return View();
        }

        public ActionResult Informacion()
        {
            return View();
        }

    }
}