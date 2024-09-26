using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTesting
    {
        Calculator cl = new Calculator();

        [SetUp]
        public void setup()
        {
            Console.WriteLine("This is the setup");
        }

        [Test]
        public void AddTest()
        {
            int result = cl.Add(2,3);
            int result1 = cl.Add(3, -4);

            //Assertion NUnit to compare the results with actual result
            Assert.AreEqual(5, result);
            Assert.AreEqual(-1, result1);
        }

        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("This is the TearDown");
        }
    }
}
