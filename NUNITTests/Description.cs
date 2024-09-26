using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    //[Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test]
        [Description("Testcase provides Valid functionality")]
        public void testcase1()
        {
            Console.WriteLine("This is first Test case");
        }
    }
}
