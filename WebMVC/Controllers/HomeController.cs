using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ahorcado;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
  

        private Main _nuevoJuego;
        
        public Main nuevoJuego
        {
            get{ return _nuevoJuego;  }
            set { _nuevoJuego = value; }
        }
        public HomeController()
        {
            nuevoJuego = new Main();
            nuevoJuego.Play();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult IngresoLetra(FormCollection coleccion)
        {
            string p = coleccion["txtLetra"];
            if(p.Length >= 2)
            {
                return RedirectToAction("IngresoPalabra", new {p});
            } else
            {
                 Main.estadoAccion resultado = nuevoJuego.IngresoLetra(p);
                int est = nuevoJuego.log.ValidarJuego();
                switch (est)
                {
                    case 2:
                        ViewBag.estado = Main.estadoJuego.Perdio;
                        return RedirectToAction("Perdio");
                        //break;
                    case 3:
                        ViewBag.estado = Main.estadoJuego.Gano;
                        return RedirectToAction("Gano"); //Aca por alguna razon no redirecciona a la accion Gano.
                        //break;
                    case 1:
                        ViewBag.estado = Main.estadoJuego.enJuego;
                        return RedirectToAction("Index", resultado);
                        //break;
                }
                return RedirectToAction("Index");
            }
            
        }

        
        public ActionResult IngresoPalabra(string p)
        {
            Main.estadoJuego resultado = nuevoJuego.IngresoPalabra(p);
            switch (resultado)
            {
                case Main.estadoJuego.Gano:
                    ViewBag.mensaje = "Ganaste";
                    return View();
                case Main.estadoJuego.Perdio:
                    ViewBag.mensaje = "Perdiste";
                    return View();
            }
            return View();
        }

        public ActionResult Perdio()
        {
            return View();
        }

        public ActionResult Gano()
        {
            return View();
        }
    }
}