using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class MakeMyTrip
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //configure the web driver manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // initiialize web driver
            driver = new ChromeDriver();
            //launch chrome browser
            driver.Navigate().GoToUrl("https://www.makemytrip.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(1000);
            IWebElement Closewindow = driver.FindElement(By.XPath("//span[@class='commonModal__close']"));
            Closewindow.Click();
            Thread.Sleep(3000);

            IWebElement Departure = driver.FindElement(By.XPath("//span[contains(text(),'Departure')]"));
            Departure.Click();
            Thread.Sleep(2000);

            IWebElement Depdate = driver.FindElement(By.XPath("(//div[@class='dateInnerCell'])[21]"));
            Depdate.Click();
            Thread.Sleep(1000);
            

            /*IWebElement Return = driver.FindElement(By.XPath("//span[contains(text(),'Return')]"));
            Return.Click();
            Thread.Sleep(2000);

            IWebElement Retdate = driver.FindElement(By.XPath("(//div[@class='dateInnerCell'])[46]"));
            Retdate.Click();
            Thread.Sleep(1000);
            Retdate.Click();
            Thread.Sleep(3000);*/
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
