using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AbrirChrome()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            var driver = new ChromeDriver(@"C:\Users\Tomas\source\repos\AhorcadoAgiles2022\UnitTests\Drivers");
            //new ChromeDriver(path + @"\Drivers\");
            //IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);

            driver.Navigate().GoToUrl("https://localhost:44379/");

            //driver.Quit();
        }

    }
}
