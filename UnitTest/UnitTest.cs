using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace UnitTestssss
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator obj = new Calculator();

            Assert.AreEqual(20, obj.Add(10, 10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculator obj = new Calculator();

            Assert.AreEqual(10, obj.Sub(20, 10));

        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculator obj = new Calculator();

            Assert.AreEqual(100, obj.Mul(10, 10));

        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculator obj = new Calculator();

            Assert.AreEqual(10, obj.Div(100, 10));

        }


    }
}
