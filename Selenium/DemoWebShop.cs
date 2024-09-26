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
    internal class DemoWebShop
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
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(10000);

            IWebElement Firstname = driver.FindElement(By.Name("FirstName"));
            Firstname.SendKeys("Admin");

            IWebElement Lastname = driver.FindElement(By.Name("LastName"));
            Lastname.SendKeys("123");

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("admin@gmail.com");

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("admin123");

            IWebElement ConfirmPassword = driver.FindElement(By.Name("ConfirmPassword"));
            ConfirmPassword.SendKeys("admin123");

            IWebElement RegisterButton = driver.FindElement(By.Name("register-button"));
            RegisterButton.Click();
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}