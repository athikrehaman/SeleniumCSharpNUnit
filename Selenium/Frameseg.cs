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
    internal class Frameseg
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
            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Keydown()
        {
            IWebElement Frame1 = driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            //Selecting frame using XPath
            //driver.SwitchTo().Frame(Frame1);

            //Selecting frame using Index
            driver.SwitchTo().Frame(0);

            //Selecting frame using name
            //driver.SwitchTo().Frame("Frameone");

            //Click on the radio button NY
            IWebElement radiobutton = driver.FindElement(By.XPath("(//span[@class='ui-checkboxradio-icon ui-corner-all ui-icon ui-icon-background ui-icon-blank'])[1]"));
            radiobutton.Click();
            Thread.Sleep(3000);
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
