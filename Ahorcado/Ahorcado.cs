using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Main
    {
        //readonly static char[] alfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        public enum estadoAccion
        {
            repetida,
            acerto,
            fallo,
            primeraVez
        }

        public enum estadoJuego
        {
            Perdio,
            Gano,
            enJuego
        }
        public static string[] letrasIngresadas;

        private Logic _log;
        public Logic log
        {
            set { _log = value; }
            get { return _log; }
        }

        public Main()
        {
            log = new Logic();
        }

        public estadoAccion IngresoLetra(string p)
        {
            if(log.incorrectaRepetida(p) || log.correctaRepetida(p))
            {
                return estadoAccion.repetida;
            } else if (log.IngresoLetra(p))
            {
                return estadoAccion.acerto;
            } else
            {
                return estadoAccion.fallo;
            }
        }

        public estadoJuego IngresoPalabra(string p)
        {
            if (log.ArriesgarPalabra(p))
            {
                return estadoJuego.Gano;
            } else
            {
                return estadoJuego.Perdio;
            }
        }
        public void Play()
        {
            log.juego.Nombre = "Garate";
            log.juego.Palabra = "hola";
            log.juego.PalabraIngresada = "****";
            log.juego.LetrasCorrectas = " ";
            log.juego.Vidas = 5;
            log.juego.LetrasIncorrectas = " ";


        }
    }
}
