using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ahorcado;
using WebMVC;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
  

        static private Main _nuevoJuego;
        
        static public Main nuevoJuego
        {
            get{ return _nuevoJuego;  }
            set { _nuevoJuego = value; }
        }

        static private int _vidas;
        static private string _listaIncorrectas;
        static private string _palabraIngresada;
        static private Main.estadoAccion _estadoAccion = Main.estadoAccion.primeraVez;

        static public int vidas
        {
            get { return _vidas; }
            set { _vidas = value; }
        }

        static public string palabraIngresada
        {
            get { return _palabraIngresada; }
            set { _palabraIngresada = value; }
        }

        static public string listaIncorrectas

        {
            get { return _listaIncorrectas; }
            set { _listaIncorrectas = value; }
        }

        static public Main.estadoAccion estadoAccion
        {
            get { return _estadoAccion; }
            set { _estadoAccion = value; }
        }

        public HomeController()
        {
            nuevoJuego = new Main();
            nuevoJuego.Play();
        }
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Index","juego");
        }
    }
}