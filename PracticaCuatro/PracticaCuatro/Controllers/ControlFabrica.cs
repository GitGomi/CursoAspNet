using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace PracticaCuatro.Controllers
{
    public class ControlFabrica : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type t = null;
            if (controllerName == "Home") {
                t = typeof(AAA);
            }

            return t == null ? null : (IController)Activator.CreateInstance(t);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null) {
                disposable.Dispose();
            }
        }
    }
}