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

        public static string[] letrasIngresadas;

        readonly BaseAhorcado juego = new BaseAhorcado();

        public void Play()
        {
            juego.Nombre = "Tomy";
            juego.Palabra = "uwu";


        }
    }
}
