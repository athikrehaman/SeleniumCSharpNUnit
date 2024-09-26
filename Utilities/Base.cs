using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Configuration;

namespace NUnitSeleniumC_Training.Utilities
{
    internal class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            String browserName = ConfigurationManager.AppSettings["browser"];
            initBrowser(browserName);

            driver.Navigate().GoToUrl("https://www.booking.com/index.en-gb.html?aid=2369661&pagename=en-in-booking-desktop&label=msn-HiTydpHndf_KligNqm9Sgw-79852220055838:tikwd-79852393960302:loc-90:neo:mte:lp116072:dec:qsBooking.com)&utm_campaign=English_India%20EN%20IN&utm_medium=cpc&utm_source=bing&utm_term=HiTydpHndf_KligNqm9Sgw&msclkid=576d951af0441a9cdb5bf3f79ce6dbdd&utm_content=Booking%20-%20Desktop");
            driver.Manage().Window.Maximize();
        }

        public void initBrowser(String browserName)
        {
            switch (browserName)
            {
                case "Chrome":
                    //configure the web driver manager
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    // initiialize web driver
                    driver = new ChromeDriver();
                    //launch chrome browser
                    /*driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
                    driver.Manage().Window.Maximize();*/
                    break;

                case "Firefox":
                    //configure the web driver manager
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    // initiialize web driver
                    driver = new FirefoxDriver();
                    //launch chrome browser
                    //driver.Navigate().GoToUrl("https://www.selenium.dev/");
                    //driver.Manage().Window.Maximize();
                    break;

                case "Edge":
                    //configure the web driver manager
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    // initiialize web driver
                    driver = new EdgeDriver();
                    //launch chrome browser
                    driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
                    driver.Manage().Window.Maximize();
                    break;
            }
        }

        [TearDown]
        public void TearDown()
        {
            /*if (driver != null)
            {
                driver.Quit();
                driver = null;
            }*/
            driver.Close();
        }
    }
}
