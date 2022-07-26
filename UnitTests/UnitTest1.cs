using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Ahorcado;
using OpenQA.Selenium.Chrome;


namespace UnitTests
{
    [TestClass]
    public class Sprint1
    {
        private Logic _logic;

        public Logic logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        public Sprint1()
        {
            logic = new Logic();
        }
        [TestMethod]
        public void LetraContenidoEnPalabra()
        {
            // Logic logic = new Logic();
            logic.juego = new BaseAhorcado("Test", "uwu", 6);
            string letra = "u";


            bool resultado = logic.ValidarLetra(letra);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void LetraNoContenidoEnPalabra()
        {
           // Logic logic = new Logic();
            logic.juego = new BaseAhorcado("Test", "uwu", 6);
            string letra = "f";

            bool resultado = logic.ValidarLetra(letra);

            Assert.IsFalse(resultado);
        }

        /*
        [TestMethod]
        public void AbrirChrome()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://google.com/");

            driver.Quit();
        }*/
    }

    [TestClass]
    public class Sprint2
    {
        private Logic _logic;

        public Logic logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        public Sprint2()
        {
            logic = new Logic();
        }

        [TestMethod]
        public void LetraSeAñadeALetrasIncorrectas()
        {
            //Logic logic = new Logic();
            logic.juego.LetrasIncorrectas = "abc";
            logic.AgregarLetraIncorrecta("f");
            bool resultado;

            if (logic.juego.LetrasIncorrectas == "abcf")
            {
                resultado = true;
            }
            else resultado = false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void LetraSeAñadeALetrasCorrectas()
        {
            //Logic logic = new Logic();
            logic.juego.LetrasCorrectas = "olh";
            logic.AgregarLetraCorrecta("a");
            bool resultado;

            if (logic.juego.LetrasCorrectas == "olha")
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
        private Logic _logic;

        public Logic logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        public Sprint3()
        {
            logic = new Logic();
        }

        [TestMethod]
        public void RestarUnaVida()
        {
            //Logic logic = new Logic();
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
            //Logic logic = new Logic();
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
            //Logic logic = new Logic();
            //No es redundante instanciar la Palabra y la palabraIngresada?
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
    }

    [TestClass]
    public class Sprint4
    {
        private Logic _logic;

        public Logic logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        public Sprint4()
        {
            logic = new Logic();
        }
        [TestMethod]
        public void InicializarPalabraIngresada()
        {
            //Logic logic = new Logic();
            logic.juego.Palabra = "Hola";

            logic.juego.SetPalabraIngresada(logic.juego.Palabra);

            Assert.AreEqual("****", logic.juego.PalabraIngresada);
        }

        [TestMethod]
        public void ModificarPalabraIngresadaConLetraCorrecta()
        {
            //Logic logic = new Logic();
            logic.juego.Palabra = "Hola";
            logic.juego.PalabraIngresada = "*ol*";

            logic.ActualizarPalabraIngresada("H");

            Assert.AreEqual("Hol*" , logic.juego.PalabraIngresada);
        }

        [TestMethod]
        public void NoSeModificaLaPalabraCuandoLaLetraEsIncorrecta()
        {
            //Logic logic = new Logic();
            logic.juego.Palabra = "Hola";
            logic.juego.PalabraIngresada = "*ol*";

            logic.ActualizarPalabraIngresada("F");

            Assert.AreEqual("*ol*", logic.juego.PalabraIngresada);
        }

        [TestMethod]
        public void SeIngresaPalabraCorrectaaaa()
        {
            logic.juego.Palabra = "cinto";
            logic.juego.PalabraIngresada = "c*n**";
            logic.juego.Vidas = 2;
            Assert.AreEqual(true, logic.ArriesgarPalabra("cinto"));
        }

        [TestMethod]
        public void SeIngresaPalabraIncorrectaaaa()
        {
            logic.juego.Palabra = "orcas";
            logic.juego.PalabraIngresada = "*r*as";
            logic.juego.Vidas = 2;
            Assert.AreEqual(false, logic.ArriesgarPalabra("urnas"));
        }

        //Tests para:
        //  - AñadirPalabraIngresada() 
        //  - IngresoLetra()
    }

    [TestClass]
    public class Sprint5
    {
        private Logic _logic;

        public Logic logic
        {
            set { _logic = value; }
            get { return _logic; }
        }
        public Sprint5()
        {
            logic = new Logic();
        }

        [TestMethod]
        public void ValidarLetraRepetidaIncorrecta()
        {
            logic.juego.LetrasIncorrectas = "abe";
            
            Assert.AreEqual(true,logic.incorrectaRepetida("a"));

        }

        [TestMethod]

        public void ValidarLetraRepetidaCorrecta()
        {
            logic.juego.LetrasCorrectas = "suda";
            
            Assert.AreEqual(true, logic.correctaRepetida("u"));

        }
    }
    //Probable Sprint 5:
    //  - Informar resultado e IngresoLetra() + ValidarJuego()
    //  - Validar que la letra ya fue ingresada    [??] <- ValidarLetra()
    //  - Arriesga palabra                         [??] <- ArriesgaPalabra()
    //  - Contar turnos [??]
}
