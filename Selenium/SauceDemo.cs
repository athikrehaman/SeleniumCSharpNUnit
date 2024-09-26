using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
using System.Xml.Linq;

namespace NUnitSeleniumTraining.Selenium
{
    internal class SauceDemo
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void Run()
        {
            Thread.Sleep(2000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");
            Thread.Sleep(2000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(2000);

            IWebElement LoginButton = driver.FindElement(By.Name("login-button"));
            LoginButton.Click();
            Thread.Sleep(2000);

            IWebElement Product = driver.FindElement(By.LinkText("Sauce Labs Bolt T-Shirt"));
            Product.Click();
            Thread.Sleep(2000);

            IWebElement Addcart = driver.FindElement(By.Id("add-to-cart"));
            Addcart.Click(); Thread.Sleep(2000);

            IWebElement Cartitem = driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
            Cartitem.Click();
            Thread.Sleep(2000);

            IWebElement RemoveItem = driver.FindElement(By.Id("remove-sauce-labs-bolt-t-shirt"));
            RemoveItem.Click();
            Thread.Sleep(2000);

            IWebElement Checkout = driver.FindElement(By.Id("checkout"));
            Checkout.Click();
            Thread.Sleep(2000);

            IWebElement Fname = driver.FindElement(By.Id("first-name"));
            Fname.SendKeys("Athik");
            Thread.Sleep(2000);

            IWebElement Lname = driver.FindElement(By.Id("last-name"));
            Lname.SendKeys("Rehaman");
            Thread.Sleep(2000);

            IWebElement Postcode = driver.FindElement(By.Id("postal-code"));
            Postcode.SendKeys("570110");
            Thread.Sleep(2000);

            IWebElement Continue = driver.FindElement(By.Id("continue"));
            Continue.Click();
            Thread.Sleep(2000);

            IWebElement Finish = driver.FindElement(By.Id("finish"));
            Finish.Click();
            Thread.Sleep(2000);

            IWebElement Backhome = driver.FindElement(By.Id("back-to-products"));
            Backhome.Click();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void TearDownBrowser()
        {
            driver.Close();
        }
    }
}