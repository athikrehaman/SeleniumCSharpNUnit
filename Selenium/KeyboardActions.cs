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
    internal class KeyboardActions
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
            driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/single_text_input.html");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Keydown()
        {
            new Actions(driver).KeyDown(Keys.Shift).SendKeys("a").Perform();
            Thread.Sleep(2000);
        }

        [Test]
        public void Keyup()
        {
            new Actions(driver).KeyUp(Keys.Shift).SendKeys("a").Perform();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
