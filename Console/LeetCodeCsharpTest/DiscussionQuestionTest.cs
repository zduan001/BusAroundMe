using System;
using Infra;
using LeetCodeCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeCsharpTest
{
    [TestClass]
    public class DiscussionQuestionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tag_BinaryTree target = new Tag_BinaryTree();

            //string inputstring = "3,1,5,#,#,#,2,5,#,#,5,#,#";
            string inputstring = "1,2,#,#,3,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.q_001_SumRootToLeaf(root);
            Assert.AreEqual(25, actual);

            inputstring = "3,1,5,#,#,#,2,5,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.q_001_SumRootToLeaf(root);
            Assert.AreEqual(965, actual);
        }

        [TestMethod]
        public void Test_Question2()
        {
            Tag_BinaryTree target = new Tag_BinaryTree();
            string inputstring = "1,2,#,#,3,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            Tuple<TreeNode, TreeNode> actual = target.q_002_ConvertTreetoDoubleLinkedList(root);

            Assert.AreEqual(2, actual.Item1.Value);
            Assert.AreEqual(3, actual.Item2.Value);

            inputstring = "3,1,5,#,#,#,2,5,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.q_002_ConvertTreetoDoubleLinkedList(root);

            Assert.AreEqual(5, actual.Item1.Value);
            Assert.AreEqual(1, actual.Item1.RightChild.Value);
            Assert.AreEqual(3, actual.Item1.RightChild.RightChild.Value);
            Assert.AreEqual(5, actual.Item2.Value);
        }

        [TestMethod]
        public void Test_Question3_PrintTreeByLevel()
        {
            Tag_BinaryTree target = new Tag_BinaryTree();
            string inputstring = "1,2,#,#,3,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<List<int>> actual = target.q_003_PrintTreeLevel(root, 2);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual(1, actual[0].Count);
            Assert.AreEqual(2, actual[1].Count);

            inputstring = "3,1,5,#,#,#,2,5,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.q_003_PrintTreeLevel(root, 3);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(1, actual[0].Count);
            Assert.AreEqual(2, actual[1].Count);
            Assert.AreEqual(3, actual[2].Count);
        }

        [TestMethod]
        public void Test_Question4_DeserializeBST()
        {
            Tag_BinaryTree target = new Tag_BinaryTree();
            int[] input = new int[] { 30, 20, 10, 40, 35, 50 };
            TreeNode actual = target.q_004_DeserializeBST(input, 0, input.Length - 1);
            Assert.AreEqual(30, actual.Value);
            Assert.AreEqual(20, actual.LeftChild.Value);
            Assert.AreEqual(10, actual.LeftChild.LeftChild.Value);
            Assert.AreEqual(40, actual.RightChild.Value);
            Assert.AreEqual(35, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(50, actual.RightChild.RightChild.Value);
        }

        [TestMethod]
        public void Test_Question5_SumPath()
        {
            Tag_BinaryTree target = new Tag_BinaryTree();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool actual = target.q_005_PathSum(root, 10);
            Assert.IsTrue(actual);

            actual = target.q_005_PathSum(root, 8);
            Assert.IsFalse(actual);

            actual = target.q_005_PathSum(root, 9);
            Assert.IsTrue(actual);

            actual = target.q_005_PathSum(root, 6);
            Assert.IsTrue(actual);

            actual = target.q_005_PathSum(root, 5);
            Assert.IsTrue(actual);
        }
    }

    [TestClass]
    public class OjQuestionTest
    {
        [TestMethod]
        public void Test_01_mergesortedlist()
        {
            Oj target = new Oj();
            LinkListNode l1 = LinkListNode.CreateLinkList(new int[] { 1, 3, 5, 7 });
            LinkListNode l2 = LinkListNode.CreateLinkList(new int[] { 0, 2, 4, 6, 8, 9, 10 });
            LinkListNode actual = target.p_001_Merge2SortedList(l1, l2);
            while (actual.Next != null)
            {
                Assert.AreEqual(1, actual.Next.Value - actual.Value);
                actual = actual.Next;
            }
        }

        [TestMethod]
        public void Test_02_ValidParenthese()
        {
            Oj target = new Oj();
            string input = "(((afdasf(sdfsf{{sadf}})dsf)[[sdfsdf]]))";
            bool actual = target.p_002_ValidateParentheses(input);
            Assert.IsTrue(actual);

            input = "(((afdasf(sdfsf{{sadf}})dsf)[[sdfsdf]]))((";
            actual = target.p_002_ValidateParentheses(input);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_03_AllAnagrams()
        {
            Oj target = new Oj();
            string input = "123";
            List<string> actual = target.p_003_anagrams(input);
            Assert.AreEqual(6, actual.Count);

            input = "123456";
            actual = target.p_003_anagrams(input);
            Assert.AreEqual(720, actual.Count);
        }

        [TestMethod()]
        public void Test_p_04_DecodeWaysTest()
        {
            Oj target = new Oj();
            string input;
            int expected;
            int actual;


            input = "226";
            expected = 3;
            actual = target.p_004_DecodeWay(input);
            Assert.AreEqual(expected, actual);


            input = "4854154937399897379975613984238125355884258369243193936685559588342434968134474812375281371442336859";
            expected = 18432;
            actual = target.p_004_DecodeWay(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Test_p_05_longestcommonprefix()
        {
            Oj target = new Oj();
            string[] input = new string[] { "abcdefghi", "abcdeflsdkjflsdfj", "lasdfjlaskjfaslfd", "lkjljiujnbkhasdfasf" };
            string actual = target.p_005_FindLongestCommonPrefix(input);
            Assert.AreEqual("abcdef", actual);
        }

        [TestMethod()]
        public void Test_p_06_BuildBalancedTreeFromlinkedlist()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            TreeNode actual = target.p_005_CreateTreeFromList(node);
            Assert.AreEqual(5, actual.Value);

            node = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
            actual = target.p_005_CreateTreeFromList(node);
            Assert.AreEqual(6, actual.Value);
        }

        [TestMethod]
        public void Test_p_07_RemoveDup()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 2, 2, 5, 6, 6, 9, 9 });
            LinkListNode actual = target.p_006_RemoveDup(node);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Next.Value);
            Assert.AreEqual(9, actual.Next.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next.Next);


            node = LinkListNode.CreateLinkList(new int[] { 1, 2, 5, 6, 9 });
            actual = target.p_006_RemoveDup(node);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Next.Value);
            Assert.AreEqual(9, actual.Next.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next.Next);
        }

        [TestMethod]
        public void Test_p_07_RemoveDupII()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 2, 2, 5, 6, 6, 9, 9 });
            LinkListNode actual = target.p_006_RemoveDupII(node);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Next.Value);
            Assert.AreEqual(9, actual.Next.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next.Next);

            node = LinkListNode.CreateLinkList(new int[] { 1, 2, 5, 6, 9 });
            actual = target.p_006_RemoveDupII(node);

            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(2, actual.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Value);
            Assert.AreEqual(6, actual.Next.Next.Next.Value);
            Assert.AreEqual(9, actual.Next.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next.Next);
        }

        [TestMethod]
        public void Test_p_08_SpiralMatrix()
        {
            Oj target = new Oj();
            int size = 6;
            int[,] input = new int[6, 6];
            target.p_007_SpiralMatrixII(input, size);
        }

        [TestMethod]
        public void Test_p_09_UniquePath()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
            int actual = target.p_008_UniquePath(input);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Test_p_09_FindMaximumSubArra()
        {
            Oj target = new Oj();
            int[] input = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int actual = target.p_009_FindMaximumSubArray(input);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Test_p_09_SeparateList()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 7, 3, 4, 9, 3, 5, 87, 32, 65, 2, 1, 4, });
            LinkListNode actual = target.p_010_PartitionList(node, 6);

            Assert.IsTrue(node.Value < 6);
        }

        [TestMethod]
        public void Test_p_012_Divid()
        {
            Oj target = new Oj();
            int a = 100;
            int b = 3;
            int actual = target.p_012_Divid2Integers(a, b);
            Assert.AreEqual(100 / 3, actual);
        }


        [TestMethod]
        public void Test_p_013_JumpGameII()
        {
            Oj target = new Oj();
            int[] input = new int[] { 2, 3, 1, 1, 4 };
            int actual = target.p_013_JumpGameII(input);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Test_p_014_Add2Number()
        {
            Oj target = new Oj();
            LinkListNode l1 = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkListNode l2 = LinkListNode.CreateLinkList(new int[] { 5, 4, 6, 9, 8 });
            LinkListNode actual = target.p_014_Add2Numbers(l1, l2);
            Assert.AreEqual(6, actual.Value);
            Assert.AreEqual(7, actual.Next.Value);
            Assert.AreEqual(0, actual.Next.Next.Value);
            Assert.AreEqual(4, actual.Next.Next.Next.Value);
        }

        [TestMethod]
        public void Test_p_016_MinPathSu()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 5, 0, 0 }, { 0, 1, 2 }, { 0, 1, 0 } };
            int actual = target.p_016_MinimumPathSum(input);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Test_p_018_PopulateRight()
        {
            Oj target = new Oj();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            target.p_018_PopulateNextRight(root, null);

            Assert.AreEqual(2, root.LeftChild.Next.Value);
            Assert.AreEqual(4, root.LeftChild.LeftChild.Next.Value);
            Assert.AreEqual(5, root.LeftChild.LeftChild.Next.Next.Value);

        }

        [TestMethod]
        public void Test_p_019_Pow()
        {
            Oj target = new Oj();
            double actual = target.p_019_ImplementPow(2.0, 5);
            Assert.AreEqual(Math.Pow(2.0, 5), actual);
        }

        [TestMethod]
        public void Test_p_020_BigIntMulti()
        {
            Oj target = new Oj();
            int[] num1 = new int[] { 1, 2, 3 };
            int[] num2 = new int[] { 3, 2, 1 };

            int[] actual = target.p_20_BigNumberTimes(num1, num2);

            int res = 123 * 321;
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(res % 10, actual[i]);
                res = res / 10;
            }
        }

        [TestMethod]
        public void Test_p_020_FindLastnDigit()
        {
            Oj target = new Oj();
            int[] actual = target.p_021_FindLastnDigit(25, 8, 4);

            Assert.AreEqual(5, actual[0]);
            Assert.AreEqual(2, actual[1]);
            Assert.AreEqual(6, actual[2]);
            Assert.AreEqual(0, actual[3]);
        }

        [TestMethod]
        public void Test_p_022_Findkthin2sortedarray()
        {
            Oj target = new Oj();
            int[] array1 = new int[] { 1, 3, 6, 10, 16, 21, 24, 25 };
            int[] array2 = new int[] { 2, 4, 5, 7, 8, 9, 10, 16, 21, 24, 25 };
            int actual = target.p_022_FindkthNumberin2SortedArray(array1, array2, 8);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void Test_p_023_FindMedian2sortedarray()
        {
            Oj target = new Oj();
            int[] array1 = new int[] { 1, 3, 6, 10, 16, 23, 26, 29 };
            int[] array2 = new int[] { 2, 4, 5, 7, 8, 9, 12, 16, 21, 24, 25 };
            int actual = target.p_023_FindMedianOf2SortedArray(array1, array2);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void Test_p_024_CaptureSurroundRegion()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 1, 1, 1, 1, 1, 1 }, { 1, 0, 0, 1, 0, 1 }, { 1, 1, 0, 1, 0, 1 }, { 1, 0, 1, 1, 1, 1 } };
            target.p_024_CaptureSurroundRegion(input);

            Assert.AreEqual(1, input[1, 1]);
            Assert.AreEqual(1, input[1, 4]);
            Assert.AreEqual(0, input[3, 1]);
        }

        [TestMethod]
        public void Test_p_025_InterleaveString()
        {
            Oj target = new Oj();
            string s1 = "aabcc";
            string s2 = "dbbca";
            bool actual = target.P_025_InterleavString(s1, s2, "aadbbcbcac");
            Assert.IsTrue(actual);

            actual = target.P_025_InterleavString(s1, s2, "aadbbbaccc");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_026_LongestValidParentheses()
        {
            Oj target = new Oj();
            string str = ")()())";
            int actual = target.p_026_LongestValidParentheses(str);
        }

        [TestMethod]
        public void Testp_027_FindKthSmallestInSortedArray()
        {
            Oj target = new Oj();
            int[] input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            int actual = target.p_027_FindKthSmallestInSortedArray(input, 5, 0, 9);
            Assert.AreEqual(5, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 6, 0, 9);
            Assert.AreEqual(6, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 7, 0, 9);
            Assert.AreEqual(7, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 1, 0, 9);
            Assert.AreEqual(1, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 2, 0, 9);
            Assert.AreEqual(2, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 8, 0, 9);
            Assert.AreEqual(8, actual);

            input = new int[] { 4, 3, 7, 8, 2, 6, 9, 5, 0, 1 };
            actual = target.p_027_FindKthSmallestInSortedArray(input, 7, 0, 9);
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void Testp_028_FindSQRT()
        {
            Oj target = new Oj();
            double actual = target.p_028_SQRT(9.0);
            Assert.IsTrue(Math.Abs(actual - Math.Sqrt(9.0)) < 0.001);
        }

        [TestMethod]
        public void Testp_029_FindSQRT()
        {
            Oj target = new Oj();
            double actual = target.p_029_SQRT(9.0);
            Assert.IsTrue(Math.Abs(actual - Math.Sqrt(9.0)) < 0.001);
        }

        [TestMethod]
        public void Testp_031_changesstrings()
        {
            Oj target = new Oj();
            string[] input = new string[] { "a1", "a2", "a3", "a4", "a5", "b1", "b2", "b3", "b4", "b5" };
            List<string> x = new List<string>(input);
            List<string> actual = target.p_30_ChangeString(x);
        }

        [TestMethod]
        public void Test_p_31_atoi()
        {
            Oj target = new Oj();
            string input = "-2147483648";
            int actual = target.p_31_atoi(input);
            Assert.AreEqual(int.MinValue, actual);

            input = "2147483648";
            actual = target.p_31_atoi(input);
            Assert.AreEqual(int.MaxValue, actual);

            input = "-2147483649";
            actual = target.p_31_atoi(input);
            Assert.AreEqual(int.MinValue, actual);
        }

        [TestMethod]
        public void Test_p_34_zigZag()
        {
            Oj target = new Oj();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            List<List<int>> actual = target.p_34_ZigZag(root);
            Assert.AreEqual(3, actual.Count);

            Assert.AreEqual(3, actual[0][0]);
            Assert.AreEqual(2, actual[1][0]);
            Assert.AreEqual(1, actual[1][1]);
            Assert.AreEqual(2, actual[2][0]);
            Assert.AreEqual(4, actual[2][1]);
            Assert.AreEqual(5, actual[2][2]);
        }

        [TestMethod]
        public void Test_p_35_PrettyPrint()
        {
            Oj target = new Oj();
            string input = "I am think about to apply google opening pretty soon. Do you have time to have a chat with me. I am trying to get more information about how google decide to hire or not hire a candidate.";
            List<string> actual = target.p_35_PrettyPrint(input, 20);

            for (int i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(20, actual[i].Length);
            }
        }

        [TestMethod]
        public void Test_p_36_PrettyPrint()
        {
            Oj target = new Oj();
            string input = "          I am think           about to apply         google opening pretty soon. Do you have            time to have a              chat with me. I am trying to             get more information about how google decide to hire or not hire a candidate.            ";
            List<string> actual = target.p_036_PrettyPrintII(input, 20);

            for (int i = 0; i < actual.Count - 1; i++)
            {
                Assert.AreEqual(20, actual[i].Length);
            }
        }

        [TestMethod]
        public void Test_p_37_AddOne()
        {
            Oj target = new Oj();
            int[] input = new int[] { 9, 9, 9 };
            int[] actual = target.p_037_PlusOne(input);
            Assert.AreEqual(4, actual.Length);
            Assert.AreEqual(1, actual[0]);

            // if empty array in then i is one.
            input = new int[] { };
            actual = target.p_037_PlusOne(input);
        }

        [TestMethod]
        public void Test_p_33_longestConsecutiveSequence()
        {
            Oj target = new Oj();
            int[] input = new int[] { 100, 4, 200, 1, 3, 2 };
            int actual = target.p_33_longestConsecutiveSequence(input);
            Assert.AreEqual(4, actual);

            input = new int[] { 100, 4, 200, 1, 8, 10 };
            actual = target.p_33_longestConsecutiveSequence(input);
            Assert.AreEqual(1, actual);

            input = new int[] { };
            actual = target.p_33_longestConsecutiveSequence(input);
            Assert.AreEqual(0, actual);

            input = new int[] { 100, 4, 200, 1, 2, 3, 10, 5, 9, 11, 8, 6, 12, 7 };
            actual = target.p_33_longestConsecutiveSequence(input);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void Test_p_038_MergeSortedArray()
        {
            Oj target = new Oj();
            int[] array1 = new int[] { 1, 3, 5, 0, 0, 0, 0 };
            int[] array2 = new int[] { 2, 4 };
            target.p_038_MergeSortedArray(array1, 2, array2, 1);

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(i + 1, array1[i]);
            }
        }

        [TestMethod]
        public void Test_p_039_AllsubSet()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 2, 3 };
            List<List<int>> actual = target.p_039_AllsubSet(input);
            Assert.AreEqual(8, actual.Count);
        }

        [TestMethod]
        public void Test_p_040_RemoveDup()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 3, 4, 5, 5, 5, 6 });
            LinkListNode actual = target.p_040_RemoveDupFromLinkListII(node);
            while (actual.Next != null)
            {
                Assert.IsTrue(actual.Value != actual.Next.Value);
                actual = actual.Next;
            }

            node = LinkListNode.CreateLinkList(new int[] { 5, 5, 5, 5 });
            actual = target.p_040_RemoveDupFromLinkListII(node);
            Assert.IsNull(actual);

            node = LinkListNode.CreateLinkList(new int[] { 1, 5, 5, 5, 5 });
            actual = target.p_040_RemoveDupFromLinkListII(node);
            Assert.AreEqual(1, actual.Value);

            node = LinkListNode.CreateLinkList(new int[] { 5, 5, 5, 5, 1 });
            actual = target.p_040_RemoveDupFromLinkListII(node);
            Assert.AreEqual(1, actual.Value);
        }

        [TestMethod]
        public void Test_p_041_GetAllCombination()
        {
            Oj target = new Oj();
            List<List<int>> actual = target.p_041_GetAllCombination(4, 2);
            Assert.AreEqual(6, actual.Count);
        }

        [TestMethod]
        public void Test_p_042_ClimbStairs()
        {
            Oj target = new Oj();
            int actual = target.p_042_ClimbStairs(6);
            Assert.AreEqual(13, actual);
        }

        [TestMethod]
        public void Test_p_043_MergeInterval()
        {
            Oj target = new Oj();
            Tuple<int, int> t1 = new Tuple<int, int>(1, 3);
            Tuple<int, int> t2 = new Tuple<int, int>(2, 7);
            Tuple<int, int> t3 = new Tuple<int, int>(4, 5);
            Tuple<int, int> t4 = new Tuple<int, int>(8, 19);
            Tuple<int, int> t5 = new Tuple<int, int>(10, 11);
            Tuple<int, int> t6 = new Tuple<int, int>(24, 25);

            List<Tuple<int, int>> input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            List<Tuple<int, int>> actual = target.p_043_MergeInterval(input);

            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(1, actual[0].Item1);
            Assert.AreEqual(7, actual[0].Item2);

            Assert.AreEqual(8, actual[1].Item1);
            Assert.AreEqual(19, actual[1].Item2);

            Assert.AreEqual(24, actual[2].Item1);
            Assert.AreEqual(25, actual[2].Item2);
        }


        [TestMethod]
        public void Test_p_044_InsertInterval()
        {
            Oj target = new Oj();
            Tuple<int, int> t1 = new Tuple<int, int>(1, 3);
            Tuple<int, int> t2 = new Tuple<int, int>(4, 7);
            Tuple<int, int> t3 = new Tuple<int, int>(8, 9);
            Tuple<int, int> t4 = new Tuple<int, int>(10, 11);
            Tuple<int, int> t5 = new Tuple<int, int>(15, 19);
            Tuple<int, int> t6 = new Tuple<int, int>(24, 25);
            List<Tuple<int, int>> input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            Tuple<int, int> interval = new Tuple<int, int>(0, 26);
            List<Tuple<int, int>> actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(1, actual.Count);
            Assert.AreEqual(0, actual[0].Item1);
            Assert.AreEqual(26, actual[0].Item2);

            input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            interval = new Tuple<int, int>(20, 22);
            actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual(20, actual[5].Item1);
            Assert.AreEqual(22, actual[5].Item2);

            input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            interval = new Tuple<int, int>(-1, 0);
            actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual(-1, actual[0].Item1);
            Assert.AreEqual(0, actual[0].Item2);

            input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            interval = new Tuple<int, int>(99, 100);
            actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(7, actual.Count);
            Assert.AreEqual(99, actual[6].Item1);
            Assert.AreEqual(100, actual[6].Item2);

            input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            interval = new Tuple<int, int>(5, 16);
            actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(4, actual[1].Item1);
            Assert.AreEqual(19, actual[1].Item2);

            input = new List<Tuple<int, int>>() { t1, t2, t3, t4, t5, t6 };
            interval = new Tuple<int, int>(7, 8);
            actual = target.p_044_InsertInterval(input, interval);
            Assert.AreEqual(5, actual.Count);
            Assert.AreEqual(4, actual[1].Item1);
            Assert.AreEqual(9, actual[1].Item2);
        }

        [TestMethod]
        public void Test_p_045_palindromePatitioning()
        {
            Oj target = new Oj();
            string s = "aab";
            List<List<string>> actual = target.p_045_palindromePatitioning(s);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("aa", actual[0][0]);
            Assert.AreEqual("b", actual[0][1]);
            Assert.AreEqual("a", actual[1][0]);
            Assert.AreEqual("a", actual[1][1]);
            Assert.AreEqual("b", actual[1][2]);
        }

        [TestMethod]
        public void Test_p_047_WordLadder()
        {
            Oj target = new Oj();
            string start = "hit";
            string end = "cog";
            HashSet<string> dict = new HashSet<string>() { "hot", "dot", "dog", "lot", "cog" };
            int actual = target.p_047_WordLadder(start, end, dict);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void Testp_048_ReverseLinkListII()
        {
            Oj target = new Oj();

            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5 });
            LinkListNode actual = target.p_048_ReverseLinkListII(node, 2, 4);
            Assert.AreEqual(1, actual.Value);
            Assert.AreEqual(4, actual.Next.Value);
            Assert.AreEqual(3, actual.Next.Next.Value);
            Assert.AreEqual(2, actual.Next.Next.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Next.Next.Value);

        }


        [TestMethod]
        public void Test_p_049_WhentoBuySellStock()
        {
            Oj target = new Oj();
            // code has been test by leetcode online judge. So consider it is passed.
        }

        [TestMethod]
        public void Testp_050_ContainerOfMostwater()
        {
            Oj target = new Oj();
            // code has been test by leetcode online judge. So consider it is passed.
        }

        [TestMethod]
        public void Testp_051_LongestSubstringWithoutRepeating()
        {
            Oj target = new Oj();
            string input = "abcdefgckk";
            int actual = target.p_051_LongestSubstringWithoutRepeating(input);
            Assert.AreEqual(7, actual);
        }


        [TestMethod]
        public void Testp_051_RometoInt()
        {
            Oj target = new Oj();
            string input = "XII";
            int actual = target.p_051_RometoInt(input);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void Test_p_053_Permutation()
        {
            Oj target = new Oj();
            string input = "abc";
            List<string> actual = target.p_053_Permutation(input);
            Assert.AreEqual(6, actual.Count);
        }

        [TestMethod]
        public void Test_p_054_PermutationII()
        {
            Oj target = new Oj();
            string input = "cbc";
            List<string> actual = target.p_053_PermutationII(input);
            Assert.AreEqual(3, actual.Count);

        }


        [TestMethod]
        public void Test_p_054_Triangle()
        {
            Oj target = new Oj();
            List<int> l1 = new List<int>() { 2 };
            List<int> l2 = new List<int>() { 3, 4 };
            List<int> l3 = new List<int>() { 6, 5, 7 };
            List<int> l4 = new List<int>() { 4, 1, 8, 3 };
            List<List<int>> input = new List<List<int>>() { l1, l2, l3, l4 };
            int actual = target.p_054_Triangle(input);
            Assert.AreEqual(11, actual);
        }

        [TestMethod]
        public void Test_p_055_LengthOfLastWord()
        {
            Oj target = new Oj();
            string s = "abcdef kskjd 123456789";
            int actual = target.p_055_LengthOfLastWord(s);
            Assert.AreEqual(9, actual);


            s = "abcdef kskjd 123456789      ";
            actual = target.p_055_LengthOfLastWord(s);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Test_p_056_CountAndSay()
        {
            Oj target = new Oj();
            string actual = target.p_056_CountAndSay(4);
            Assert.AreEqual("111221", actual);
        }

        [TestMethod]
        public void Test_p_057_SameTree()
        {
            Oj target = new Oj();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root1 = TreeNode.DeserializeTree(inputstring, t);
            TreeNode root2 = TreeNode.DeserializeTree(inputstring, t);

            bool actual = target.p_057_SameTree(root1, root2);
            Assert.IsTrue(actual);

            inputstring = "3,1,2,#,#,#,2,4,#,#,6,#,#";
            root2 = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_057_SameTree(root1, root2);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Test_p_058_RemovedupFromsortedArray()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 2, 2, 2, 3, 3, 4, 4, 4, 4, 4 };
            target.p_058_RemovedupFromsortedArray(input);
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(i + 1, input[i]);
            }

            input = new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5, 6, 7 };
            target.p_058_RemovedupFromsortedArray(input);
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(i + 1, input[i]);
            }

        }

        [TestMethod]
        public void Test_p_059_TreeFromInOrderAndPreOrder()
        {
            Oj target = new Oj();
            List<int> inorder = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> preorder = new List<int> { 3, 2, 1, 5, 4, 6 };
            TreeNode actual = target.p_059_TreeFromInOrderAndPreOrder(inorder, preorder);

            Assert.AreEqual(3, actual.Value);
            Assert.AreEqual(2, actual.LeftChild.Value);
            Assert.AreEqual(1, actual.LeftChild.LeftChild.Value);

            Assert.AreEqual(5, actual.RightChild.Value);
            Assert.AreEqual(4, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(6, actual.RightChild.RightChild.Value);
        }

        [TestMethod]
        public void Test_p_059_TreeFromInOrderAndPostOrder()
        {
            Oj target = new Oj();
            List<int> inorder = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> postorder = new List<int> { 1, 2, 4, 6, 5, 3 };
            TreeNode actual = target.p_059_TreeFromInOrderAndPostOrder(inorder, postorder);

            Assert.AreEqual(3, actual.Value);
            Assert.AreEqual(2, actual.LeftChild.Value);
            Assert.AreEqual(1, actual.LeftChild.LeftChild.Value);

            Assert.AreEqual(5, actual.RightChild.Value);
            Assert.AreEqual(4, actual.RightChild.LeftChild.Value);
            Assert.AreEqual(6, actual.RightChild.RightChild.Value);
        }


        [TestMethod]
        public void Test_p_060_SearchIn2dArray()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 49 } };
            bool actual = target.p_060_SearchIn2dArray(input, 11);
            Assert.IsTrue(actual);

            actual = target.p_060_SearchIn2dArray(input, 1);
            Assert.IsTrue(actual);

            actual = target.p_060_SearchIn2dArray(input, 7);
            Assert.IsTrue(actual);

            actual = target.p_060_SearchIn2dArray(input, 49);
            Assert.IsTrue(actual);

            actual = target.p_060_SearchIn2dArray(input, 20);
            Assert.IsTrue(actual);

            actual = target.p_060_SearchIn2dArray(input, 0);
            Assert.IsFalse(actual);

            actual = target.p_060_SearchIn2dArray(input, 65);
            Assert.IsFalse(actual);

            actual = target.p_060_SearchIn2dArray(input, 15);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_061_IsSymmetricTree()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool actual = target.p_061_IsSymmetricTree(root);
            Assert.IsTrue(actual);

            inputstring = "3,2,5,#,#,#,2,4,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_061_IsSymmetricTree(root);
            Assert.IsFalse(actual);

            actual = target.p_061_IsSymmetricTree(null);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_062_MaxDeepthOfATree()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.p_062_MaxDeepthOfATree(root);
            Assert.AreEqual(3, actual);

            inputstring = "3,2,#,#,2,4,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_062_MaxDeepthOfATree(root);
            Assert.AreEqual(3, actual);

            inputstring = "3,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_062_MaxDeepthOfATree(root);
            Assert.AreEqual(1, actual);

            actual = target.p_062_MaxDeepthOfATree(null);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_063_MinDeepthOfATree()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.p_063_MinDeepthOfATree(root);
            Assert.AreEqual(3, actual);

            inputstring = "3,2,#,#,2,4,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_063_MinDeepthOfATree(root);
            Assert.AreEqual(2, actual);

            inputstring = "3,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_063_MinDeepthOfATree(root);
            Assert.AreEqual(1, actual);

            actual = target.p_063_MinDeepthOfATree(null);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_064_IsBalanceTree()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            bool actual = target.p_064_IsBalanceTree(root);
            Assert.IsTrue(actual);

            inputstring = "3,#,2,4,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_064_IsBalanceTree(root);
            Assert.IsFalse(actual);

            actual = target.p_064_IsBalanceTree(null);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_065_strStr()
        {
            Oj target = new Oj();
            string s1 = "abcdefghijklmn";
            string s2 = "cde";
            bool actual = target.p_065_strStr(s1, s2);
            Assert.IsTrue(actual);

            s1 = "abcdefghijklmn";
            s2 = "cdg";
            actual = target.p_065_strStr(s1, s2);
            Assert.IsFalse(actual);

            s1 = "abcdefghijklmn";
            s2 = "cde";
            actual = target.p_065_strStr(s2, s1);
            Assert.IsFalse(actual);

            actual = target.p_065_strStr("", "");
            Assert.IsTrue(actual);

            s1 = "abcdefghijklmn";
            s2 = "";
            actual = target.p_065_strStr(s1, s2);
            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void Test_p_066_LevelOrderTravel()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<List<int>> actual = target.p_066_LevelOrderTravel(root);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(1, actual[0].Count);
            Assert.AreEqual(2, actual[1].Count);
            Assert.AreEqual(4, actual[2].Count);


            actual = target.p_066_LevelOrderTravel(null);
            Assert.IsNull(actual);

            inputstring = "3,2,#,4,#,#,2,4,#,#,5,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_066_LevelOrderTravel(root);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(1, actual[0].Count);
            Assert.AreEqual(2, actual[1].Count);
            Assert.AreEqual(3, actual[2].Count);

        }


        [TestMethod]
        public void Test_p_067_PascalTriangleII()
        {
            Oj target = new Oj();
            List<int> actual = target.p_067_PascalTriangleII(3);

            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(2, actual[1]);
            Assert.AreEqual(1, actual[2]);


            actual = target.p_067_PascalTriangleII(4);
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(3, actual[1]);
            Assert.AreEqual(3, actual[2]);
            Assert.AreEqual(1, actual[3]);

            actual = target.p_067_PascalTriangleII(5);
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(4, actual[1]);
            Assert.AreEqual(6, actual[2]);
            Assert.AreEqual(4, actual[3]);
            Assert.AreEqual(1, actual[4]);

        }

        [TestMethod]
        public void Test_p_069_RemoveDuplicatefromSortedLIstII()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 1, 1, 2, 3, 3, 4, 5, 5, 5 });
            LinkListNode actual = target.p_069_RemoveDuplicatefromSortedLIstII(node);
            Assert.AreEqual(2, actual.Value);
            Assert.AreEqual(4, actual.Next.Value);

            node = LinkListNode.CreateLinkList(new int[] { 2, 3, 4, 5 });
            actual = target.p_069_RemoveDuplicatefromSortedLIstII(node);
            Assert.AreEqual(2, actual.Value);
            Assert.AreEqual(3, actual.Next.Value);
            Assert.AreEqual(4, actual.Next.Next.Value);
            Assert.AreEqual(5, actual.Next.Next.Next.Value);
            Assert.IsNull(actual.Next.Next.Next.Next);

            node = LinkListNode.CreateLinkList(new int[] { 2 });
            actual = target.p_069_RemoveDuplicatefromSortedLIstII(node);
            Assert.AreEqual(2, actual.Value);

            node = LinkListNode.CreateLinkList(new int[] { 2, 2, 2, 2 });
            actual = target.p_069_RemoveDuplicatefromSortedLIstII(node);
            Assert.IsNull(actual);

            actual = target.p_069_RemoveDuplicatefromSortedLIstII(null);
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_p_070_RemoveElement()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 3, 2, 5, 2, 3, 4, 5, 4, 2 };
            int actual = target.p_070_RemoveElement(input, 2);
            Assert.AreEqual(6, actual);

            input = new int[] { 2, 2, 2, 2, 2, 3, 4, 5, 4, 2 };
            actual = target.p_070_RemoveElement(input, 2);
            Assert.AreEqual(3, actual);

            input = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            actual = target.p_070_RemoveElement(input, 2);
            Assert.AreEqual(-1, actual);

            input = new int[] { 2, 2, 1, 2, 2, 2, 2, 2, 2, 2 };
            actual = target.p_070_RemoveElement(input, 2);
            Assert.AreEqual(0, actual);

            input = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 1 };
            actual = target.p_070_RemoveElement(input, 2);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_072_SortColor()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 3, 2, 1, 2, 3, 2, 3, 2, 1, 2, 3, 2, 3, 3, 2, 1, 2 };
            target.p_072_SortColor(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }


            input = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            target.p_072_SortColor(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }


            input = new int[] { 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            target.p_072_SortColor(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }

            input = new int[] { 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            target.p_072_SortColor(input);
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i + 1]);
            }
        }

        [TestMethod]
        public void Test_p_073_RotateList()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            LinkListNode actual = target.p_073_RotateList(node, 3);
            Assert.AreEqual(3, actual.Value);

            node = LinkListNode.CreateLinkList(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            actual = target.p_073_RotateList(node, 0);
            Assert.AreEqual(9, actual.Value);

            node = LinkListNode.CreateLinkList(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            actual = target.p_073_RotateList(node, 8);
            Assert.AreEqual(8, actual.Value);

        }

        [TestMethod]
        public void Test_p_074_TwoSum()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 2, 4, 4, 5, 6, 8, 11, 12 };
            Tuple<int, int> actual = target.p_074_TwoSum(input, 11);
            Assert.AreEqual(5, actual.Item1);
            Assert.AreEqual(6, actual.Item2);
        }

        [TestMethod]
        public void Test_p_075_ZigZagConversion()
        {
            Oj target = new Oj();
            string input = "PAYPALISHIRING";
            string actual = target.p_075_ZigZagConversion(input, 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", actual);

            input = "PAYPALISHIRING";
            actual = target.p_075_ZigZagConversion(input, 2);
            Assert.AreEqual("PYAIHRNAPLSIIG", actual);

            input = "abcdefghijklmnopqrstuvwxyz";
            actual = target.p_075_ZigZagConversion(input, 4);
            Assert.AreEqual("agmsybfhlnrtxzceikoquwdjpv", actual);
        }

        [TestMethod]
        public void Test_p_077_ReverseInteger()
        {
            Oj target = new Oj();
            int input = 12345;
            int actual = target.p_077_ReverseInteger(input);
            Assert.AreEqual(54321, actual);

        }

        [TestMethod]
        public void Test_p_078_MaximalRectangle()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 0, 1, 1, 1, 0 }, { 0, 1, 1, 1, 0 }, { 0, 0, 1, 0, 1 } };
            int actual = target.p_078_MaximalRectangle(input);
            Assert.AreEqual(6, actual);

            input = new int[,] { { 0, 1, 1, 1, 0 }, { 0, 1, 1, 1, 0 }, { 0, 1, 1, 1, 0 }, { 0, 0, 1, 0, 1 } };
            actual = target.p_078_MaximalRectangle(input);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Test_p_079_RotateImage()
        {
            Oj target = new Oj();
            int[,] input = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            target.p_079_RotateImage(input);
            Assert.AreEqual(4, input[0, 0]);

            input = new int[,] { { 1, 2 }, { 3, 4 } };
            target.p_079_RotateImage(input);
            Assert.AreEqual(2, input[0, 0]);
        }

        [TestMethod]
        public void Test_p_080_SearchInRotateSortedArrayII()
        {
            Oj target = new Oj();
            int[] input = new int[] { 3, 4, 5, 6, 7, 8, 9, 1, 2 };
            bool actual = target.p_080_SearchInRotateSortedArrayII(input, 1);
            Assert.IsTrue(actual);

            actual = target.p_080_SearchInRotateSortedArrayII(input, 8);
            Assert.IsTrue(actual);

            actual = target.p_080_SearchInRotateSortedArrayII(input, 2);
            Assert.IsTrue(actual);
            actual = target.p_080_SearchInRotateSortedArrayII(input, 3);
            Assert.IsTrue(actual);
            actual = target.p_080_SearchInRotateSortedArrayII(input, 4);
            Assert.IsTrue(actual);
            actual = target.p_080_SearchInRotateSortedArrayII(input, 5);
            Assert.IsTrue(actual);
            actual = target.p_080_SearchInRotateSortedArrayII(input, 9);
            Assert.IsTrue(actual);

            actual = target.p_080_SearchInRotateSortedArrayII(input, 10);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_081_RemoveDupFromSortedArrayII()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 2, 2, 3, 4, 4, 4, 4, 4, 5, 5, 5, 6, 7, 7, 7, 7, 8, 9 };
            target.p_081_RemoveDupFromSortedArrayII(input);
            Assert.AreEqual(5, input[6]);
        }

        [TestMethod]
        public void Test_p_082_BinaryTreeMaximumPathSum()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            Tuple<int, int> actual = target.p_082_BinaryTreeMaximumPathSum(root);
            Assert.AreEqual(10, actual.Item1);
            Assert.AreEqual(17, actual.Item2);

            inputstring = "3,2,5,#,#,4,#,#,2,104,#,#,105,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_082_BinaryTreeMaximumPathSum(root);
            Assert.AreEqual(110, actual.Item1);
            Assert.AreEqual(211, actual.Item2);
        }


        [TestMethod]
        public void Test_p_082_BinaryTreeMaxPathSumII()
        {
            Oj target = new Oj();
            string inputstring = "3,2,5,#,#,4,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            int actual = target.p_082_BinaryTreeMaxPathSumII(root);
            Assert.AreEqual(17, actual);

            inputstring = "3,2,5,#,#,4,#,#,2,104,#,#,105,#,#";
            root = TreeNode.DeserializeTree(inputstring, t);
            actual = target.p_082_BinaryTreeMaxPathSumII(root);
            Assert.AreEqual(211, actual);
        }

        [TestMethod]
        public void Test_p_083_CombinationSumII()
        {
            Oj target = new Oj();
            int[] input = new int[] { 10, 1, 2, 7, 6, 1, 5 };
            int k = 8;
            List<List<int>> actual = target.p_083_CombinationSumII(input, k);
        }

        [TestMethod]
        public void Test_p_084_PalindromeNumber()
        {
            Oj target = new Oj();
            int input = 12321;
            bool actual = target.p_084_PalindromeNumber(input);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_085_EditDistance()
        {
            Oj target = new Oj();
            string s1 = "snowy";
            string s2 = "sunny";
            int actual = target.p_085_EditDistance(s1, s2);
            Assert.AreEqual(3, actual);


            s1 = "exponential";
            s2 = "polynomial";
            actual = target.p_085_EditDistance(s1, s2);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Test_p_087_GenerateAllParentheses()
        {
            Oj target = new Oj();
            List<string> actual = target.p_087_GenerateAllParentheses(3);
            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void Test_p_088_DistinctSubSequences()
        {
            Oj target = new Oj();
            string s1 = "rabbbit";
            string s2 = "rabbit";
            int actual = target.p_088_DistinctSubSequences(s1, s2);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Test_p_088_DistinctSubSequencesII()
        {
            Oj target = new Oj();
            string s1 = "rabbbit";
            string s2 = "rabbit";
            int actual = target.p_088_DistinctSubSequencesII(s1, s2);
            Assert.AreEqual(3, actual);

            s1 = "abcde";
            s2 = "aec";
            actual = target.p_088_DistinctSubSequencesII(s1, s2);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_090_RegularExpressionMatching()
        {
            Oj target = new Oj();
            string s = "aa";
            string t = "a";
            bool actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsFalse(actual);

            s = "aa";
            t = "aa";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = "aa";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsFalse(actual);

            s = "aaa";
            t = "a*";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = ".*";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = ".*";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = "c*a*b";
            actual = target.p_090_RegularExpressionMatching(s, t);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_091_FlattenBinaryTreeToLinkedList()
        {
            Oj target = new Oj();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);

            TreeNode actual = target.p_091_FlattenBinaryTreeToLinkedList(root);
            Assert.AreEqual(3, actual.Value);
            actual = actual.Next;
            Assert.AreEqual(1, actual.Value);

            actual = actual.Next;
            Assert.AreEqual(2, actual.Value);

            actual = actual.Next;
            Assert.AreEqual(2, actual.Value);

            actual = actual.Next;
            Assert.AreEqual(4, actual.Value);

            actual = actual.Next;
            Assert.AreEqual(5, actual.Value);

            actual = actual.Next;
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_p_093_TrappingRainWater()
        {
            Oj target = new Oj();
            int[] input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            int actual = target.p_093_TrappingRainWater(input);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Test_p_094_PalindromePartitioningII()
        {
            Oj target = new Oj();
            string s = "aab";
            int actual = target.p_094_PalindromePartitioningII(s);
            Assert.AreEqual(1, actual);

            s = "aabb";
            actual = target.p_094_PalindromePartitioningII(s);
            Assert.AreEqual(1, actual);

            s = "aabcbaa";
            actual = target.p_094_PalindromePartitioningII(s);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_095_SearchInsertPosition()
        {
            Oj target = new Oj();
            int[] input = new int[] { 1, 3, 5, 6 };
            int actual = target.p_095_SearchInsertPosition(input, 5);
            Assert.AreEqual(2, actual);

            actual = target.p_095_SearchInsertPosition(input, 2);
            Assert.AreEqual(1, actual);

            actual = target.p_095_SearchInsertPosition(input, 7);
            Assert.AreEqual(4, actual);

            actual = target.p_095_SearchInsertPosition(input, 0);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_p_098_UniqueBinarySearchTree()
        {
            Oj target = new Oj();
            int acutal = target.p_098_UniqueBinarySearchTree(2);
        }

        [TestMethod]
        public void Test_p_100_SubsetII()
        {
            Oj target = new Oj();
            int[] input = new int[] { 2, 1, 2 };
            List<List<int>> actual = target.p_100_SubsetII(input);
            Assert.AreEqual(6, actual.Count);
        }

        [TestMethod]
        public void Test_p_101_SearchForARange()
        {
            Oj target = new Oj();
            int[] input = new int[] { 5, 6, 6, 7, 8, 8, 10, 10 };
            Tuple<int, int> actual = target.p_101_SearchForARange(input, 8);
            Assert.AreEqual(4, actual.Item1);
            Assert.AreEqual(5, actual.Item2);

            actual = target.p_101_SearchForARange(input, 6);
            Assert.AreEqual(1, actual.Item1);
            Assert.AreEqual(2, actual.Item2);

            actual = target.p_101_SearchForARange(input, 7);
            Assert.AreEqual(3, actual.Item1);
            Assert.AreEqual(3, actual.Item2);

            actual = target.p_101_SearchForARange(input, 10);
            Assert.AreEqual(6, actual.Item1);
            Assert.AreEqual(7, actual.Item2);
        }

        [TestMethod]
        public void Test_p_103_SimplifyPath()
        {
            Oj target = new Oj();
            string input = "/a/./b/../../c/";
            string actual = target.p_103_SimplifyPath(input);
            Assert.AreEqual("/c/", actual);
        }

        [TestMethod]
        public void Test_p_104_WildcardMatching()
        {
            Oj target = new Oj();
            string s1 = "aa";
            string p = "a";
            bool actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsFalse(actual);

            s1 = "aa";
            p = "aa";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsTrue(actual);

            s1 = "aaa";
            p = "aa";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsFalse(actual);

            s1 = "aa";
            p = "a*";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsTrue(actual);

            s1 = "aa";
            p = "*";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsTrue(actual);

            s1 = "aa";
            p = "?*";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsTrue(actual);

            s1 = "aab";
            p = "c*a*b*";
            actual = target.p_104_WildcardMatching(s1, p);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_105_ValidPalindrome()
        {
            Oj target = new Oj();
            char[] s = "a man, a plan, a canal: panama".ToCharArray();
            bool actual = target.p_105_ValidPalindrome(s);
            Assert.IsTrue(actual);

            s = "race a car".ToCharArray();
            actual = target.p_105_ValidPalindrome(s);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_106_SwapNodesInPairs()
        {
            Oj target = new Oj();
            LinkListNode node = LinkListNode.CreateLinkList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkListNode actual = target.p_106_SwapNodesInPairs(node);

            Assert.AreEqual(2, actual.Value);
            Assert.AreEqual(1, actual.Next.Value);
        }

        [TestMethod]
        public void Testp_107_ScrableString()
        {
            Oj target = new Oj();
            string s1 = "great";
            string s2 = "rgtae";
            bool actual = target.p_107_ScrableString(s1, s2);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Testp_p_108_WordLadderII()
        {
            Oj target = new Oj();
            string start = "hit";
            string end = "cog";
            HashSet<string> dict = new HashSet<string>() { "hot", "dot", "dog", "lot", "log" };
            List<string> actual = target.p_108_WordLadderII(start, end, dict);
            Assert.AreEqual("hit -> hot -> dot -> dog -> cog", actual[0]);
            Assert.AreEqual("hit -> hot -> lot -> log -> cog", actual[1]);
        }

        [TestMethod]
        public void Testp_p_110_MuplyStrings()
        {
            Oj target = new Oj();
            string s1 = "123";
            string s2 = "23";
            int actual = target.p_110_MuplyStrings(s1, s2);
            Assert.AreEqual(2829, actual);

            s2 = "999";
            actual = target.p_110_MuplyStrings(s1, s2);
            Assert.AreEqual(122877, actual);

            s1 = "9999";
            s2 = "999";
            actual = target.p_110_MuplyStrings(s1, s2);
            Assert.AreEqual(9989001, actual);
        }

        [TestMethod]
        public void Testp_p_111_BinaryTreeInOrderTraversal()
        {
            Oj target = new Oj();
            string inputstring = "3,1,2,#,#,#,2,4,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<int> actual = target.p_111_BinaryTreeInOrderTraversal(root);

            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(1, actual[1]);
            Assert.AreEqual(3, actual[2]);
            Assert.AreEqual(4, actual[3]);
            Assert.AreEqual(2, actual[4]);
            Assert.AreEqual(5, actual[5]);
        }

        [TestMethod]
        public void Testp_p_113_LongestPalindromicString()
        {
            Oj target = new Oj();
            string s = "baca";
            int actual = target.p_113_LongestPalindromicString(s);
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void Testp_p_114_FirstMissingNmber()
        {
            Oj target = new Oj();
            int[] input = new int[] { 0, 1, 4, 5, 6, 7, 8, 3 };
            int actual = target.p_114_FirstMissingNmber(input);
            Assert.AreEqual(2, actual);

            input = new int[] { 0, 1, 2, 4, 5, 7, 8, 3 };
            actual = target.p_114_FirstMissingNmber(input);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void Testp_p_115_RestoreIPAddress()
        {
            Oj target = new Oj();
            string s = "25525511135";
            List<string> actual = target.p_115_RestoreIPAddress(s);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual("255.255.11.135", actual[0]);
            Assert.AreEqual("255.255.111.35", actual[1]);
        }

        [TestMethod]
        public void Testp_p_116_LetterCombinationOfaPhoneNumber()
        {
            Oj target = new Oj();
            int[] input = new int[] { 2, 3 };
            List<string> actual = target.p_116_LetterCombinationOfaPhoneNumber(input);
            Assert.AreEqual(9, actual.Count);
        }


        [TestMethod]
        public void Testp_p_117_UniqueBSTII()
        {
            Oj target = new Oj();
            List<TreeNode> actual = target.p_117_UniqueBSTII(3);
            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void Testp_p_119_LargestRectangleinHistogram()
        {
            Oj target = new Oj();
            List<int> input = new List<int> { 2, 1, 5, 6, 2, 3 };
            int actual = target.p_119_LargestRectangleinHistogram(input);
            Assert.AreEqual(10, target.p_119_LargestRectangleinHistogram(input));

            input = new List<int> { 2, 1, 5, 6, 2, 3, 100 };
            actual = target.p_119_LargestRectangleinHistogram(input);
            Assert.AreEqual(100, target.p_119_LargestRectangleinHistogram(input));
        }

        [TestMethod]
        public void Test_p_120_MinimumWindowSubString()
        {
            Oj target = new Oj();
            string s1 = "ADOBECODEBANC";
            string s2 = "ABC";
            int actual = target.p_120_MinimumWindowSubString(s1, s2);
            Assert.AreEqual(4, actual);

            s1 = "acbbaca";
            s2 = "aba";
            actual = target.p_120_MinimumWindowSubString(s1, s2);
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void Test_p_121_CloneGraphII()
        {
            Oj target = new Oj();
            Oj.GraphNode n1 = new Oj.GraphNode(); n1.value = 1;
            Oj.GraphNode n2 = new Oj.GraphNode(); n2.value = 2;
            Oj.GraphNode n3 = new Oj.GraphNode(); n3.value = 3;
            Oj.GraphNode n4 = new Oj.GraphNode(); n4.value = 4;
            Oj.GraphNode n5 = new Oj.GraphNode(); n5.value = 5;
            Oj.GraphNode n6 = new Oj.GraphNode(); n6.value = 6;
            n1.Neighbors.AddRange(new Oj.GraphNode[] { n2, n3, n4 });
            n3.Neighbors.AddRange(new Oj.GraphNode[] { n5 });
            n4.Neighbors.AddRange(new Oj.GraphNode[] { n3, n6 });
            n5.Neighbors.Add(n6);

            Oj.GraphNode actual = target.p_121_CloneGraphII(n1);

            Assert.AreEqual(1, actual.Neighbors[1].Neighbors.Count);
            Assert.AreEqual(2, actual.Neighbors[2].Neighbors.Count);

        }

        [TestMethod]
        public void Test_p_121_CloneGraph()
        {
            Oj target = new Oj();
            Oj.GraphNode n1 = new Oj.GraphNode(); n1.value = 1;
            Oj.GraphNode n2 = new Oj.GraphNode(); n2.value = 2;
            Oj.GraphNode n3 = new Oj.GraphNode(); n3.value = 3;
            Oj.GraphNode n4 = new Oj.GraphNode(); n4.value = 4;
            Oj.GraphNode n5 = new Oj.GraphNode(); n5.value = 5;
            Oj.GraphNode n6 = new Oj.GraphNode(); n6.value = 6;
            n1.Neighbors.AddRange(new Oj.GraphNode[] { n2, n3, n4 });
            n3.Neighbors.AddRange(new Oj.GraphNode[] { n5 });
            n4.Neighbors.AddRange(new Oj.GraphNode[] { n3, n6 });
            n5.Neighbors.Add(n6);

            Oj.GraphNode actual = target.p_121_CloneGraph(n1);

            Assert.AreEqual(1, actual.Neighbors[1].Neighbors.Count);
            Assert.AreEqual(2, actual.Neighbors[2].Neighbors.Count);

        }

        [TestMethod]
        public void Test_p_121_CloneGraphIII()
        {
            Oj target = new Oj();
            Oj.GraphNode n1 = new Oj.GraphNode(); n1.value = 1;
            Oj.GraphNode n2 = new Oj.GraphNode(); n2.value = 2;
            Oj.GraphNode n3 = new Oj.GraphNode(); n3.value = 3;
            Oj.GraphNode n4 = new Oj.GraphNode(); n4.value = 4;
            Oj.GraphNode n5 = new Oj.GraphNode(); n5.value = 5;
            Oj.GraphNode n6 = new Oj.GraphNode(); n6.value = 6;
            n1.Neighbors.AddRange(new Oj.GraphNode[] { n2, n3, n4 });
            n3.Neighbors.AddRange(new Oj.GraphNode[] { n5 });
            n4.Neighbors.AddRange(new Oj.GraphNode[] { n3, n6 });
            n5.Neighbors.Add(n6);

            Oj.GraphNode actual = target.p_121_CloneGraphIII(n1);

            Assert.AreEqual(1, actual.Neighbors[1].Neighbors.Count);
            Assert.AreEqual(2, actual.Neighbors[2].Neighbors.Count);
        }

        [TestMethod]
        public void Test_p_122_PalindraNumber()
        {
            Oj target = new Oj();
            int input = 11;
            bool actual = target.p_122_IsAPalindromeNumber(input);
            Assert.IsTrue(actual);

            input = 12321;
            actual = target.p_122_IsAPalindromeNumber(input);
            Assert.IsTrue(actual);

            input = 123321;
            actual = target.p_122_IsAPalindromeNumber(input);
            Assert.IsTrue(actual);

            input = 12311;
            actual = target.p_122_IsAPalindromeNumber(input);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Test_p_122_PalindraNumberII()
        {
            Oj target = new Oj();
            int input = 11;
            bool actual = target.p_122_IsPalindromeNumberII(input);
            Assert.IsTrue(actual);

            input = 12321;
            actual = target.p_122_IsPalindromeNumberII(input);
            Assert.IsTrue(actual);

            input = 123321;
            actual = target.p_122_IsPalindromeNumberII(input);
            Assert.IsTrue(actual);

            input = 12311;
            actual = target.p_122_IsPalindromeNumberII(input);
            Assert.IsFalse(actual);

        }

        [TestMethod]
        public void Test_p_123_EditDistance()
        {
            Oj target = new Oj();
            string s1 = "exponential";
            string s2 = "polynomial";
            //string s1 = "snowy";
            //string s2 = "sunny";
            int actual = target.p_123_EditDistance(s1, s2);
            Assert.AreEqual(6, actual);
        }


        [TestMethod]
        public void Test_p_124_RegularExpressionMatch()
        {
            Oj target = new Oj();
            string s = "aa";
            string t = "a";
            bool actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsFalse(actual);

            s = "aa";
            t = "aa";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = "aa";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsFalse(actual);

            s = "aaa";
            t = "a*";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = ".*";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = ".*";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = "c*a*b";
            actual = target.p_124_RegularExpressionMatch(s, t);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_125_InsertIntoCyclicSortedList()
        {
            Oj target = new Oj();
            List<int> input = new List<int> { 4, 6, 8, 10, 12, 14, 16, 0, 2 };
            int k = 1;
            target.p_125_InsertIntoCyclicSortedList(k, input);
            Assert.AreEqual(1, input[8]);
        }

        [TestMethod]
        public void Test_P_126_PostOrderTravel()
        {
            Oj target = new Oj();
            string inputstring = "3,1,6,#,#,#,2,7,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<int> actual = target.P_126_PostOrderTravel(root);
        }

        [TestMethod]
        public void Test_p_127_InOrderTravel()
        {
            Oj target = new Oj();
            string inputstring = "3,1,6,#,#,#,2,7,#,#,5,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<int> actual = target.p_127_InOrderTravel(root);
        }

        [TestMethod]
        public void Test_p_128_ZigZagTravel()
        {
            Oj target = new Oj();
            string inputstring = "3,1,6,8,#,#,#,#,2,7,#,#,5,9,#,#,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            List<int> actual = target.p_128_ZigZagTravel(root);
        }

        [TestMethod]
        public void Test_p_127_FindTopK()
        {
            Oj target = new Oj();
            int[] input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            int actual = target.p_127_FindTopK(input, 2, 0, input.Length - 1);
            Assert.AreEqual(2, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 3, 0, input.Length - 1);
            Assert.AreEqual(3, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 4, 0, input.Length - 1);
            Assert.AreEqual(4, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 5, 0, input.Length - 1);
            Assert.AreEqual(5, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 6, 0, input.Length - 1);
            Assert.AreEqual(6, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 7, 0, input.Length - 1);
            Assert.AreEqual(7, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 8, 0, input.Length - 1);
            Assert.AreEqual(8, actual);

            input = new int[] { 8, 5, 3, 6, 7, 4, 2, 9, 1 };
            actual = target.p_127_FindTopK(input, 9, 0, input.Length - 1);
            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void Test_p_130_FindLCA()
        {
            Oj target = new Oj();
            string inputstring = "3,1,6,8,#,#,#,#,2,7,#,#,5,9,#,#,#,#";
            char t = ',';
            TreeNode root = TreeNode.DeserializeTree(inputstring, t);
            TreeNode actual = target.p_130_FindLCA(root, 5, 2);
            Assert.AreEqual(2, actual.Value);

            actual = target.p_130_FindLCA(root, 7, 9);
            Assert.AreEqual(2, actual.Value);
        }

        [TestMethod]
        public void Test_p_131_RegexMatch()
        {
            Oj target = new Oj();
            string s = "aa";
            string t = "a";
            bool actual = target.p_131_RegesMatch(s, t);
            Assert.IsFalse(actual);

            s = "aa";
            t = "aa";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = "aa";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsFalse(actual);

            s = "aaa";
            t = "a*";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = ".*";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = ".*";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = "c*a*b";
            actual = target.p_131_RegesMatch(s, t);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_132_FindNthPermu()
        {
            Oj target = new Oj();
            char[] ste = new char[] { 'a', 'b', 'c' };
            string actual = target.p_132_NthPermutation(ste, 2);
        }

        [TestMethod]
        public void Test_p_134_DistanceMax()
        {
            Oj target = new Oj();
            int[] input = new int[] { 4, 3, 5, 2, 1, 3, 2, 3 };
            int actual = target.p_134_DistanceMax(input);
        }

        [TestMethod]
        public void Test_p_135_LongestSubString()
        {
            Oj target = new Oj();
            string input = "abcdefgcxyzuvw";
            string actual = target.p_135_LongestSubString(input);
            Assert.AreEqual("defgcxyzuvw", actual);

            input = "abcdefgccxyzuvwq";
            actual = target.p_135_LongestSubString(input);
            Assert.AreEqual("cxyzuvwq", actual);

            input = "abcdefgccxyzuvw";
            actual = target.p_135_LongestSubString(input);
            Assert.AreEqual("abcdefg", actual);

        }



        [TestMethod]
        public void Test_p_001_FindLongestDomino()
        {
            Amazon target = new Amazon();
            Amazon.Domino d1 = new Amazon.Domino(new Tuple<int, int>(7, 2), true);
            Amazon.Domino d2 = new Amazon.Domino(new Tuple<int, int>(1, 3), true);
            Amazon.Domino d3 = new Amazon.Domino(new Tuple<int, int>(4, 5), true);
            Amazon.Domino d4 = new Amazon.Domino(new Tuple<int, int>(3, 4), true);
            List<Amazon.Domino> input = new List<Amazon.Domino>() { d1, d2, d3 };
            int actual = target.p_001_FindLongestDomino(input, d4);
            Assert.AreEqual(3, actual);

        }

        [TestMethod]
        public void Test_p_002_MatchingWords()
        {
            Amazon target = new Amazon();

            string s = "aa";
            string t = "a";
            bool actual = target.p_002_MatchingWords(s, t);
            Assert.IsFalse(actual);

            s = "aa";
            t = "aa";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = "aa";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsFalse(actual);

            s = "aaa";
            t = "a*";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsTrue(actual);

            s = "aaa";
            t = ".*";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = ".*";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsTrue(actual);

            s = "aab";
            t = "c*a*b";
            actual = target.p_002_MatchingWords(s, t);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_p_005_Find_All_StartWith()
        {
            Amazon target = new Amazon();
            Oj.TrieNode trie = new Oj.TrieNode();
            target.p_005_InsertIntoTrie(trie, "abcdefg");
            target.p_005_InsertIntoTrie(trie, "abcxefg");
            target.p_005_InsertIntoTrie(trie, "abcyefg");
            target.p_005_InsertIntoTrie(trie, "abczefg");
            target.p_005_InsertIntoTrie(trie, "abcrefg");
            target.p_005_InsertIntoTrie(trie, "abcdsafasfsfsfasfsg");
            target.p_005_InsertIntoTrie(trie, "abc");
            target.p_005_InsertIntoTrie(trie, "abcppeieorjt");
            target.p_005_InsertIntoTrie(trie, "axcsxbcrefg");

            List<string> actual = target.p_005_Find_All_StartWith(trie, "abc");
            Assert.AreEqual(8, actual.Count);
        }

        [TestMethod]
        public void Test_p_006_SortDoubleLinkedList()
        {
            Amazon target = new Amazon();
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 4, 2, 8, 6, 5, 1, 9, 7, 3 });
            LinkListNode actual = target.p_006_SortDoubleLinkedList(input);
            int i = 1;
            while (i <= 9)
            {
                Assert.AreEqual(i, actual.Value);
                actual = actual.Next;
                i++;
            }
        }

        [TestMethod]
        public void Test_p_007_CreateTree()
        {
            Amazon target = new Amazon();
            int[] input = new int[] { 3, -5, 4, -6 };
            TreeNode actual = target.p_007_CreateTree(input);
        }

        [TestMethod]
        public void Test_p_008_MazeTravel()
        {
            Amazon target = new Amazon();
            int[,] input = new int[,]
            {
                {0,1,1},
                {0,0,1},
                {1,0,0},
            };
            bool actual = target.p_008_MazeTravel(input, 0, 0, 2, 2);
            Assert.IsTrue(actual);

            input = new int[,]
            { {0,1,0,1,1,1,1,1},
              {0,0,1,0,1,0,1,1},
              {1,0,0,1,1,1,1,1},
              {0,1,0,1,1,0,0,0},
              {0,1,0,0,0,0,1,0},
              {0,1,0,0,0,0,1,0},
            };
            actual = target.p_008_MazeTravel(input, 0, 0, 5, 7);
            Assert.IsTrue(actual);

            input = new int[,]
            { {0,1,0,1,1,1,1,1},
              {0,0,1,0,1,0,1,1},
              {1,0,0,1,1,1,1,1},
              {0,1,0,1,1,0,1,0},
              {0,1,0,0,0,0,1,0},
              {0,1,0,0,0,0,1,0},
            };
            actual = target.p_008_MazeTravel(input, 0, 0, 5, 7);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_1_5_CompressStrin()
        {
            Cc150 target = new Cc150();
            string input = "aabcccccaaa";
            string actual = target.p_1_5_CompressString(input);
            Assert.AreEqual("a2b1c5a3", actual);

            input = "abcdefg";
            actual = target.p_1_5_CompressString(input);
            Assert.AreEqual("abcdefg", actual);
        }
        [TestMethod]
        public void Test_p_2_1_RemoveDup()
        {
            Cc150 target = new Cc150();
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 5, 3, 1, 3, 5, 4, 2, 3, 5, 2, 2, 2, 5, 3, 1, 2, 3, 4, 5 });
            LinkListNode actual = target.p_2_1_RemoveDup(input);
            for (int i = 1; i <= 5; i++)
            {
                Assert.AreEqual(i, actual.Value);
                actual = actual.Next;
            }
            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_p_2_2_KthFromLast()
        {
            Cc150 target = new Cc150();
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 5, 3, 1, 3, 5, 4, 2, 3, 5, 2, 2, 2, 5, 3, 1, 2, 3, 4, 5 });
            LinkListNode actual = target.p_2_2_KthFromLast(input, 2);
            Assert.AreEqual(4, actual.Value);
        }

        [TestMethod]
        public void Test_p_2_2_KthFromLastII()
        {
            Cc150 target = new Cc150();
            LinkListNode input = LinkListNode.CreateLinkList(new int[] { 1, 5, 3, 1, 3, 5, 4, 2, 3, 5, 2, 2, 2, 5, 3, 1, 2, 3, 4, 5 });
            LinkListNode actual = target.p_2_2_KthFromLastII(input, 2);
            Assert.AreEqual(4, actual.Value);
        }

        [TestMethod]
        public void Test_3_2_StackTest()
        {
            Cc150.SpecialStack s = new Cc150.SpecialStack();
            s.Push(10);
            s.Push(11);
            s.Push(5);
            s.Push(6);
            s.Push(4);

            Assert.AreEqual(4, s.Min());
            s.Pop();
            Assert.AreEqual(5, s.Min());
            s.Pop();
            Assert.AreEqual(5, s.Min());
            s.Pop();
            Assert.AreEqual(10, s.Min());
            s.Pop();
            Assert.AreEqual(10, s.Min());
        }

        [TestMethod]
        public void Test_p_4_2_IsARoute()
        {
            Cc150 target = new Cc150();
            GraphNode n1 = new GraphNode(1);
            GraphNode n2 = new GraphNode(2);
            GraphNode n3 = new GraphNode(3);
            GraphNode n4 = new GraphNode(4);
            GraphNode n5 = new GraphNode(5);
            GraphNode n6 = new GraphNode(6);
            n1.Neighbors.AddRange(new GraphNode[] { n2, n3 });
            n3.Neighbors.AddRange(new GraphNode[] { n5 });
            n4.Neighbors.AddRange(new GraphNode[] { n3, n6 });
            n5.Neighbors.Add(n6);

            List<GraphNode> graph = new List<GraphNode>() { n1, n2, n3, n4, n5 };

            bool actual = target.p_4_2_IsARoute(graph, n1, n6);
            Assert.IsTrue(actual);

            actual = target.p_4_2_IsARoute(graph, n4, n1);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_p_17_8_FindMaxContiguous()
        {
            Cc150 target = new Cc150();
            int[] input = new int[] { 2, 3, -8, -1, 2, 4, -2, 3 };
            int actual = target.p_17_8_FindMaxContiguous(input);
        }

        [TestMethod]
        public void Test_p_18_1_Add()
        {
            Cc150 target = new Cc150();
            uint n1 = 12;
            uint n2 = 13;

            uint actual = target.p_18_1_Add(n1, n2);
            Assert.AreEqual(n1 + n2, actual);
        }


        [TestMethod]
        public void Test_string_to_long_1()
        {
            Zillow target = new Zillow();

            // test with long.max
            string input = "9223372036854775807";
            long actual = target.StringToLong(input);
            Assert.AreEqual(9223372036854775807L, actual);

            // test with long.min
            input = "-9223372036854775808";
            actual = target.StringToLong(input);
            Assert.AreEqual(-9223372036854775808L, actual);

            // test with normal long
            input = "37203685477";
            actual = target.StringToLong(input);
            Assert.AreEqual(37203685477, actual);

            // test with normal long with prefix 
            input = "   37203685477";
            actual = target.StringToLong(input);
            Assert.AreEqual(37203685477, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Test_string_to_long_2()
        {
            // test with overflow
            Zillow target = new Zillow();
            string input = "9223372036854775808";
            long actual = target.StringToLong(input);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Test_string_to_long_3()
        {
            // test with under flow
            Zillow target = new Zillow();
            string input = "-9223372036854775809";
            long actual = target.StringToLong(input);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Test_string_to_long_4()
        {
            // test with format error
            Zillow target = new Zillow();
            string input = "-92x23372036854775809";
            long actual = target.StringToLong(input);
        }


        [TestMethod]
        public void Test_TrinaryTreeInsert()
        {
            // test insert.
            Zillow target = new Zillow();
            TrinaryTreeNode root = new TrinaryTreeNode() { Value = 5 };
            target.Insert(root, 4);
            target.Insert(root, 9);
            target.Insert(root, 5);
            target.Insert(root, 7);
            target.Insert(root, 2);
            target.Insert(root, 2);

            Assert.AreEqual(5, root.Value);
            Assert.AreEqual(5, root.MiddleChild.Value);
            Assert.AreEqual(4, root.LeftChild.Value);
            Assert.AreEqual(2, root.LeftChild.LeftChild.Value);
            Assert.AreEqual(2, root.LeftChild.LeftChild.MiddleChild.Value);
            Assert.AreEqual(9, root.RightChild.Value);
            Assert.AreEqual(7, root.RightChild.LeftChild.Value);

        }

        [TestMethod]
        public void Test_TrinaryTreeDelete()
        {
            Zillow target = new Zillow();

            // delete a left node.
            TrinaryTreeNode root = new TrinaryTreeNode() { Value = 5 };
            target.Insert(root, 4);
            target.Insert(root, 9);
            target.Insert(root, 5);
            target.Insert(root, 7);
            target.Insert(root, 2);
            target.Insert(root, 2);

            TrinaryTreeNode actual = target.Delete(root, root.LeftChild.LeftChild.MiddleChild);
            Assert.IsNull(root.LeftChild.LeftChild.MiddleChild);

            // delete a node which has child node
            root = new TrinaryTreeNode() { Value = 5 };
            target.Insert(root, 3);
            target.Insert(root, 4);
            target.Insert(root, 9);
            target.Insert(root, 5);
            target.Insert(root, 7);
            target.Insert(root, 2);
            target.Insert(root, 2);

            actual = target.Delete(root, root.LeftChild);
            Assert.AreEqual(2, root.LeftChild.Value);


            // delete a node is not in the tree
            root = new TrinaryTreeNode() { Value = 5 };
            target.Insert(root, 4);
            target.Insert(root, 9);
            target.Insert(root, 5);
            target.Insert(root, 7);
            target.Insert(root, 2);
            target.Insert(root, 2);
            actual = target.Delete(root, new TrinaryTreeNode());

            Assert.AreEqual(5, root.Value);
            Assert.AreEqual(5, root.MiddleChild.Value);
            Assert.AreEqual(4, root.LeftChild.Value);
            Assert.AreEqual(2, root.LeftChild.LeftChild.Value);
            Assert.AreEqual(2, root.LeftChild.LeftChild.MiddleChild.Value);
            Assert.AreEqual(9, root.RightChild.Value);
            Assert.AreEqual(7, root.RightChild.LeftChild.Value);

        }

    }
}
