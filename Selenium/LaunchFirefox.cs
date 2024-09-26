using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchFirefox
    {
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            FirefoxDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://bonigarcia.dev/webdrivermanager/#webdrivermanager-and-selenium-manager");


        }

        [Test]
        public void testcase1()
        {
            //driver.Navigate().GoToUrl("https://bonigarcia.dev/webdrivermanager/#webdrivermanager-and-selenium-manager");
        }

        [TearDown]
        public void teardownbrowser()
        {

        }
    }
}
