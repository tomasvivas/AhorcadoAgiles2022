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
  

        private static Main _nuevoJuego;
        
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
           
        }
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
           // return RedirectToAction("Index","juego");
        }

        public ActionResult IngresoNombre(FormCollection coleccion)
        {
            estadoAccion = Main.estadoAccion.primeraVez;
            nuevoJuego = new Main();
            nuevoJuego.log.juego.Nombre = coleccion["txtLetra"];
            nuevoJuego.Play("serpiente");
            return RedirectToAction("Index", "juego");
        }
    }
}