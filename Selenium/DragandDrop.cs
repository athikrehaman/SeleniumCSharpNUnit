using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DragandDrop
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement Source = driver.FindElement(By.XPath("//div[@id='column-a']"));
            IWebElement Dest = driver.FindElement(By.XPath("//div[@id='column-a']"));

            new Actions(driver).DragAndDrop(Source, Dest).Perform();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
