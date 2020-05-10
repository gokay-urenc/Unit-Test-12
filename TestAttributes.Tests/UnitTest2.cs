using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        [Description("This is a square root test method.")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Timeout(1000)]
        public void TestMethod3()
        {
            Thread.Sleep(1500);
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}