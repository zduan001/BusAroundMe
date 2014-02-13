using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmazonQuestion.cs;
using Infra;

namespace AmazonQuestionTest
{
    [TestClass]
    public class AmazonQuestionTest
    {
        [TestMethod]
        public void Test_003_RebuildTree()
        {
            _003_RebuildTree target = new _003_RebuildTree();
            int[] pre = { 7, 10, 4, 3, 1, 2, 8, 11 };
            int[] inOrder = { 4, 10, 3, 1, 7, 11, 8, 2 };

            TreeNode actual = target.RebuildTree(pre, 0, 7, inOrder, 0, 7);

        }
    }
}
