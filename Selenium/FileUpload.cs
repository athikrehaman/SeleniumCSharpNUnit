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
    internal class FileUpload
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            IWebElement ChooseFile = driver.FindElement(By.XPath("//input[@id='file-upload']"));
            ChooseFile.SendKeys("\"C:\\Users\\atreh\\Downloads\\QRCode for Rate Yourself on Tech Stack Proficiency.png\"");

            
            IWebElement Upload = driver.FindElement(By.XPath("//input[@id='file-submit']"));
            Upload.Click();

            Thread.Sleep(1000);


            IWebElement FileUploadmsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Uploaded!')]"));

            String textmsg = FileUploadmsg.Text;
            String expectedtext = "File Uploaded!";
            Console.WriteLine(textmsg);

            Assert.AreEqual(expectedtext, textmsg);

        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}