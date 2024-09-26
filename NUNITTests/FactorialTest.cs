using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class FactorialTest
    {
        FactorialNumber ftn = new FactorialNumber();

        [Test]
        public void FactTest()
        {
            int result = ftn.Factorial(2);
            Assert.AreEqual(2, result);
        }
    }
}
