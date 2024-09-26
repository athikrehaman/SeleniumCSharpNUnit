using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParUsingTestSource
    {

        [Test, TestCaseSource("GetTestData")]
        public void LoginTest(String username, String password)
        {
            Console.WriteLine(username + " : " + password);
            
        }

        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData("agd", "ain123");
            yield return new TestCaseData("dsgu", "aidiuwo");
            yield return new TestCaseData("dhjj", "ajiui");
        }
    }
}
