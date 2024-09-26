using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Frames2
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Keydown()
        {
            Thread.Sleep(2000);
            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@id='mce_0_ifr']"));

            //Selecting frame using XPath
            //driver.SwitchTo().Frame(Frame1);

            //Selecting frame using Index
            driver.SwitchTo().Frame(0);

            //Selecting frame using name
            //driver.SwitchTo().Frame("Frameone");

            //Click on the radio button NY
            IWebElement textarea = driver.FindElement(By.Id("tinymce"));
            textarea.Clear();

            Thread.Sleep(3000);

            textarea.SendKeys("Hello");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}
