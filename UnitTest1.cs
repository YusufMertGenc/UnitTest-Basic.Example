using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BasicMath tm = new BasicMath();
            double result = tm.add(10, 10);
            Assert.AreEqual(result, 20);
        }
        [TestMethod]

        public void TestMethod2()
        {
            BasicMath tm = new BasicMath();
            double result = tm.subtract(10, 10);  
            Assert.AreEqual(result, 0);
        }
    }
}
