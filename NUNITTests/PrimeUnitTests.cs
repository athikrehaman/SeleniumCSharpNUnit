using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class PrimeUnitTests
    {
        PrimeNumber pn = new PrimeNumber();

        [Test]
        public void PrimeTest()
        {
            bool result = pn.IsPrime(10);
            Assert.AreEqual(true,result);
        }
    }
}
