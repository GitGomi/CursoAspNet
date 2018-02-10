using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Carrito
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/content/bootstrap")
                .Include("~/Content/Styles/bootstrap.min.css",
                "~/Content/Styles/bootstrap-responsive.min.css",
                "~/Content/Styles/bootstrappage.css"));

            bundles.Add(new StyleBundle("~/content/global")
                .Include("~/Content/Styles/flexslider.css",
                "~/Content/Styles/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Content/Scripts/jquery-1.7.2.min.js",
                "~/Content/Scripts/bootstrap.min.js",
                "~/Content/Scripts/superfish.js",
                "~/Content/Scripts/jquery.scrolltotop.js"));

            bundles.Add(new ScriptBundle("~/bundles/commonflexlider")
                .Include("~/Content/Scripts/common.js",
                "~/Content/Scripts/jquery.flexslider-min.js"));

        }
    }
}