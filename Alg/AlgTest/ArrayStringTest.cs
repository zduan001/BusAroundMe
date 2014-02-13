using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayString;

namespace AlgTest
{
    [TestClass]
    public class ArrayStringTest
    {
        [TestMethod]
        public void TestFindMaxRectangleInAHistgram()
        {
            int[] input = null;
            LartestRectangle target = new LartestRectangle();
            int actual;

            actual = target.FindMaxRectangleInAHistgram(input);
            Assert.AreEqual(-1, actual);

            input = new int[0];
            Assert.AreEqual(-1, actual);

            input = new int[] { 2, 1, 5, 6, 2, 3 };
            actual = target.FindMaxRectangleInAHistgram(input);
            Assert.AreEqual(10, actual);

            input = new int[] {1,3,5,7,4};
            actual = target.FindMaxRectangleInAHistgram(input);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void TestFindMaxRectangleInAHistgramII()
        {
            int[] input = null;
            LartestRectangle target = new LartestRectangle();
            int actual;

            actual = target.FindMaxRectangleInAHistgramII(input);
            Assert.AreEqual(-1, actual);

            input = new int[0];
            Assert.AreEqual(-1, actual);

            input = new int[] { 2, 1, 5, 6, 2, 3 };
            actual = target.FindMaxRectangleInAHistgramII(input);
            Assert.AreEqual(10, actual);

            input = new int[] { 1, 3, 5, 7, 4 };
            actual = target.FindMaxRectangleInAHistgramII(input);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void TestCalculator()
        {
            ProcessEquation target = new ProcessEquation();
            string input = "1*25+24/2/4";
            int actual = target.Calculator(input);
            Assert.AreEqual(28, actual);

            input = "24*3*2-2-6-4-23*2";
            actual = target.Calculator(input);
            Assert.AreEqual(86, actual);
        }

        [TestMethod]
        public void TestCheckInterLeave()
        {
            CheckInterLeave target = new CheckInterLeave();
            string s1 = "aabcc";
            string s2 = "dbbca";
            string s3 = "aadbbcbcac";
            bool actual = target.IsInterLeave(s1, s2, s3, string.Empty);
            Assert.IsTrue(actual);

            s3 = "aadbbbaccc";
            actual = target.IsInterLeave(s1, s2, s3, string.Empty);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestCheckInterLeaveII()
        {
            CheckInterLeave target = new CheckInterLeave();
            string s1 = "aabcc";
            string s2 = "dbbca";
            string s3 = "aadbbcbcac";
            bool actual = target.IsInterLeave(s1, s2, s3);
            Assert.IsTrue(actual);

            s3 = "aadbbbaccc";
            actual = target.IsInterLeave(s1, s2, s3);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestLongestRepeat()
        {
            FindlongestrepeatChars target = new FindlongestrepeatChars();
            string input = "this is a sentence";
            string actual = target.LongestRepeat(input);
            Assert.AreEqual("thisisasentence", actual);

            input = "thiis iss a senntencee";
            actual = target.LongestRepeat(input);
            Assert.AreEqual("isne", actual);

            input = "thiisss iss a senntttenceee";
            actual = target.LongestRepeat(input);
            Assert.AreEqual("ste", actual);

            input = "thiisss iss a sennnntttenceee";
            actual = target.LongestRepeat(input);
            Assert.AreEqual("n", actual);
        }
    }
}
