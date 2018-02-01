using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PracticaTres.Models;

namespace PracticaTres.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        OperasDB db = new OperasDB();
        public ActionResult Index()
        {
            return View(db.Operas.ToList());
        }

        public ActionResult Details(int id)
        {
            return View(db.Operas.Find(id));
        }
    }
}