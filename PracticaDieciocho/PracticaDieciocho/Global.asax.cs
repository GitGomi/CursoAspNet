using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebMatrix.WebData;

namespace PracticaDieciocho
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebSecurity.InitializeDatabaseConnection(
                "DefaultConnection",//Nombre de la conexion
                "UserProfile",//Nombre tabla
                "UserId",//Campo de la tabla
                "UserName",//Campo de la tabla
                true//Indica que automaticamente de van a crear las otras tablas de perfiles,etc.
                );

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
