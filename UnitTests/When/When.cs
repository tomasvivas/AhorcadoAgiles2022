using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTests.When
{
    internal class When
    {
        private IWebDriver _webDriver;

        public void PageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement TextoIngresar => _webDriver.FindElement(By.Id("txtLetra"));
        private IWebElement BtnEnviar => _webDriver.FindElement(By.ClassName(".btnMain"));

        [When(@"Usuario ingresa una letra (.*)")]
        public void WhenUsuarioIngresaLetra(string letter)
        {
            TextoIngresar.Clear();
            TextoIngresar.SendKeys(letter);
            BtnEnviar.Click();

        }

        [When(@"Usuario ingresa todas las letras (.*)")]
        public void WhenUsuarioIngresaLetras(Array letras)
        {
            TextoIngresar.Clear();
            foreach (string letrasItem in letras)
            {
                TextoIngresar.SendKeys(letrasItem);
            }
            BtnEnviar.Click();

        }
    }
}
