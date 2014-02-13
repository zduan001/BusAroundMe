using Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OtherQuestions.cs;
using System.Collections.Generic;
using System.IO;

namespace OtherQuestionsTest
{
    [TestClass]
    public class OtherQuestionTest
    {
        [TestMethod]
        public void Test_001_Print2BST()
        {
            _001_Print2BST target = new _001_Print2BST();
            TreeNode.index = 0;
            TreeNode root1 = TreeNode.CreatTree(new string[] { "5", "#", "9", "#", "11", "#", "#" });
            TreeNode.index = 0;
            TreeNode root2 = TreeNode.CreatTree(new string[] { "4", "2", "#", "#", "8", "#", "10", "#", "#" });
            List<int> actual = target.PrintOut2BSTTrees(root1, root2);
            for (int i = 0; i < actual.Count - 1; i++)
            {
                Assert.IsTrue(actual[i] < actual[i + 1]);
            }
        }

        [TestMethod]
        public void Test_002_FindAllFactors()
        {
            _002_FindAllFactors target = new _002_FindAllFactors();
            int n = 100;
            List<KeyValuePair<int, int>> actual = target.FindAllFactors(n);
            Assert.AreEqual(5, actual.Count);

            for (int i = 0; i < actual.Count; i++)
            {
                int left = actual[0].Key;
                int right = actual[0].Value;

                Assert.AreEqual(left * right, n);
            }

            // Since I still have problem to figure out the correct algorithm fail the test now.
            Assert.AreEqual(1, 2);
        }

        [TestMethod]
        public void Test_002_FindAllFactorsII()
        {
            _002_FindAllFactors target = new _002_FindAllFactors();
            int n = 12;
            List<List<int>> actual = target.FindAllFactorsII(n);
        }

