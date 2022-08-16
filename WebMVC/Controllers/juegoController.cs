using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ahorcado;

namespace WebMVC.Controllers
{
    public class juegoController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            switch (HomeController.estadoAccion)
            {
                case Main.estadoAccion.primeraVez:
                    ViewBag.cantVidas =  HomeController.nuevoJuego.log.juego.Vidas;
                    ViewBag.nombre = HomeController.nuevoJuego.log.juego.Nombre;
                    ViewBag.palabraIngresada = HomeController.nuevoJuego.log.juego.PalabraIngresada;
                    ViewBag.palabra = HomeController.nuevoJuego.log.juego.Palabra;
                    return View();

                default:
                    ViewBag.cantVidas = HomeController.vidas;
                    ViewBag.palabraIngresada = HomeController.palabraIngresada;
                    ViewBag.listaIncorrectas = HomeController.listaIncorrectas;
                    ViewBag.nombre = HomeController.nuevoJuego.log.juego.Nombre;
                    return View();
            }


        }


            /*
            [HttpPost]
            public ActionResult Index(Main.estadoAccion est = Main.estadoAccion.primeraVez)
            {
                ViewBag.cantVidas = nuevoJuego.log.juego.Vidas;
                ViewBag.palabraIngresada = nuevoJuego.log.juego.PalabraIngresada;
                ViewBag.letrasIncorrectas = nuevoJuego.log.juego.LetrasIncorrectas;
                return View();
            }*/

        [HttpPost]

        public ActionResult IngresoLetra(FormCollection coleccion)
        {
            string p = coleccion["txtLetra"];
            if (p.Length >= 2)
            {
                return RedirectToAction("IngresoPalabra", new { p });
            }
            else
            {
                Main.estadoAccion resultado = HomeController.nuevoJuego.IngresoLetra(p);
                int est = HomeController.nuevoJuego.log.ValidarJuego();
                switch (est)
                {
                    case 2: //Perdio
                        ViewBag.estado = Main.estadoJuego.Perdio;
                        return RedirectToAction("Perdio");
                    //break;
                    case 3: //Gano
                        ViewBag.estado = Main.estadoJuego.Gano;
                        return RedirectToAction("Gano"); //Aca por alguna razon no redirecciona a la accion Gano.
                                                         //break;
                    case 1: //Sigue jugando
                        ViewBag.estado = Main.estadoJuego.enJuego;
                        HomeController.vidas = HomeController.nuevoJuego.log.juego.Vidas;
                        HomeController.palabraIngresada = HomeController.nuevoJuego.log.juego.PalabraIngresada;
                        HomeController.listaIncorrectas = HomeController.nuevoJuego.log.juego.LetrasIncorrectas;
                        HomeController.estadoAccion = resultado;
                        return RedirectToAction("Index");
                        //break;
                }
                return RedirectToAction("Index");
            }

        }


        public ActionResult IngresoPalabra(string p)
        {
            Main.estadoJuego resultado = HomeController.nuevoJuego.IngresoPalabra(p);
            switch (resultado)
            {
                case Main.estadoJuego.Gano:
                    return RedirectToAction("Gano");

                case Main.estadoJuego.Perdio:
                    return RedirectToAction("Perdio");
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