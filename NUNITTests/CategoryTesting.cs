using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CategoryTesting
    {
   
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logging to the application");

        }

        [Test, Category("Sanity")]
        public void products()
        {
            Console.WriteLine("Selecting the products");

        }

        [Test, Ignore("Defect Detected")]
        public void addtocart()
        {
            Console.WriteLine("Products add to cart");

        }
    }
}
