using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTests.Given
{
    internal class Given
    {
        private IWebDriver _webDriver;

        public void PageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement TextoIngresar => _webDriver.FindElement(By.Id("txtLetra"));
        private IWebElement BtnEnviar => _webDriver.FindElement(By.ClassName(".btnMain"));

        [Given("Usuario ingresa una (.*)")]
        public void GivenUsuarioIngresaPalabra(string word)
        {
            TextoIngresar.Clear();
            TextoIngresar.SendKeys("Tomas");
            BtnEnviar.Click();
             
        }
    }
}
