using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    [SetUpFixture]
    internal class OneTimeSetupTeardown
    {
        [OneTimeSetUp]
        public void dbconnecttionopen()
        {
            TestContext.Progress.WriteLine("Openeing the DB Connection");
        }

        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            TestContext.Progress.WriteLine("Closing the DB Connection");
        }
    }
}
