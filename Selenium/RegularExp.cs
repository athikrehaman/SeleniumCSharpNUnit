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
    internal class RegularExp
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
            IWebElement starts = driver.FindElement(By.XPath("//div[starts-with(@class,'Footer_footer__')]"));

            IWebElement containsEle = driver.FindElement(By.XPath("//div[contains(@class, 'footer__column')]"));
        }


        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
