using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgTest
{
    [TestClass]
    public class BitOpTest
    {
        [TestMethod]
        public void TestFindDup()
        {
            int[] input = new int[] { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9 };
            BitWise.BitWise target = new BitWise.BitWise();
            int actual = target.FindDup(input);
            Assert.AreEqual(3, actual);

            input[3] = 6;
            actual = target.FindDup(input);
            Assert.AreEqual(6, actual);
        }


        [TestMethod]
        public void TestSwapOddEven()
        {
            uint input = 23;
            BitWise.BitWise target = new BitWise.BitWise();
            uint actual = target.SwapOddEven(input);
            Assert.AreEqual(43u, actual);
        }
    }
}
