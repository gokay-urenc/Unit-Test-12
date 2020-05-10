using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAttributes.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Coach")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Who Updated", "Nick")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Coach")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Who Updated", "Nick")]
        [TestProperty("Who Updated_2", "Ellis")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Coach")]
        [TestCategory("Developer")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Nick")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Nick")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}