        [TestMethod]
        public void Test_003_IsWord()
        {
            _003_IsWord target = new _003_IsWord();
            HashSet<string> dict = new HashSet<string>() { "this", "is", "desk", "top", "desktop" };
            List<string> actual = target.FindAllSentences("thisisdesktop", dict);
            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void Test_003_IsWordI()
        {
            _003_IsWord target = new _003_IsWord();
            HashSet<string> dict = new HashSet<string>() { "this", "is", "desk", "top", "desktop" };
            bool actual = target.IsWord("thisisdesktop", dict);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_003_IsWordII()
        {
            _003_IsWord target = new _003_IsWord();
            HashSet<string> dict = new HashSet<string>() { "this", "is", "desk", "top", "desktop" };
            bool actual = target.IsWordRecursive("thisisdesktop", dict);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Test_004_SetConflictBit()
        {
            _004_SetConflictBit target = new _004_SetConflictBit();
            _004_SetConflictBit.Event event1 = new _004_SetConflictBit.Event() { start = 1, end = 2, conflict = false };
            _004_SetConflictBit.Event event2 = new _004_SetConflictBit.Event() { start = 3, end = 4, conflict = false };
            _004_SetConflictBit.Event event3 = new _004_SetConflictBit.Event() { start = 5, end = 6, conflict = false };
            _004_SetConflictBit.Event event4 = new _004_SetConflictBit.Event() { start = 7, end = 9, conflict = false };
            _004_SetConflictBit.Event event5 = new _004_SetConflictBit.Event() { start = 8, end = 10, conflict = false };
            _004_SetConflictBit.Event event6 = new _004_SetConflictBit.Event() { start = 11, end = 12, conflict = false };
            _004_SetConflictBit.Event event7 = new _004_SetConflictBit.Event() { start = 13, end = 14, conflict = false };
            List<_004_SetConflictBit.Event> events = new List<_004_SetConflictBit.Event>() { event1, event2, event3, event4, event5, event6, event7 };
            target.ProcessConflicts(events);

            Assert.IsFalse(event1.conflict);
            Assert.IsFalse(event2.conflict);
            Assert.IsFalse(event3.conflict);
            Assert.IsTrue(event4.conflict);
            Assert.IsTrue(event5.conflict);
            Assert.IsFalse(event6.conflict);
            Assert.IsFalse(event7.conflict);
        }

        [TestMethod]
        public void Test_005_OrderofAlphabetical()
        {
            _005_OrderofAlphabetical target = new _005_OrderofAlphabetical();

            StreamReader reader = new StreamReader(@"..\..\..\Console2\G_Code\webster-dictionary.txt");
            List<string> input = new List<string>();
            string sLine = string.Empty;
            while (sLine != null)
            {
                sLine = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(sLine))
                {
                    input.Add(sLine.ToLower());
                }
            }
            reader.Close();

            List<KeyValuePair<char, int>> actual = target.FindOrder(input);
        }

        [TestMethod]
        public void Tet_009_Allpossibility()
        {
            _009_Allpossibility target = new _009_Allpossibility();
            int[] input = { 5, 5, 10, 2, 3 };
            List<List<int>> actual = target.AllSum(input, 15);
            Assert.AreEqual(4, actual.Count);
        }

        [TestMethod]
        public void Tet_009_AllpossibilityDp()
        {
            _009_Allpossibility target = new _009_Allpossibility();
            int[] input = { 5, 5, 10, 2, 3 };
            List<List<int>> actual = target.AllSumDP(input, 15);
            Assert.AreEqual(4, actual.Count);
        }
        [TestMethod]
        public void Tet_009_AllpossibilityDpOneArray()
        {
            _009_Allpossibility target = new _009_Allpossibility();
            int[] input = { 5, 5, 10, 2, 3 };
            List<List<int>> actual = target.AllSumDPOneArray(input, 15);
            Assert.AreEqual(4, actual.Count);
        }

        [TestMethod]
        public void Test_011_FindAnagram()
        {
            _011_FindAnagram target = new _011_FindAnagram();
            string s = "abcdbcsdaqdbahs";
            string pattern = "scdcb";
            string actual = target.FindAnagram(s, pattern);
        }

        [TestMethod]
        public void Test_012_MultiplicatrionWithoutTimes()
        {
            _012_MultiplicatrionWithoutTimes target = new _012_MultiplicatrionWithoutTimes();
            int x = 7; int y = 9;
            long actual = target.mult(x, y);
            Assert.AreEqual(7 * 9, actual);
        }

        [TestMethod]
        public void Test_013_SeparatorPositiveandNegative()
        {
            _013_SeparatorPositiveandNegative target = new _013_SeparatorPositiveandNegative();
            int[] input = new int[] { -4, 3, -6, 2, 8, 9 };
            target.Separate(input);
        }

        [TestMethod]
        public void Test_015_SodukoSolver()
        {
            _015_SodukoSolver target = new _015_SodukoSolver();

            int[,] board = new int[,] { 
                { 7, -1, -1, -1, -1, -1, -1, -1, -1}, 
                { -1, -1, 2, 5, -1, -1, -1, -1, -1 }, 
                { -1, 6, -1, -1, 8, -1, 1, -1, -1 }, 
                { -1, 4, -1, -1, -1, 6, -1, -1, -1 }, 
                { -1, -1, -1, -1, 3, 4, 6, -1, -1 }, 
                { -1, -1, -1, 0, -1, -1, -1, 2, -1 }, 
                { -1, -1, 1, -1, -1, -1, -1, 5, 7 }, 
                { -1, -1, 7, 4, -1, -1, -1, 0, -1 }, 
                { -1, 8, -1, -1, -1, -1, 3, -1, -1 }};
            target.SudokuSolver(board, 0, 0, 0);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    System.Console.Write(board[i, j].ToString() + ", ");
                }
                System.Console.Write("\n");
            }
        }

