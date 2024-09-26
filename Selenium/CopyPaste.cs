using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class CopyPaste
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
            Thread.Sleep(1000);

            new Actions(driver).SendKeys("Athik").Perform();
            Thread.Sleep(2000);

            new Actions(driver).KeyDown(Keys.Control).SendKeys("a").Perform();
            Thread.Sleep(2000);
            new Actions(driver).KeyUp(Keys.Control).Perform();

            IWebElement textbox = driver.FindElement(By.XPath("//input[@id='textInput']"));

            new Actions(driver).KeyDown(Keys.Control).SendKeys("v").Perform();

            Thread.Sleep(3000);
        }

 
        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
