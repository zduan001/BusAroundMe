using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideAndConque;

namespace AlgTest
{
    [TestClass]
    public class DivConqueTest
    {
        [TestMethod]
        public void TestPow()
        {
            Pow target = new Pow();
            double actual = target.pow(2, 3);
            Assert.AreEqual(8.0, actual);

        }

        [TestMethod]
        public void TestMedianOf2Array()
        {
            MedianOf2Array target = new MedianOf2Array();
            int[] a = new int[] { 1, 3, 5, 7, 9 };
            int[] b = new int[] { 2, 4, 6, 8, 10 };
            int actual = target.FindMedian(a, b);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestTopKElement()
        {
            TopKElement target = new TopKElement();
            int[] input = new[] { 1,9,3,10,2,6,5,8,7,4};
            target.FindTopK(input, 3);
            Assert.IsTrue(input[0] > 7);
            Assert.IsTrue(input[1] > 7);
            Assert.IsTrue(input[2] > 7);


            input = new[] { 1, 9, 3, 10, 2, 6, 5, 8, 7, 4 };
            target.FindTopK(input, 4);
            Assert.IsTrue(input[0] > 6);
            Assert.IsTrue(input[1] > 6);
            Assert.IsTrue(input[2] > 6);
            Assert.IsTrue(input[3] > 6);

        }
    }
}
