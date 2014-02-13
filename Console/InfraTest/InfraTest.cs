using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infra;
using console;

namespace InfraTest
{
    [TestClass]
    public class InfraTest
    {
        [TestMethod]
        public void Test_PrintOutLevelZigZag()
        {
            _008_ConverToBinaryTree target = new _008_ConverToBinaryTree(); 
            TreeNode actual;
            int[] input;

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // TODO: Initialize to an appropriate value
            actual = target.ConvertSortArraytoBalancedBST(input);

            TreeNode.PrintOutLevelZigZag(actual);


        }

        [TestMethod]
        public void Test_PrintOutLevelZigZagII()
        {
            _008_ConverToBinaryTree target = new _008_ConverToBinaryTree();
            TreeNode actual;
            int[] input;

            input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // TODO: Initialize to an appropriate value
            actual = target.ConvertSortArraytoBalancedBST(input);

            TreeNode.PrintOutLevelZigzagII(actual);
            
        }
    }
}
