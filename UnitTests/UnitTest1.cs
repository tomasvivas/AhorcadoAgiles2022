using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ahorcado;

namespace UnitTests
{
    [TestClass]
    public class Sprint1
    {
        [TestMethod]
        public void LetraContenidoEnPalabra()
        {
            BaseAhorcado juego = new BaseAhorcado
            {
                Palabra = "uwu"
            };
            Logic logic = new Logic();  //Ahorcado.Logica
            string letra = "u";

            bool resultado = logic.ValidarLetra(letra);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void LetraNoContenidoEnPalabra()
        {
            BaseAhorcado juego = new BaseAhorcado
            {
                Palabra = "uwu"
            };
            Logic logic = new Logic();  //Ahorcado.Logica
            string letra = "f";

            bool resultado = logic.ValidarLetra(letra);

            Assert.IsFalse(resultado);
        }
    }

    [TestClass]
    public class Sprint2
    {

        [TestMethod]
        public void LetraSeAñadeALetrasIncorrectas()
        {
            BaseAhorcado juego = new BaseAhorcado();
            Logic logic = new Logic();
            string letra = "f";

            logic.AgregarLetraIncorrecta(letra);
            bool resultado;

            if (juego.LetrasIncorrectas == "f")
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void LetraSeAñadeALetrasCorrectas()
        {
            BaseAhorcado juego = new BaseAhorcado();
            Logic logic = new Logic();
            string letra = "u";

            logic.AgregarLetraCorrecta(letra);
            bool resultado;

            if (juego.LetrasCorrectas == "f")
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }
    }

    [TestClass]
    public class Sprint3
    {
        [TestMethod]
        public void RestarUnaVida()
        {
            BaseAhorcado juego = new BaseAhorcado();
            Logic logic = new Logic();
            bool resultado;

            juego.Vidas=6;
            logic.RestarVida();
            if (juego.Vidas == 5)
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarQueElJuegoContinua()
        {
            BaseAhorcado juego = new BaseAhorcado();
            Logic logic = new Logic();
            bool resultado1, resultado2, resultado3, resultadoFinal, val;
            juego.Palabra = "Hola";



            juego.PalabraIngresada = "*ol*" ;
            juego.Vidas = 1;
            val = logic.ValidarJuego();
            if (val == true)                //Situacion 1: El juego continua (false) (Vidas > 0 y Palabra != PalabraIngresada)
            {
                resultado1 = false;
            }
            else resultado1 = true;

            logic.RestarVida();
            val = logic.ValidarJuego();
            if (val == true)                //Situacion 2: El juego termina (true) (Vidas == 0 y Palabra != PalabraIngresada)
            {
                resultado2 = true;
            }
            else resultado2 = false;


            juego.PalabraIngresada = "Hola";
            juego.Vidas = 1;
            val = logic.ValidarJuego();
            if (val == true)                //Situacion 3: El juego termina (true) (Vidas > 0 y Palabra == PalabraIngresada)
            {
                resultado3 = true;
            }
            else resultado3 = false;

            if (resultado1 == resultado2 == resultado3 == true)
                resultadoFinal = true;
            else resultadoFinal = false;

            Assert.IsTrue(resultadoFinal);
        }

        //[TestMethod]
        //public void PalabraCompletada() { }
    }
}
