using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ahorcado;

namespace UnitTests
{
    [TestClass]
    public class Sprint1
    {
        public Logic logic = new Logic();
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

            logic.juego.Vidas = 6;
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
            logic.juego.Palabra = "Hola";
            logic.juego.PalabraIngresada = "*ol*";
            logic.juego.Vidas = 1;

            int n = logic.ValidarJuego();
            bool resultado;
            if (n == 1)
                resultado = true;
            else
                resultado = false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarJuegoPerdido()
        {
            Logic logic = new Logic();
            logic.juego.Palabra = "Hola";
            logic.juego.PalabraIngresada = "*ol*";
            logic.juego.Vidas = 0;

            int n = logic.ValidarJuego();
            bool resultado;
            if (n == 2)
                resultado = true;
            else
                resultado = false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void ValidarJuegoGanado()
        {
            Logic logic = new Logic();
            logic.juego.Palabra = "Hola";
            logic.juego.PalabraIngresada = "Hola";
            logic.juego.Vidas = 1;

            int n = logic.ValidarJuego();
            bool resultado;
            if (n == 3)
                resultado = true;
            else
                resultado = false;

            Assert.IsTrue(resultado);
        }

        //[TestMethod]
        //public void PalabraCompletada() { }
    }
}
