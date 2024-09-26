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
    internal class Clickhold
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
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement Primes = driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));
            IWebElement LatestMovies = driver.FindElement(By.XPath("//img[@id='multiasins-img-link']"));

            new Actions(driver).ClickAndHold(Primes).MoveToElement(Primes).MoveToElement(LatestMovies).Perform();
            Thread.Sleep(1000);

           // Assert.AreEqual("Prime", driver.FindElement(By.XPath("")));
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
