using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumTraining.Selenium
{
    internal class NavigationalCommand
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
            //driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            //driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            // Launch the Browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);

            driver.Navigate().Back();

            Thread.Sleep(3000);

            driver.Navigate().Forward();

            Thread.Sleep(3000);

            driver.Navigate().Refresh();

            Thread.Sleep(3000);


        }

        [TearDown]
        public void TearDownBrowser()
        {
            //Will close the current browser session
            driver.Close();

            // driver.Quit() will close all the browser session

        }
    }
}