using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MicrosoftQuestions;
using System.Collections.Generic;

namespace MIcrosoftQuestionTest
{
    [TestClass]
    public class MIrcosoftQuestionTest
    {
        [TestMethod]
        public void Test_MSFT_001_FindLongestSubString()
        {
            _001_LongestSubString target = new _001_LongestSubString();
            string input = "abcabcaacb";
            string expect = "abca";

            string actual;
            actual = target.FindLongestSubString(input);
            Assert.AreEqual(expect, actual);

            input = "aababa";
            expect = "aba";
            actual = target.FindLongestSubString(input);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Test_MSFT_002_StringEditDistance()
        {
            _002_StringEditDistance target = new _002_StringEditDistance();
            string s1 = "exponential";
            string s2 = "polynomial";
            int expect = 6;
            int actual = target.FindEditDistance(s1, s2);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Test_003_SeparateArray()
        {
            _003_SeparateArray target = new _003_SeparateArray();
            int[] input = { -5, 2, -3, 4, -8, -9, 1, 3, -10 };
            target.SeparateArray(input);
            Assert.AreEqual(-10, input[4]);
        }

        [TestMethod]
        public void Test_004_BoltsAndNuts()
        {
            _004_BoltsAndNuts target = new _004_BoltsAndNuts();
            Bolt[] bolts = new Bolt[] {
                new Bolt() {value = 4},
                new Bolt() {value = 5},
                new Bolt() {value = 8},
                new Bolt() {value = 0},
                new Bolt() {value = 7},
                new Bolt() {value = 6},
                new Bolt() {value = 2},
                new Bolt() {value = 3},
                new Bolt() {value = 9},
                new Bolt() {value = 1}
            };

            Nut[] nuts = new Nut[]{
                new Nut() {value = 0},
                new Nut() {value = 6},
                new Nut() {value = 2},
                new Nut() {value = 9},
                new Nut() {value = 8},
                new Nut() {value = 5},
                new Nut() {value = 1},
                new Nut() {value = 7},
                new Nut() {value = 4},
                new Nut() {value = 3}
            };

            target.Match(bolts, nuts);

            for (int i = 0; i < nuts.Length; i++)
            {
                Assert.AreEqual(0, target.Compare(bolts[i], nuts[i]));
            }

        }

        [TestMethod]
        public void Test_005_MinGlasses()
        {
            _005_MinGlasses target = new _005_MinGlasses();
            List<Interval> input = new List<Interval>()
            {
                new Interval() { Start =1 , End =5},
                new Interval() { Start =3 , End =16},
                new Interval() { Start =2 , End =11},
                new Interval() { Start =4 , End =10},
                new Interval() { Start =6 , End =12},
                new Interval() { Start =7 , End =13},
                new Interval() { Start =8 , End =14},
                new Interval() { Start =9 , End =15}
            };

            int actual = target.FindMinGlasses(input);
        }

    }
}
