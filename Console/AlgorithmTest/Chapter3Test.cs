using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsChapter3;

namespace AlgorithmTest
{
    [TestClass]
    public class Chapter3Test
    {
        [TestMethod]
        public void Test_CreateBST()
        {
            int[] input = {1,2,3,4,5,6,7,8,9};
            _000_TreeMethods target = new _000_TreeMethods();
            TreeNodeWithCount root = target.CreateBST(input);

            int actual;
            actual = target.FindKthElement(root, 2);
            Assert.AreEqual(2, actual);

            actual = target.FindKthElement(root, 8);
            Assert.AreEqual(8, actual);

            actual = target.FindKthElement(root, -1);
            Assert.AreEqual(-1, actual);

            actual = target.FindKthElement(root, 100);
            Assert.AreEqual(-1, actual);

            actual = target.FindRank(root, 0);
            Assert.AreEqual(-1, actual);

            actual = target.FindRank(root, 1);
            Assert.AreEqual(1, actual);

            actual = target.FindRank(root, 4);
            Assert.AreEqual(4, actual);

            actual = target.FindRank(root, 8);
            Assert.AreEqual(8, actual);

            actual = target.FindRank(root, 100);
            Assert.AreEqual(-1, actual);

            target.Insert(root, 2);
            Assert.AreEqual(10, root.Count);
        }
    }
}
