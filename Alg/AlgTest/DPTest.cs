using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DP;

namespace AlgTest
{
    [TestClass]
    public class DPTest
    {
        [TestMethod]
        public void TestEggDropping()
        {
            EggDropping target = new EggDropping();
            int actual = target.FindMinumumNumEggDropping(2, 10);
            Assert.AreEqual(4, actual);

            actual = target.FindMinumumNumEggDropping(2, 36);
            Assert.AreEqual(8, actual);

            actual = target.FindMinumumNumEggDropping(2, 100);
            Assert.AreEqual(14, actual);

            actual = target.FindMinumumNumEggDropping(2, 136);
            Assert.AreEqual(16, actual);
        }
    }
}
