using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSeleniumC_Training.Utilities;

namespace NUnitSeleniumTraining.Selenium
{
    internal class Links : Base
    {
        
        [Test]
        public void Run()
        {
            Thread.Sleep(3000);

            //Single checkboxes
            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));

            foreach (IWebElement l in links)
            {
                Console.WriteLine(l.Text + " URL is " + l.GetAttribute("href"));

               // l.Click();
            }
        }

        
    }
}