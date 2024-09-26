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
    internal class BrowserCommand
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
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //Get Title of the Page

            String title = driver.Title;
            Console.WriteLine(title);

            //Get the current URL
            String currenturl = driver.Url;
            Console.WriteLine(currenturl);

            //Fetch the page source of the html page
            String pagesource = driver.PageSource;
            Console.WriteLine(pagesource);

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