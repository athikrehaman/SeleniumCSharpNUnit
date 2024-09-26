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
    internal class Alerts
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement Simplealert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Alert')]"));
            Simplealert.Click();

            //Switch the control to alert or the popup

            IAlert alt = driver.SwitchTo().Alert();
            
            //Click on OK button
            alt.Accept();

            //confirmational Alert
            IWebElement Confalert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Confirm')"));
            Confalert.Click();

            alt.Dismiss();

            IWebElement Promptalert = driver.FindElement(By.XPath("//button[contains(text(),'Click for JS Prompt')]"));
            Promptalert.Click();

            String alerttext = alt.Text;
            Console.WriteLine(alerttext);

            alt.SendKeys("Hello");
            Thread.Sleep(2000);
            alt.Accept();

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}