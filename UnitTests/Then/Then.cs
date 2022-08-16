using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using FluentAssertions;


namespace UnitTests.Then
{
    internal class Then
    {

        private IWebDriver _webDriver;

        public void PageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        private IWebElement Palabra => _webDriver.FindElement(By.Id("palabraIngresada"));
        private IWebElement Vidas => _webDriver.FindElement(By.Id("vidas"));
        private IWebElement Incorrectas => _webDriver.FindElement(By.Id("letras"));


        [Then("La letra se muestra en la palabra a adivinar")]
        public void ThenLetraSeMuestraEnPalabra(string letter)
        {
            Palabra.ToString().Should().Contain(letter);
        }

        [Then("Se descuenta un punto de vida")]
        public void ThenPierdeVida()
        {
            Vidas.ToString().Should().Contain("4/5");
        }

        [Then("La letra se muestra en letras incorrectas")]
        public void ThenLetraSeMeMuestraEnIncorrectas(string letter)
        {
            Incorrectas.ToString().Should().Contain(letter);
        }

        [Then("Usuario gana la partida")]
        public void ThenGanaPartida()
        {
            var Ganar = _webDriver.FindElement(By.Id("gano"));
            Ganar.ToString().Should().Contain("Felicidades");
            Ganar.Should().Be("Visible");
        }
        [Then("Usuario pierde la partida")]
        public void ThenPierdePartida()
        {
            var Perder = _webDriver.FindElement(By.Id("lost"));
            Perder.ToString().Should().Contain("No has acertado");
            Perder.Should().Be("Visible");
        }

    }
}
