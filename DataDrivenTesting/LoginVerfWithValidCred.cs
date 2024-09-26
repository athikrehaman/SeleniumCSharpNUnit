using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class LoginVerfWithValidCred : Base
    {

        [TestCase("agd", "ain123")]

        public void LoginTest(String username, String password)
        {
            //Console.WriteLine(username + " : " + password);
            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();

            Thread.Sleep(2000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert oxd-alert--error']"));

            String eemsg = Errmsg.Text;

            Console.WriteLine(eemsg);
            Assert.AreEqual("Invalid credentials", eemsg);
        }
    }
}
