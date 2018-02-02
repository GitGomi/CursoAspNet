using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;
using System.Web.Security;

namespace PracticaDieciocho.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            WebSecurity.CreateUserAndAccount("Jose", "123");
            Roles.CreateRole("Ventas");
            Roles.AddUserToRole("Jose", "Ventas");
            return View();
        }
    }
}