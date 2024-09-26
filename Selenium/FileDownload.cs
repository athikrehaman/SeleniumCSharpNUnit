using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumTraining.Selenium
{
    internal class FileDownload
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement ChooseFile = driver.FindElement(By.LinkText("test.png"));
            ChooseFile.Click();

            Thread.Sleep(3000);

            

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}