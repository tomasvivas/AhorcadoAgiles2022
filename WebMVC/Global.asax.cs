using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ahorcado;

namespace WebMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private Main _nuevoJuego;

        public Main nuevoJuego
        {
            get { return _nuevoJuego; }
            set { _nuevoJuego = value; }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            nuevoJuego = new Main();
            nuevoJuego.Play();
        }
    }
}
