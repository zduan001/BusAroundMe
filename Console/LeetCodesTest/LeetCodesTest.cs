using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodes;
using System.Collections.Generic;

namespace LeetCodesTest
{
    [TestClass]
    public class LeetCodesTest
    {
        [TestMethod]
        public void Test_001_PalindromePartitioning()
        {
            _001_PalindromePartitioning target = new _001_PalindromePartitioning();
            List<List<string>> actual = new List<List<string>>();
            List<string> tmp = new List<string>();
            target.PartitionString("aab", tmp, ref actual);
            Assert.AreEqual(2, actual.Count);

            actual = new List<List<string>>();
            tmp = new List<string>();
            target.PartitionString("abbab", tmp, ref actual);
            Assert.AreEqual(4, actual.Count);
        }

        [TestMethod]
        public void Test_002_SlideWindows()
        {
            _002_SlideWindows target = new _002_SlideWindows();
            int[] input = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int[] actual = target.FindSlideWindowsMax(input, 3);
            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(3, actual[1]);
            Assert.AreEqual(5, actual[2]);
            Assert.AreEqual(5, actual[3]);
            Assert.AreEqual(6, actual[4]);
            Assert.AreEqual(7, actual[5]);

        }

        [TestMethod]
        public void Test_002_SlideWindowsII()
        {
            _002_SlideWindows target = new _002_SlideWindows();
            int[] input = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int[] actual = target.FindSlideWindowsMaxII(input, 3);
            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(3, actual[1]);
            Assert.AreEqual(5, actual[2]);
            Assert.AreEqual(5, actual[3]);
            Assert.AreEqual(6, actual[4]);
            Assert.AreEqual(7, actual[5]);

        }

        [TestMethod]
        public void Test_004_RegularExpression()
        {
            _004_RegularExpression target = new _004_RegularExpression();
            Assert.IsFalse(target.Match("aa", "a"));

            Assert.IsTrue(target.Match("abbbc", "ab*c"));
            Assert.IsTrue(target.Match("ac", "ab*c"));
            Assert.IsTrue(target.Match("aa", "a*"));
            Assert.IsTrue(target.Match("aa", ".*"));
            Assert.IsTrue(target.Match("abbc", "ab*bbc"));
            Assert.IsTrue(target.Match("aab", "c*a*b"));
        }

        [TestMethod]
        public void Test_005_DivideWithOutDivide()
        {
            _005_DivideWithOutDivide target = new _005_DivideWithOutDivide();
            int actual = target.Divide(8, 4);
            Assert.AreEqual(2, actual);

            actual = target.Divide(7, 4);
            Assert.AreEqual(1, actual);

            actual = target.Divide(132, 6);
            Assert.AreEqual(22, actual);

            actual = target.Divide(132, 7);
            Assert.AreEqual(18, actual);
        }

        [TestMethod]
        public void Test_006_PainterPartition()
        {
            _006_PainterPartition target = new _006_PainterPartition();
            int[] input = { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
            int actual = target.PaintersProblem(input, 3);
            Assert.AreEqual(1700, actual);
        }

        [TestMethod]
        public void Test_007_CoinsInaLine()
        {
            _007_CoinsInaLine target = new _007_CoinsInaLine();
            int[] input = { 3, 2, 2, 3, 1, 2 };
            int actual = target.CoinsInaLine(input);
            Assert.AreEqual(8, actual);

            input = new int[] { 1, 2, 5, 3 };
            actual = target.CoinsInaLine(input);
            Assert.AreEqual(6, actual);
        }
    }
}
