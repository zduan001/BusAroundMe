using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;
using Infra;

namespace AlgTest
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void TestConvertBinaryTreeToDll()
        {
            ConvertBinaryTreeToDll target = new ConvertBinaryTreeToDll();
            TreeNode root = TreeNode.CreatTree(new string[] { "1", "#", "5", "#", "-7", "#", "#" });
            TreeNode actual = target.Convert(root);

            TreeNode.index = 0;
            root = TreeNode.CreatTree(new string[] { "4", "5", "-7", "#", "#", "#", "6", "#", "#" });
            actual = target.Convert(root);
            Assert.AreEqual(-7, actual.Value);
            Assert.AreEqual(5, actual.RightChild.Value);
            Assert.AreEqual(4, actual.RightChild.RightChild.Value);
            Assert.AreEqual(6, actual.RightChild.RightChild.RightChild.Value);
        }
    }
}
