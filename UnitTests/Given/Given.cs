using Ahorcado;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
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

        [Given(@"Usuario ingresa un nombre")]
        public void GivenUsuarioIngresaPalabra()
        {
            var driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\Tomas\source\repos\AhorcadoAgiles2022\UnitTests\Drivers");
            driver.Navigate().GoToUrl("");
            TextoIngresar.Clear();
            TextoIngresar.SendKeys("Tomas");
            BtnEnviar.Click();
            Main main = new Main();
            main.Play("pato");
        }
    }
}
