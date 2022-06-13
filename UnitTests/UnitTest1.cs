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
            Logic logic = new Logic();
            logic.juego = new BaseAhorcado("Test", "uwu", 6);
            string letra = "u";


            bool resultado = logic.ValidarLetra(letra);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void LetraNoContenidoEnPalabra()
        {
            Logic logic = new Logic();
            logic.juego = new BaseAhorcado("Test", "uwu", 6);
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
            Logic logic = new Logic();
            string letra = "f";

            logic.AgregarLetraIncorrecta(letra);
            bool resultado;

            if (logic.juego.LetrasIncorrectas == "f")
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void LetraSeAñadeALetrasCorrectas()
        {
            Logic logic = new Logic();
            string letra = "u";

            logic.AgregarLetraCorrecta(letra);
            bool resultado;

            if (logic.juego.LetrasCorrectas == "f")
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsFalse(resultado);
        }
    }

    [TestClass]
    public class Sprint3
    {
        [TestMethod]
        public void RestarUnaVida()
        {
            Logic logic = new Logic();
            bool resultado;

            logic.juego.Vidas=6;
            logic.RestarVida();
            if (logic.juego.Vidas == 5)
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarQueElJuegoContinua()
        {
            Logic logic = new Logic();
            bool resultado1, resultado2, resultado3, resultadoFinal, val;
            logic.juego.Palabra = "Hola";

            logic.juego.PalabraIngresada = "*ol*" ;
            logic.juego.Vidas = 1;
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

            logic.juego.PalabraIngresada = "Hola";
            logic.juego.Vidas = 1;
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
