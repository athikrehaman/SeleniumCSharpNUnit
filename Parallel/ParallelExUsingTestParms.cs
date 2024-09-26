using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.Parallel
{

    internal class ParallelExUsingTestParms : Base
    {
        [Parallelizable(ParallelScope.Children)]
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(string username, string password)
        {
            DateTime currentTime = DateTime.Now;
            string time = currentTime.ToString("yyyy-mm-dd");
            Console.WriteLine(username + " : " + password + "........." + currentTime);
            Thread.Sleep(2000);

            IWebElement UserName = driver.FindElement(By.Name("username"));
            UserName.SendKeys(username);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(password);

            IWebElement LoginButton = driver.FindElement(By.XPath("//Button[@type='submit']"));
            LoginButton.Click();

            Thread.Sleep(2000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.AreEqual("Invalid credentials", errmsg);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("agd", "ain123");
            yield return new TestCaseData("dsgu", "aidiuwo");
            yield return new TestCaseData("dhjj", "ajiui");
        }
    }
}
