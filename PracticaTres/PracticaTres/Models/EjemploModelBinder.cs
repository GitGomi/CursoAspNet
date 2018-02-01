using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace PracticaTres.Models
{
    public class EjemploModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            string oper = controllerContext.HttpContext.Request.Form["OperId"];
            string title = controllerContext.HttpContext.Request.Form["Title"];
            string year = controllerContext.HttpContext.Request.Form["Year"];
            string composer = controllerContext.HttpContext.Request.Form["Composer"];

            Opera opera = new Opera();
            if (oper != null) {
                opera.OperaID = int.Parse(oper);
            }

            opera.Title = title.ToUpper();
            opera.Year = int.Parse(year);
            opera.Composer = composer.ToUpper();

            return opera;
        }
    }
}