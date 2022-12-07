using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tests
{
    [TestClass()]
    public class TestDrivenTests
    {
        TestDriven testdriven = new TestDriven();

        [TestMethod()]
        public void ProductTest()
        {
            Assert.AreEqual(25, testdriven.Product(5, 5));
        }
    }
}