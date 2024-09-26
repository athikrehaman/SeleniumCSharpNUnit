using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{

    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {
        [Test]
        public void login()
        {
            Console.WriteLine("Logging to the application");

        }

        [Test]
        public void products()
        {
            Console.WriteLine("Selecting the products");

        }

        [Test]
        public void addtocart()
        {
            Console.WriteLine("Products add to cart");

        }
    }
}
