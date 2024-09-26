using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class SetUpTearDown
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Launching Chrome Browser");
        }

        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("Closing the Chrome Browser");
        }

        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logging to the application");

        }

        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("Selecting the products");

        }

        [Test, Order(3)]
        public void addtocart()
        {
            Console.WriteLine("Products add to cart");

        }
    }
}
