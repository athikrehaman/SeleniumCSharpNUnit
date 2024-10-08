﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParamExcel : Base 
    {
        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(String username, String password)
        {
            Thread.Sleep(3000);

            // Find the element usibg the By class locators 
            IWebElement Username = driver.FindElement(By.Name("username"));
            // inputing text using send keys 
            Username.SendKeys(username);


            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            // inputing text using send keys 
            Password.SendKeys(password);


            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(1000);

            IWebElement Errmsg = driver.FindElement(By.XPath("//div[@class='oxd-alert-content oxd-alert-content--error']"));

            string errmsg = Errmsg.Text;

            Console.WriteLine(errmsg);

            Assert.AreEqual("Invalid credentials", errmsg);

        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            var columns = new List<string> { "username", "password" };

            return ExcelRead.GetTestDataFromExcel("C:\\Users\\atreh\\source\\repos\\NUnitSeleniumC#Training\\testdata.xlsx", "LoginTest", columns);
        }
    }
}
