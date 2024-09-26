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
    internal class Dropdown
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement Dopdown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(Dopdown);

            var select = new SelectElement(Dopdown);

            Thread.Sleep(1000);

            //Select By visible Text
            select.SelectByText("Option2");
            Thread.Sleep(1000);

            //Select by Index
            select.SelectByIndex(1);
            Thread.Sleep(1000);

            //Select by attribute value
            select.SelectByValue("option3");
            Thread.Sleep(1000); 
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}