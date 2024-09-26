using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Assertions
    {
        [Test]
        public void Testassertions()
        {
            String actual = "Google";
            String expected = "Yahoo";

            /*if(actual == expected)
            {
                Console.WriteLine("Matching");
            }
            else
            {
                Console.WriteLine("Not matching");
            }*/

            /*Assert.AreEqual(actual, expected);
            Assert.AreNotEqual(actual, expected);
            Assert.AreNotSame(actual, expected);*/

            //Assert That

            /*Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.Not.EqualTo(expected));*/

            //Assert for strings ignore case

            //Assert.That(actual, Is.EqualTo(expected).IgnoreCase);

            //Substring presence
            /*Assert.That(actual, Does.Contain("def").IgnoreCase);
            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);*/


            int[] array = new int[] { 1, 2, 3, 4, 5 };

            //Not Null
            //Assert.NotNull(array);

            //Greater Than
            //Assert.That(array, Is.All.GreaterThan(0));

            //Empty
            /*Assert.That(array, Is.Empty);
            Assert.That(array, Is.Not.Empty);
            Assert.That(array, Is.Ordered.Ascending);*/

            //Custom Assertion
            int age = 17;
            if(age <= 18)
            {
                throw new AssertionException("User is not Eligible");
            }
        }

    }
}
