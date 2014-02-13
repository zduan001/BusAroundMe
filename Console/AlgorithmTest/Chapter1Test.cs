using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsChapter1;
using System.Collections.Generic;
using System.IO;

namespace AlgorithmTest
{
    [TestClass]
    public class Chapter1Test
    {
        [TestMethod]
        public void Test_1_1_9_PrintBinary()
        {
            _1_1_9_PrintBinary target = new _1_1_9_PrintBinary();
            string actual = target.PrintOutBinary(3);
            Assert.AreEqual("11", actual);

            actual = target.PrintOutBinary(23);
            Assert.AreEqual("10111", actual);
        }

        [TestMethod]
        public void Test_1_1_12_Theresult()
        {
            _1_1_12_Theresult target = new _1_1_12_Theresult();
            string actual = target.WhatisTheResult();
            Assert.AreEqual("0, 1, 2, 3, 4, 4, 3, 2, 1, 0, ", actual);
        }

        [TestMethod]
        public void Test_1_1_14_Lg()
        {
            _1_1_14_Lg target = new _1_1_14_Lg();
            int actual;
            actual = target.FindLg(3);
            Assert.AreEqual(1, actual);

            actual = target.FindLg(4);
            Assert.AreEqual(2, actual);

            actual = target.FindLg(8);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Test_1_1_16_EXR1()
        {
            _1_1_16_EXR1 target = new _1_1_16_EXR1();
            string actual = target.exR1(6);
            Assert.AreEqual("311361142246", actual);
        }

        [TestMethod]
        public void Test_1_1_20_ln()
        {
            _1_1_20_ln target = new _1_1_20_ln();
            double actual = target.FindLnN(6, 0.0001);
        }

        [TestMethod]
        public void Test_1_1_21_FindGCD()
        {
            _1_1_21_FindGCD target = new _1_1_21_FindGCD();
            string res = string.Empty;
            int actual = target.FindGCDEuclid(105, 24, ref res);
            Assert.AreEqual("p = 105, q = 24p = 24, q = 9p = 9, q = 6p = 6, q = 3p = 3, q = 0", res);
            Assert.AreEqual(3, actual);

            res = string.Empty;
            actual = target.FindGCDEuclid(1111111, 1234567, ref res);
        }

        [TestMethod]
        public void Test_1_1_27_BinomialDistribution()
        {
            _1_1_27_BinomialDistribution target = new _1_1_27_BinomialDistribution();
            long count = 0;
            // Comment out the following code, it take tooo long to run.
           // double actual = target.Binomial(100, 50, 0.25, ref count);

        }

        [TestMethod]
        public void Test_1_1_27_BinomialDistributionDP()
        {
            _1_1_27_BinomialDistribution target = new _1_1_27_BinomialDistribution();
            long count = 0;
            double actual = target.BinomialDP(100, 50, 0.25);

        }

        [TestMethod]
        public void Test_1_1_28_RemoveDup()
        {
            _1_1_28_RemoveDup target = new _1_1_28_RemoveDup();
            int actual;
            int[] input = { 1, 2, 2, 2, 2, 2, 3, 5, 5 };
            actual = target.RemoveDup(input);
            Assert.AreEqual(3, actual);

            int[] input2 = { 2, 2 };
            actual = target.RemoveDup(input2);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_1_1_29_FindEqualKey()
        {
            _1_1_29_FindEqualKey target = new _1_1_29_FindEqualKey();
            int[] input = { 1, 2, 2, 2, 2, 2, 3, 5, 5 };
            int startIndex = -1;
            int length = -1;
            target.FindStartAndLength(input, 2, ref startIndex, ref length);
            Assert.AreEqual(1, startIndex);
            Assert.AreEqual(5, length);


            target.FindStartAndLength(input, 5, ref startIndex, ref length);
            Assert.AreEqual(7, startIndex);
            Assert.AreEqual(2, length);

        }

        [TestMethod]
        public void Test_1_1_35_DiceSimulation()
        {
            _1_1_35_DiceSimulation target = new _1_1_35_DiceSimulation();
            double[] dist = target.DiceProb();
            double[] testres = target.TestDic();
        }

        [TestMethod]
        public void Test_1_1_36_Shffle()
        {
            _1_1_36_Shuffle target = new _1_1_36_Shuffle();
            int[] input = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18 };
            int[,] actual = target.VerifyShaffle(input);
        }

        [TestMethod]
        public void Test_1_2_1_Point2d()
        {
            _1_2_1_Point2d target = new _1_2_1_Point2d();
            double actual = target.FindMinDistinc(10);
        }

        [TestMethod]
        public void Test_1_2_2_Interval1D()
        {
            _1_2_2_Interval1D target = new _1_2_2_Interval1D();
            List<KeyValuePair<Interval1D, Interval1D>> actual = target.FindIntervalOverlaps(100);
        }

        [TestMethod]
        public void Test_1_2_6_CircularShift()
        {
            _1_1_6_CircularShift target = new _1_1_6_CircularShift();
            string s1 = "abcdefg";
            string s2 = "cdefgbab";
            int actual = target.VerifyStringShift(s1, s2);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Test_1_2_7_MysteryMethod()
        {
            _1_2_7_MysteryMethod target = new _1_2_7_MysteryMethod();
            string s = "0123456789";
            string actual = target.mystery(s);
            Assert.AreEqual("9876543210", actual);
        }

        [TestMethod]
        public void Test_1_3_10_InfixToPostfix()
        {
            _1_3_10_InfixToPostfix target = new _1_3_10_InfixToPostfix();
            string infix = "1-2*3-6+4-8";
            string actual = target.InfixToPostFix(infix);
            Assert.AreEqual("123*-6-4+8-", actual);

            infix = "1+2*3-5";
            actual = target.InfixToPostFix(infix);
            Assert.AreEqual("123*+5-", actual);
        }

        [TestMethod]
        public void Test_1_3_11_EvaluatePostFix()
        {
            _1_3_11_EvaluatePostFix target = new _1_3_11_EvaluatePostFix();
            _1_3_10_InfixToPostfix converter = new _1_3_10_InfixToPostfix();
            string infix = "1+2*3-5";
            string actual = converter.InfixToPostFix(infix);
            int res = target.EvaluatePostFix(actual);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void Test_1_3_32_Steque()
        {
            _1_3_32_Steque target = new _1_3_32_Steque();
            target.Push(1);
            target.Push(2);
            target.Push(3);
            target.Enqueue(4);
            Assert.AreEqual(3, target.Pop());
            Assert.AreEqual(2, target.Pop());
            Assert.AreEqual(1, target.Pop());
            Assert.AreEqual(4, target.Pop());
        }

        [TestMethod]
        public void Test_1_3_42_CopyStack()
        {
            _1_3_12_CopyStack target = new _1_3_12_CopyStack();
            Stack<int> input = new Stack<int>();
            input.Push(1);
            input.Push(2);
            input.Push(3); 
            input.Push(4);
            input.Push(5);
            input.Push(6);
            Stack<int> actual = target.Copy(input);
            while (actual.Count != 0)
            {
                Assert.AreEqual(input.Pop(), actual.Pop());
            }

        }

        [TestMethod]
        public void Test_1_3_41_CopyQueue()
        {
            _1_3_41_CopyQueue target = new _1_3_41_CopyQueue();
            Queue<int> input = new Queue<int>();
            input.Enqueue(1);
            input.Enqueue(2);
            input.Enqueue(3);
            input.Enqueue(4);
            input.Enqueue(5);
            input.Enqueue(6);
            input.Enqueue(7);
            input.Enqueue(8);
            Queue<int> actual = target.Copy(ref input);
            while (actual.Count != 0)
            {
                Assert.AreEqual(input.Dequeue(), actual.Dequeue());
            }
        }


        [TestMethod]
        public void Test_1_5_1_UnionFinderSmall()
        {
            _1_5_1_UnionFinder target = new _1_5_1_UnionFinder(6);
            target.Union(1, 3);
            target.Union(2, 5);
            target.Union(1, 2);

            Assert.IsTrue(target.IsConnectioned(3, 5));

        }

        [TestMethod]
        public void Test_1_5_1_UnionFinder()
        {
            //StreamReader reader = new StreamReader(@"..\..\..\Console2\G_Code\TextFile1.txt");
            StreamReader fs = new StreamReader(@"..\..\..\AlgorithmTest\ufMedium.txt");
            int count = int.Parse(fs.ReadLine());
            _1_5_1_UnionFinder target = new _1_5_1_UnionFinder(count);
            string input;
            while (true)
            {
                input = fs.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                string[] array = input.Split(' ');
                int i = int.Parse(array[0]);
                int j = int.Parse(array[1]);
                target.Union(i, j);
            }

            Assert.IsTrue(target.IsConnectioned(438,464));
            
        }

        [TestMethod]
        public void Test_1_5_1_UnionFinderPathCompress()
        {
            //StreamReader reader = new StreamReader(@"..\..\..\Console2\G_Code\TextFile1.txt");
            StreamReader fs = new StreamReader(@"..\..\..\AlgorithmTest\ufMedium.txt");
            int count = int.Parse(fs.ReadLine());
            _1_5_1_UnionFinder target = new _1_5_1_UnionFinder(count);
            string input;
            while (true)
            {
                input = fs.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                string[] array = input.Split(' ');
                int i = int.Parse(array[0]);
                int j = int.Parse(array[1]);
                target.UnionWithCompress(i, j);
            }

            Assert.IsTrue(target.IsConnectioned(438, 464));

        }

        [TestMethod]
        public void Test_1_5_1_UnionFinderPathCompressLarge()
        {
            //StreamReader reader = new StreamReader(@"..\..\..\Console2\G_Code\TextFile1.txt");
            StreamReader fs = new StreamReader(@"..\..\..\AlgorithmTest\ufLarge.txt");
            int count = int.Parse(fs.ReadLine());
            _1_5_1_UnionFinder target = new _1_5_1_UnionFinder(count);
            string input;
            while (true)
            {
                input = fs.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                string[] array = input.Split(' ');
                int i = int.Parse(array[0]);
                int j = int.Parse(array[1]);
                target.UnionWithCompress(i, j);
            }

            Assert.IsTrue(target.IsConnectioned(51236, 755300));

        }

    }
}
