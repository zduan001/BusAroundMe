using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaceBookQuestions;
using Infra;
using System.Collections.Generic;

namespace FacebookQuestionTest
{
    [TestClass]
    public class FacebookQuestionTest
    {
        [TestMethod]
        public void Test_001_CloestMNodes()
        {
            _001_CloestMNodes target = new _001_CloestMNodes();
            TreeNode root = TreeNode.CreatTree(new string[] { "4", "2", "1", "#", "#", "3", "#", "#", "8", "6", "#", "#", "10", "#", "#" });
            List<TreeNode> actual = target.FindClosestNodes(root, 3, 5);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(3, actual[0].Value);
            Assert.AreEqual(4, actual[1].Value);
            Assert.AreEqual(6, actual[2].Value);
        }

        [TestMethod]
        public void Test_007_hanoi()
        {
            _007_hanoi target = new _007_hanoi();
            int n = 2;
            int k = 3;
            int[] initial = { 0, 0 };
            int[] final = { 1, 1 };
            List<Move> actual = target.SolveNanojShortestPath(n, k, initial, final);

        }

        [TestMethod]
        public void Test_007_hanoiII()
        {
            _007_hanoi target = new _007_hanoi();
            int n = 6;
            int k = 4;
            int[] initial = { 3, 1, 3, 2, 0, 0 };
            int[] final = { 0, 0, 0, 0, 0, 0 };
            List<Move> actual = target.SolveNanojShortestPath(n, k, initial, final);
        }

        [TestMethod]
        public void test_008_Parser()
        {
            _008_Function target = new _008_Function();
            string s = "x+9-2-4+x=-x+5-1+3-x";
            double actual = target.solveForX(s);
            Assert.AreEqual(1.0, actual);

            s = "x+9-1=0";
            actual = target.solveForX(s);
            Assert.AreEqual(-8.0, actual);
        }

        [TestMethod]
        public void test_009_FindMaxSubSet()
        {
            FaceBookQuestions.FaceBookQuestions target = new FaceBookQuestions.FaceBookQuestions();
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            List<List<int>> actual = target._009_FindMaxSubSet(input, 7);
        }
    }
}
