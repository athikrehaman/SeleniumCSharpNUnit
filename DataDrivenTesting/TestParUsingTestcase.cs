using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParUsingTestcase : Base
    {

        [TestCase("abc.com","sjhdu")]
        [TestCase("hhd.com", "vhhdu")]
        [TestCase("dju.com", "jhfdu")]

        public void LoginTest(String username, String password)
        {
            Console.WriteLine(username+" : "+password);
            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();

            Thread.Sleep(2000);
        }

    }
}