        [TestMethod]
        public void Test_016_FindAllPath()
        {
            _016_FindAllPath target = new _016_FindAllPath();
            GraphNode n1 = new GraphNode(1);
            GraphNode n2 = new GraphNode(2);
            GraphNode n3 = new GraphNode(3);
            GraphNode n4 = new GraphNode(4);
            GraphNode n5 = new GraphNode(5);
            GraphNode n6 = new GraphNode(6);

            n1.Neighbors = new List<GraphNode>() { n2, n3 };
            n2.Neighbors = new List<GraphNode>() { n3, n4, n5 };
            n3.Neighbors = new List<GraphNode>() { n4, n5 };
            n4.Neighbors = new List<GraphNode>() { n5, n6 };
            n5.Neighbors = new List<GraphNode>() { n6 };

            List<GraphNode> graph = new List<GraphNode>() { n1, n2, n3, n4, n5, n6 };

            List<List<int>> actual = target.FindAllPath(graph, n1, n6);
        }

        [TestMethod]
        public void Test_017_MinDiff()
        {
            _017_MinDiff target = new _017_MinDiff();
            int[] a = { 1, 2, 3, 5 };
            int[] b = { -3, 4, 6 };
            int[] c = { 4, 6, 6, 9 };

            int actual = target.FindMinDiff(a, b, c);
            Assert.AreEqual(2, actual);

            int[] a1 = { 1, 2, 3, };
            int[] b1 = { 2, 3, 4 };
            int[] c1 = { 6, 7, 8, };
            actual = target.FindMinDiff(a1, b1, c1);
            Assert.AreEqual(6, actual);

            int[] a2 = { -9, -5, -10, };
            int[] b2 = { 0 };
            int[] c2 = { 8, 2, 5, };
            actual = target.FindMinDiff(a2, b2, c2);
            Assert.AreEqual(14, actual);

            int[] a3 = { 1, 2, };
            int[] b3 = { 6, 5, 4 };
            int[] c3 = { 7, 9, 8 };
            actual = target.FindMinDiff(a3, b3, c3);
            Assert.AreEqual(10, actual);

            int[] a4 = { 2, 2 };
            int[] b4 = { 5, 5, 5 };
            int[] c4 = { 8, 8, 8, 8, 8 };
            actual = target.FindMinDiff(a4, b4, c4);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void Test_018_FidnRegions()
        {
            _018_FidnRegions target = new _018_FidnRegions();
            int[,] input = { { 8, -1, 4 }, { 3, -1, -1 }, { 5, 2, 2 } };

            int actual = target.CountRegions(input, 3);
            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void Test_019_FindMatrixRegion()
        {
            _019_FindMatrixRegion target = new _019_FindMatrixRegion();
            int[,] input = { { 0, 0, 0, 0, 0 }, { 0, 1, 1, 1, 0 }, { 0, 1, 0, 1, 0 }, { 0, 1, 1, 1, 0 }, { 0, 0, 0, 0, 0 } };

            int actual = target.CountRegions(input, 0, 4);
        }

        [TestMethod]
        public void Test_020_CanJump()
        {
            OtherQuestion target = new OtherQuestion();
            int[] input = { 1, 0, 2, 5, 2, 1 };
            bool actual = target._020_CanJump(input, 5);
            Assert.IsTrue(actual);

            actual = target._020_canJumpII(input, 5);
            Assert.IsTrue(actual);

            input = new int[] { 1, 0, 2, 5, 2, 2, 3, 4 };
            actual = target._020_CanJump(input, 5);
            Assert.IsFalse(actual);

            actual = target._020_canJumpII(input, 5);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Test_021_LongestCommonPrefix()
        {
            OtherQuestion target = new OtherQuestion();
            string s1 = "abcdef";
            string s2 = "abcdhys";
            string s3 = "abcdxxxx";
            string s4 = "ablsjfslfj";
            List<string> input = new List<string> { s1, s2, s3 };
            string actual = target._021_LongestCommonPrefix(input);
            Assert.AreEqual("abcd", actual);
        }

        [TestMethod]
        public void Test_022_LongestIncrease()
        {
            OtherQuestion target = new OtherQuestion();
            int[] input = new int[] { 2, 1, 5, 4, 3, 4, 6, 1 };
            int startIndex = -1;
            int endIndex = -1;
            int length = -1;
            target._022_LongestIncrease(input, ref startIndex, ref endIndex, ref length);

            Assert.AreEqual(0, startIndex);
            Assert.AreEqual(6, endIndex);
            Assert.AreEqual(4, length);
        }


        [TestMethod]
        public void Test_023_Longest_UniqueString()
        {
            OtherQuestion target = new OtherQuestion();
            string s = "aaaabbbcccccccccececececececece";

            int actual = target._023_Longest_UniqueString(s);

            Assert.AreEqual(24, actual);
        }

        [TestMethod]
        public void Test_024_SortLinkedList()
        {
            OtherQuestion target = new OtherQuestion();
            int[] inputArray = new int[] { 8, 7, 9, 6, 5, 4, 7 };
            LinkListNode head = LinkListNode.CreateLinkList(inputArray);
            LinkListNode actual = target._024_SortLinkedList(head);


        }

        [TestMethod]
        public void Test_025_ArrayIterator()
        {
            int[] inputArray = new int[] { 1, 2, 3, 5, 2, 1 };
            OtherQuestion.ArrayIterator target = new OtherQuestion.ArrayIterator(inputArray);

            //2
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(2, target.GetNext());

            //5
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(5, target.GetNext());

            //5
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(5, target.GetNext());

            //5
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(5, target.GetNext());

            //1
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(1, target.GetNext());

            //1
            Assert.IsTrue(target.HasNext());
            Assert.AreEqual(1, target.GetNext());

            Assert.IsFalse(target.HasNext());
        }

        [TestMethod]
        public void Test_025_Inversion()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            OtherQuestion target = new OtherQuestion();
            int actual = target._025_CounterTheInversion(input);

            input = new int[] {2,1};
            actual = target._025_CounterTheInversion(input);

            input = new int[] { 1, 2, 3, 5, 4, 6, 7 };
            actual = target._025_CounterTheInversion(input);
        }

        [TestMethod]
        public void Test_026_MatchBotsNuts()
        {
            int[] nuts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] bots = new int[] { 8, 2, 6, 4, 3, 1, 7, 5 };
            OtherQuestion target = new OtherQuestion();
            target._026_MatchBotNut(nuts, bots, 0, nuts.Length-1);

        }

        [TestMethod]
        public void Test_023_Knapsack()
        {
            OtherQuestion target = new OtherQuestion();
            //int[] weight = { 6, 5, 3, 10 };
            //int[] value = { 2, 3, 4, 8 };
            //int capacity = 9;
            int[] weight = { 2, 3, 5, 4, 2, 3 };
            int[] value = { 7, 4, 8, 6, 2, 5 };
            int capacity = 9;
            int acutal = target._023_Knapsack(value, weight, capacity);

            Assert.AreEqual(18,acutal);
        }

        [TestMethod]
        public void Test_027_CanbeEven()
        {
            OtherQuestion target = new OtherQuestion();
            int[] input = { 9, 3, 11, 6, 55, 9, 7, 3, 29, 16, 4, 4, 20, 11, 6, 6, 8, 8, 4, 10, 11, 16, 10, 6, 10, 3, 5, 6, 4, 14, 5, 29, 15, 3, 18, 7, 7, 20, 4, 9, 3, 11, 38, 6, 3, 13, 12, 5, 10, 3, 3 };
            bool actual = target._027_CanVoteBeEven(input);
            Assert.IsTrue(actual);

            input = new int[]{ 2,3,5,10};
            actual = target._027_CanVoteBeEven(input);
            Assert.IsTrue(actual);

            input = new int[] { 2, 3, 5, 11 };
            actual = target._027_CanVoteBeEven(input);
            Assert.IsFalse(actual);
        }
    }

}

