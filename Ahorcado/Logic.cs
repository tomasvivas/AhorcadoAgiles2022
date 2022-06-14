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

        #region
        //Código viejo

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
        #endregion //Eliminar en MVP

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

        public int ValidarJuego()
        {
            if (juego.Vidas <= 0)
                return 2;
            if (juego.Palabra == juego.PalabraIngresada)
                return 3;
            else
                return 1;
        }

        public void ActualizarPalabraIngresada(string letra)
        {
            //string pre, pos;
            char[] l = letra.ToCharArray();
            char[] p = juego.PalabraIngresada.ToCharArray();

            for (int i = 0; i <= juego.Palabra.Length-1; i++)
            {
                #region
                /*
                if (juego.Palabra.Substring(i, 1) == letra)
                {
                    if (i == 0 || i == juego.Palabra.Length) { 
                        if (i==0) //!(i==0 || i== juego.Palabra.Length)
                        juego.PalabraIngresada = letra + juego.PalabraIngresada.Substring((i+1), (juego.PalabraIngresada.Length - i));
                    else
                        juego.PalabraIngresada = juego.PalabraIngresada.Substring(0, (i - 1)) + letra;
                    }
                    else
                        juego.PalabraIngresada = juego.PalabraIngresada.Substring(0, (i - 1)) + letra + juego.PalabraIngresada.Substring((i + 1), (juego.PalabraIngresada.Length - i));
                    //juego.PalabraIngresada = juego.PalabraIngresada.Substring(0, (i-1)) + letra + juego.PalabraIngresada.Substring((i+1), (juego.PalabraIngresada.Length - i));
                    pre = juego.PalabraIngresada.Substring(0, (i - 1));
                    pos = juego.PalabraIngresada.Substring((i + 1), (juego.PalabraIngresada.Length - i));
                    juego.PalabraIngresada = pre + letra + pos;
                }*/
                #endregion
                if (juego.Palabra[i] == l[0]) 
                {
                    p[i] = l[0];
                }
            }
            juego.PalabraIngresada = string.Join("",p);
        }

        public bool IngresoLetra(string letra) //se ingresa una letra, se modifican los parametros del juego y se responde si la letra es correcta o incorrecta
        {
            //se ingresa una letra
            bool resultado = false;

            //se comprueba si existe en la palabra y se añade a la lista correspondiente
            // AÑADIR: se informa si la letra es correcta o no y modificar palabra ingresada <- ActualizarPalabraIngresada()
            if (ValidarLetra(letra) == true)
            { 
                AgregarLetraCorrecta(letra);
                ActualizarPalabraIngresada(letra);
                resultado = true;
            }
            else
            {
                AgregarLetraIncorrecta(letra);
                RestarVida();
                resultado = false;
            }

            return resultado;
        }

        //Queda:
        // -Sumar IngresoLetra() y ValidarJuego()
        // -informar juego terminado y resultado
        // -quitar el restarvida() de ingresoletra() [?] <- Añadir al juego final
        // -validar que la letra ya fue ingresada    [??] <- ValidarLetra()
        // -arriesga palabra                         [??] <- ArriesgaPalabra()
        // -Contar turnos [??]

        #region
        //Código sin revisar

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
        #endregion //Eliminar en MVP
    }
}
