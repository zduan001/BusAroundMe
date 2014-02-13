using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;

namespace LeetCodeCsharpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            _003_LongestConsectiveSequence target = new _003_LongestConsectiveSequence();
            int[] input = new int[] { 100, 4, 200, 1, 3, 2 };
            int actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(4, actual);

            input = new int[] { 10, 21, 45, 22, 7, 2, 67, 19, 13, 45, 12, 11, 18, 16, 17, 100, 201, 20, 101 };
            actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(7, actual);

            input = new int[] { 1, 3, 5, 7 };
            actual = target.FindLongestConsectiveSequence(input);
            Assert.AreEqual(1, actual);
        }
    }
}
