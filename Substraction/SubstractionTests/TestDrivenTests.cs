using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
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
        //create obj of class, where operation is written
        TestDriven MyObj = new TestDriven();

        [TestMethod()]
        public void SubTest()
        {
            //inside parenthesis (ans,obj name.method name(parameters));
            Assert.AreEqual(6,MyObj.Sub(12,6));
        }
    }
}