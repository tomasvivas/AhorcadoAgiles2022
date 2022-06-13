using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    public class Logic
    {

        public BaseAhorcado juego = new BaseAhorcado();

        //public static string Palabra = main.GetPalabra();
        /*public bool ValidarLetra2(char l)
        {
            bool val = false;
            string letra = l.ToString();

            for (int i = 0; i < Palabra.Length; i++)
            {
                if (Palabra.Substring(i, 1) == letra)
                {
                    val = true;
                    break;
                }
            }
            return val;
        }*/

        public bool ValidarLetra(string letra)
        {
            return juego.Palabra.Contains(letra);
        }

        public void AgregarLetraIncorrecta(string letra)
        {
            juego.LetrasIncorrectas += letra;
        }

        public void AgregarLetraCorrecta(string letra)
        {
            juego.LetrasCorrectas += letra;
        }

        public void RestarVida()
        {
            juego.Vidas--;
        }

        public bool ValidarJuego()
        {
            return juego.Vidas == 0 || (juego.Palabra == juego.PalabraIngresada);
        }


        /* public bool PedirLetras()
         {
             bool seguirJugando = true;
             int vidas = 6;
             while (seguirJugando)
             {
                 string letras = ['u', 'w', 'u'];
                 for(int i = 0; i < letras.Length; i++)
                 {
                     if  (juego.Gano() == false) //Significa que no gano.
                     {
                         if (this.ValidarLetra(letras[i]))
                             {
                                 //vidas = vidas;
                                 this.AgregarCorrecta(letras[i]);
                             }
                             else
                             {
                                 vidas = vidas - 1;
                                 this.AgregarLetraIncorrecta(letras[i]);
                             }

                     }
                         if (vidas > 0)
                        {
                             seguirJugando = true;
                        }
                        else
                           {
                         seguirJugando = false;
                         break;
                          }
                     else
                     {
                         //Logica si es que gano.;
                         return true;
                     }

                 }
                 //seguirJugando = false;
             }
             return false;
         }

         /*public bool Gano()
         {

         }*/
    }
}
