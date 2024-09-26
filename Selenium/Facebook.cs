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
    internal class Facebook
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
            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Keydown()
        {
            IWebElement Email = driver.FindElement(By.Id("email"));
            Email.Click();

            new Actions(driver).KeyDown(Keys.Shift).SendKeys("athik").Perform();
            Thread.Sleep(2000);


        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
