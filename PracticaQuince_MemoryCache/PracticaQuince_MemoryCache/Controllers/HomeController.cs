using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.Caching;


namespace PracticaQuince_MemoryCache.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //Para utilizar Memory Cache tenemos que agregar una refenencia
        //Add Referencia -> Assemblies -> Framework -> System.Runtime.Caching
        public ActionResult Index()
        {

            ObjectCache cache = MemoryCache.Default;
            string val = (string)cache.Get("dato");
            if (val != null) {
                ViewBag.respuesta = "Existe en cache ---> " + val;
                return View();
            }

            val = "Son los datos almacenados";
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(3);
            cache.Add("dato", val, policy);
            ViewBag.respuesta = "Se integro a la memoria ---> " + val;
            return View();
        }
    }
}