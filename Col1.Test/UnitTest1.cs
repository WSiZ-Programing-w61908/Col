using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Col1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool value = true;

            Assert.IsTrue(value);
        }
    }
}
