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
    internal class Locator
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
            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(10000);

            IWebElement Name = driver.FindElement(By.Name("name"));
            Name.SendKeys("Raman");

            IWebElement Email = driver.FindElement(By.Name("email"));
            Email.SendKeys("raman@gmail.com");

            IWebElement Subject = driver.FindElement(By.Name("submit"));
            Subject.SendKeys("Leave Application");

            IWebElement Message = driver.FindElement(By.Name("message"));
            Message.SendKeys("Applying for the sick leave");
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}