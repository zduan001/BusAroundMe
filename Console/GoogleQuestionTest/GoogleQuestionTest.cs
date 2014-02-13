using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleQuestions;

namespace GoogleQuestionTest
{
    [TestClass]
    public class GoogleQuestionTest
    {
        [TestMethod]
        public void Test_001_SortString()
        {
            _001_SortString target = new _001_SortString();
            string s1 = "house";
            string s2 = "soup";
            char[] actual;
            actual = target.SortStringBaseOnString(s1, s2);
            Assert.AreEqual('s', actual[0]);
            Assert.AreEqual('o', actual[1]);
            Assert.AreEqual('u', actual[2]);
        }

        [TestMethod]
        public void Test_002_QualityDivide()
        {
            _002_QualityDivide target = new _002_QualityDivide();
            char[] input = { '1', '2', '3', '3', '2', '3' };
            string actual = target.FindBestDivdor(input);
        }

        [TestMethod]
        public void Test_003_MixArray()
        {
            _003_MixArray target = new _003_MixArray();
            int[] input = {1,3,5,7,9,11,2,4,6,8,10,12};
            target.MixArray(input);
            for (int i = 1; i < input.Length; i++)
            {
                Assert.AreEqual(1, input[i] - input[i - 1]);
            }
        }
        [TestMethod]
        public void Test_005_2DWater()
        {
            _005_2DWater target = new _005_2DWater();
            point[,] input = { {new point(){Height = 3}, new point(){Height = 3}, new point(){Height = 3}, new point(){Height = 3}},
                                 {new point(){Height = 3}, new point(){Height = 0}, new point(){Height = 0}, new point(){Height = 3}},
                                 {new point(){Height = 3}, new point(){Height = 1}, new point(){Height = 3}, new point(){Height = 3}},
                                 {new point(){Height = 3}, new point(){Height = 1}, new point(){Height = 3}, new point(){Height = 3}}};

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    input[i, j].i = i;
                    input[i, j].j = j;
                }
            }

            int actual = target.FindCapacity(input, 4);
        }

        [TestMethod]
        public void Test_006_PartitionArray()
        {
            PartitionArray target = new PartitionArray();
            int[] input = { 1, 4, 9, 16 };
            int actual = target.EquallyPartitionArray(input);
            Assert.AreEqual(4, actual);

            int[] input2 = { 1, 4, 7, 16 };
            actual = target.EquallyPartitionArray(input2);
            Assert.AreEqual(6, actual);

            int[] input3 = { 1, 4, 6, 7, 8, 16 };
            actual = target.EquallyPartitionArray(input3);
            Assert.AreEqual(0, actual);
        }
    }
}
