using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace LeetCodeCSharp
{
    public class Tag_BinaryTree
    {
        /// <summary>
        /// http://discuss.leetcode.com/questions/1189/sum-root-to-leaf-numbers
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int q_001_SumRootToLeaf(TreeNode root)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int sum = 0;
            s.Push(root);
            TreeNode previous = null;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (tmp.LeftChild != null &&
                    tmp.LeftChild != previous &&
                    (tmp.RightChild != previous || tmp.RightChild == null))
                {
                    s.Push(tmp.LeftChild);
                }
                else if (previous != null &&
                    previous == tmp.LeftChild &&
                    tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                }
                else
                {
                    if (tmp.LeftChild == null && tmp.RightChild == null)
                    {
                        sum = AddSum(sum, s);
                    }
                    s.Pop();
                    previous = tmp;
                }
            }

            return sum;
        }

        private int AddSum(int sum, Stack<TreeNode> s)
        {
            int tmp = 0;
            Stack<TreeNode> holder = new Stack<TreeNode>();
            int i = 0;
            while (s.Count != 0)
            {
                tmp = tmp + s.Peek().Value * (int)Math.Pow(10, i);
                holder.Push(s.Pop());
                i++;
            }

            while (holder.Count != 0)
            {
                s.Push(holder.Pop());
            }

            return sum + tmp;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/115/convert-binary-search-tree-bst-to-sorted-doubly-linked-list
        /// </summary>
        /// <param name="root"></param>
        public Tuple<TreeNode, TreeNode> q_002_ConvertTreetoDoubleLinkedList(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            if (root.LeftChild == null && root.RightChild == null)
            {
                return new Tuple<TreeNode, TreeNode>(root, root);
            }

            Tuple<TreeNode, TreeNode> left = null;
            Tuple<TreeNode, TreeNode> right = null;

            if (root.LeftChild != null)
            {
                left = q_002_ConvertTreetoDoubleLinkedList(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                right = q_002_ConvertTreetoDoubleLinkedList(root.RightChild);
            }

            TreeNode leftNode = null;
            TreeNode rightNode = null;

            if (left != null)
            {
                leftNode = left.Item1;
                left.Item2.RightChild = root;
                root.LeftChild = left.Item2;
            }
            else
            {
                leftNode = root;
            }

            if (right != null)
            {
                root.RightChild = right.Item1;
                right.Item1.LeftChild = root;
                rightNode = right.Item2;
            }
            else
            {
                rightNode = root;
            }

            return new Tuple<TreeNode, TreeNode>(leftNode, rightNode);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/49/binary-tree-level-order-traversal
        /// use DFS search.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<List<int>> q_003_PrintTreeLevel(TreeNode root, int maxHeight)
        {
            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < maxHeight; i++)
            {
                List<int> tmp = new List<int>();
                Print(root, i, tmp);
                res.Add(tmp);
            }
            return res;
        }

        private void Print(TreeNode root, int level, List<int> output)
        {
            if (root == null)
            {
                return;
            }

            if (level == 0 && root != null)
            {
                output.Add(root.Value);
                return;
            }

            Print(root.LeftChild, level - 1, output);
            Print(root.RightChild, level - 1, output);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/55/saving-a-binary-search-tree-to-a-file
        /// this code assume a preorder travesal is given.
        /// since this is BST, preorder is given, 
        /// 1. get root node, separate left tree and right tree.
        /// 2. recursively work on the left and right tree. 
        /// 3. end when only one element in the array. // start == end;
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public TreeNode q_004_DeserializeBST(int[] input, int start, int end)
        {
            if (start > end) return null;
            if (start == end) return new TreeNode(input[start]);
            int i = 0;
            for (i = start + 1; i <= end; i++)
            {
                if (input[i] > input[start])
                {
                    break;
                }
            }
            TreeNode root = new TreeNode(input[start]);
            root.LeftChild = q_004_DeserializeBST(input, start + 1, i - 1);
            root.RightChild = q_004_DeserializeBST(input, i, end);
            return root;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/278/path-sum
        /// </summary>
        /// <param name="root"></param>
        public bool q_005_PathSum(TreeNode root, int sum)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            int current = root.Value;
            s.Push(root);
            TreeNode previous = null;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (tmp.LeftChild != null &&
                    tmp.LeftChild != previous &&
                    (tmp.RightChild == null || tmp.RightChild != previous))
                {
                    s.Push(tmp.LeftChild);
                    current += tmp.LeftChild.Value;
                }
                else if (previous != null &&
                    previous == tmp.LeftChild &&
                    tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    current += tmp.RightChild.Value;
                }
                else
                {
                    s.Pop();
                    previous = tmp;
                    current -= tmp.Value;
                }

                if (current == sum)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Oj
    {
        /// <summary>
        /// http://discuss.leetcode.com/questions/202/merge-two-sorted-lists
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        public LinkListNode p_001_Merge2SortedList(LinkListNode l1, LinkListNode l2)
        {
            LinkListNode dummyheader = new LinkListNode();
            LinkListNode tail = dummyheader;
            LinkListNode tmp = null;

            while (l1 != null && l2 != null)
            {
                if (l1.Value <= l2.Value)
                {
                    tmp = l1;
                    l1 = l1.Next;
                }
                else
                {
                    tmp = l2;
                    l2 = l2.Next;
                }

                tail.Next = tmp;
                tail = tail.Next;
            }

            if (l1 != null)
            {
                tail.Next = l1;
            }
            else
            {
                tail.Next = l2;
            }

            return dummyheader.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/201/valid-parentheses
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool p_002_ValidateParentheses(string input)
        {
            Stack<char> s = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' ||
                    input[i] == '[' ||
                    input[i] == '{')
                {
                    s.Push(input[i]);
                }
                else if (input[i] == ']')
                {
                    if (s.Peek() == '[')
                    {
                        s.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (input[i] == ')')
                {
                    if (s.Peek() == '(')
                    {
                        s.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (input[i] == '}')
                {
                    if (s.Peek() == '{')
                    {
                        s.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return s.Count == 0;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/227/anagrams
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> p_003_anagrams(string input)
        {
            char[] charArray = input.ToCharArray();
            List<string> res = new List<string>();
            anagramWorkingmethod(charArray, 0, res);
            return res;
        }

        private void anagramWorkingmethod(char[] input, int index, List<string> res)
        {
            if (index == input.Length - 1)
            {
                string s = new string(input);
                res.Add(s);
                return;
            }

            for (int i = index; i < input.Length; i++)
            {
                Swap(input, index, i);
                anagramWorkingmethod(input, index + 1, res);
                Swap(input, index, i);
            }
        }

        private void Swap(char[] input, int i, int j)
        {
            char c = input[i];
            input[i] = input[j];
            input[j] = c;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/266/decode-ways
        /// CAUTION: need to discuss the "01233" case. if a string start with 0
        /// then we should throw exception. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_004_DecodeWay(string input)
        {
            if (input.Length < 2)
            {
                return 1;
            }
            int res = 0;
            if (input.Length >= 2)
            {
                int value = int.Parse(input.Substring(0, 2));
                if (value <= 26 && value != 10 && value != 20)
                {
                    res += p_004_DecodeWay(input.Substring(1));
                    res += p_004_DecodeWay(input.Substring(2));
                }

                if (value > 26)
                {
                    res = p_004_DecodeWay(input.Substring(1));
                }

                if (value == 10 || value == 20)
                {
                    res = p_004_DecodeWay(input.Substring(2));
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/196/longest-common-prefix
        /// assume only a, b, ....z in strings
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string p_005_FindLongestCommonPrefix(string[] input)
        {
            TrieNode node = new TrieNode();
            int max_length = 0;
            string longStr = string.Empty;

            foreach (string s in input)
            {
                TrieNode tmp = node;

                for (int i = 0; i < s.Length; i++)
                {
                    int index = s[i] - 'a';
                    if (tmp.nodes[index] != null)
                    {
                        if (i > max_length)
                        {
                            max_length = i;
                            longStr = s.Substring(0, i + 1);
                        }
                        tmp = tmp.nodes[index];
                    }
                    else
                    {
                        tmp.nodes[index] = new TrieNode();
                        tmp = tmp.nodes[index];
                    }
                }
            }
            return longStr;
        }

        public class TrieNode
        {
            public TrieNode()
            {
                nodes = new TrieNode[26];
            }
            public TrieNode[] nodes;
            public bool IsWord;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/112/convert-sorted-list-to-binary-search-tree
        /// </summary>
        public TreeNode p_005_CreateTreeFromList(LinkListNode node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Next == null)
            {
                return new TreeNode(node.Value);
            }

            LinkListNode faster = node.Next;
            LinkListNode slower = node;
            while (faster.Next != null && faster.Next.Next != null)
            {
                faster = faster.Next.Next;
                slower = slower.Next;
            }
            LinkListNode nextHeader = slower.Next;
            slower.Next = null;
            TreeNode left = p_005_CreateTreeFromList(node);
            TreeNode righ = p_005_CreateTreeFromList(nextHeader.Next);
            TreeNode root = new TreeNode(nextHeader.Value);
            root.LeftChild = left;
            root.RightChild = righ;
            return root;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/258/remove-duplicates-from-sorted-list
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public LinkListNode p_006_RemoveDup(LinkListNode node)
        {
            if (node == null)
            {
                return null;
            }

            int cur = node.Value;
            LinkListNode slower = node;
            LinkListNode faster = node.Next;
            while (faster != null)
            {
                if (faster.Value != cur)
                {
                    slower.Next = faster;
                    slower = faster;
                    cur = slower.Value;
                }
                else
                {
                    faster = faster.Next;
                }
            }
            slower.Next = null;
            return node;
        }

        public LinkListNode p_006_RemoveDupII(LinkListNode node)
        {
            LinkListNode tmp = node;
            while (tmp != null)
            {
                if (tmp.Next != null && tmp.Value == tmp.Next.Value)
                {
                    tmp.Next = tmp.Next.Next;
                }
                else
                {
                    tmp = tmp.Next;
                }
            }
            return node;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/236/spiral-matrix-ii
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="size"></param>
        public void p_007_SpiralMatrixII(int[,] matrix, int size)
        {
            int topIndex = 0;
            int bottomIndex = size - 1;
            int leftIndex = 0;
            int rightIndex = size - 1;
            int direction = 0;

            int x = 0;
            int y = 0;

            for (int i = 0; i < size * size; i++)
            {
                matrix[x, y] = i;
                switch (direction)
                {
                    case 0:
                        y++;
                        if (y > rightIndex)
                        {
                            y--;
                            direction = 1;
                            topIndex++;
                            x++;
                        }
                        break;
                    case 1:
                        x++;
                        if (x > bottomIndex)
                        {
                            x--;
                            direction = 2;
                            rightIndex--;
                            y--;
                        }
                        break;
                    case 2:
                        y--;
                        if (y < leftIndex)
                        {
                            y++;
                            direction = 3;
                            bottomIndex--;
                            x--;
                        }
                        break;
                    case 3:
                        x--;
                        if (x < topIndex)
                        {
                            x++;
                            direction = 0;
                            leftIndex++;
                            y++;
                        }
                        break;
                    default:
                        break;
                }

            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/239/unique-paths-ii
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public int p_008_UniquePath(int[,] matrix)
        {
            int heigth = matrix.GetLength(0);
            int width = matrix.GetLength(1);
            int[,] tracker = new int[heigth, width];

            //assume start and end point is not blocked.
            tracker[0, 0] = 1;
            for (int j = 1; j < width; j++)
            {
                if (matrix[0, j] == 1)
                {
                    tracker[0, j] = 0;
                }
                tracker[0, j] = tracker[0, j - 1];
            }
            for (int i = 1; i < heigth; i++)
            {
                if (matrix[i, 0] == 1)
                {
                    tracker[i, 0] = 0;
                }
                tracker[i, 0] = tracker[i - 1, 0];
            }

            for (int i = 1; i < width; i++)
            {
                for (int j = 1; j < heigth; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        tracker[i, j] = 0;
                    }
                    else
                    {
                        tracker[i, j] = tracker[i - 1, j] + tracker[i, j - 1];
                    }
                }
            }

            return tracker[heigth - 1, width - 1];
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/231/maximum-subarray
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_009_FindMaximumSubArray(int[] input)
        {
            int maxSum = 0;
            int sum = input[0];
            if (sum > 0)
            {
                maxSum = sum;
            }

            for (int i = 1; i < input.Length; i++)
            {
                if (sum < 0)
                {
                    sum = input[i];
                }
                else
                {
                    sum += input[i];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            //I can return start and end index too. 
            return maxSum;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/261/partition-list
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public LinkListNode p_010_PartitionList(LinkListNode node, int value)
        {
            LinkListNode dummyHeaderLess = new LinkListNode();
            LinkListNode dummyHeaderMore = new LinkListNode();

            LinkListNode less = dummyHeaderLess;
            LinkListNode more = dummyHeaderMore;
            LinkListNode tmp;
            while (node != null)
            {
                tmp = node;
                node = node.Next;
                tmp.Next = null;

                if (tmp.Value < value)
                {
                    less.Next = tmp;
                    less = less.Next;
                }
                else
                {
                    more.Next = tmp;
                    more = more.Next;
                }
            }

            less.Next = dummyHeaderMore.Next;

            return dummyHeaderLess.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/200/remove-nth-node-from-end-of-list
        /// </summary>
        /// <param name="node"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public LinkListNode p_011_RemoveaNthNode(LinkListNode node, int n)
        {
            return null;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/209/divide-two-integers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int p_012_Divid2Integers(int a, int b)
        {
            int i = 0;
            int res = 0;

            while (a > b)
            {
                i = 0;
                int c = b;
                while (a > c)
                {
                    i++;
                    c = b << i;
                }
                a = a - (c >> 1);
                res += 1 << (i - 1);
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/223/jump-game-ii
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_013_JumpGameII(int[] input)
        {
            int[] tracker = new int[input.Length];
            for (int i = 1; i < tracker.Length; i++)
            {
                tracker[i] = int.MaxValue;
            }

            for (int i = 1; i < tracker.Length; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < i; j++)
                {
                    if ((input[j] + j) >= i)
                    {
                        min = min < tracker[j] + 1 ? min : tracker[j] + 1;
                    }
                }
                tracker[i] = min;
            }

            return tracker[input.Length - 1];
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/189/add-two-numbers
        /// I assume l1 and l2 have same length.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public LinkListNode p_014_Add2Numbers(LinkListNode l1, LinkListNode l2)
        {
            LinkListNode res;
            if (l1.Next == null && l2.Next == null)
            {
                res = new LinkListNode();
                res.Value = l1.Value + l2.Value;
                return res;
            }

            LinkListNode node = p_014_Add2Numbers(l1.Next, l2.Next);
            int carry = node.Value / 10;
            node.Value = node.Value % 10;

            res = new LinkListNode();
            res.Value = carry + l1.Value + l2.Value;
            res.Next = node;

            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/243/add-binary
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public string p_015_AddBinary(string s1, string s2)
        {
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/240/minimum-path-sum
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_016_MinimumPathSum(int[,] input)
        {
            int height = input.GetLength(0);
            int width = input.GetLength(1);
            int[,] tracker = new int[height, width];

            tracker[0, 0] = input[0, 0];
            for (int i = 1; i < height; i++)
            {
                tracker[i, 0] = tracker[i - 1, 0] + input[i, 0];
            }

            for (int j = 1; j < width; j++)
            {
                tracker[0, j] = tracker[0, j - 1] + input[0, j];
            }

            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    int sum = tracker[i - 1, j] < tracker[i, j - 1] ? tracker[i - 1, j] : tracker[i, j - 1];
                    tracker[i, j] = sum + input[i, j];
                }
            }
            return tracker[height - 1, width - 1];
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/197/3sum-closest
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_017_Closest(int[] input)
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        public void p_018_PopulateNextRight(TreeNode root, TreeNode parent)
        {
            if (root == null) return;

            if (parent != null)
            {
                if (root == parent.LeftChild && parent.RightChild != null)
                {
                    root.Next = parent.RightChild;
                }
                else // either 1) root is left child but parent.right is null 2) root is right child
                {
                    if (parent.Next != null)
                    {
                        if (parent.Next.LeftChild != null)
                        {
                            root.Next = parent.Next.LeftChild;
                        }
                        else
                        {
                            root.Next = parent.Next.RightChild;
                        }
                    }
                }
            }

            p_018_PopulateNextRight(root.RightChild, root);
            p_018_PopulateNextRight(root.LeftChild, root);
        }

        /// <summary>
        /// http://leetcode.com/onlinejudge#question_50
        /// </summary>
        /// <param name="d"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double p_019_ImplementPow(double d, int n)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return d;

            double res = p_019_ImplementPow(d, n / 2);
            res = res * res;
            if (n % 2 != 0)
            {
                res = res * d;
            }
            return res;
        }

        /// <summary>
        /// Big number multiplication. 
        /// this method only take the last n (n is the length of num1 and num2)
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int[] p_20_BigNumberTimes(int[] num1, int[] num2)
        {
            if (num1.Length != num2.Length) return null;

            int[] res = new int[num1.Length];
            int carry = 0;
            int tmp = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                carry = 0;
                for (int j = 0; j < num1.Length; j++)
                {
                    if (i + j < res.Length)
                    {
                        tmp = num1[j] * num2[i];
                        tmp += res[i + j];
                        tmp += carry;
                        res[i + j] = tmp % 10;
                        carry = tmp / 10;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// find last (length) digit of math.pow(n, k);
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] p_021_FindLastnDigit(int n, int k, int length)
        {
            int[] num = new int[length];
            num[0] = n;
            if (k == 1)
            {
                return num;
            }
            if (k == 0)
            {
                num[0] = 1;
                return num;
            }

            int[] res = p_021_FindLastnDigit(n, k / 2, length);
            res = p_20_BigNumberTimes(res, res);
            if (k % 2 != 0)
            {
                res = p_20_BigNumberTimes(res, num);
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/142/median-of-two-sorted-arrays
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public int p_022_FindkthNumberin2SortedArray(int[] array1, int[] array2, int k)
        {
            //Assert array2.len != 0
            //Assert k < array1.len + array2.len

            int len1 = array1.Length;
            int len2 = array2.Length;

            int i = len1 * (k - 1) / (len1 + len2);
            int j = k - 1 - i;

            // Assert 0< a1 < len1
            // Assert 0< b1 < len2

            int ai = i == len1 ? int.MaxValue : array1[i];
            int bj = j == len2 ? int.MaxValue : array2[j];
            int ai_1 = i == 0 ? int.MinValue : array1[i - 1];
            int bj_1 = j == 0 ? int.MinValue : array2[j - 1];

            if (ai > bj_1 && ai < bj)
            {
                return ai;
            }
            if (bj > ai_1 && bj < ai)
            {
                return bj;
            }

            int[] tmp = new int[] { };
            if (bj < ai)
            {
                tmp = CopytoArray(array2, j + 1);
                return p_022_FindkthNumberin2SortedArray(array1, tmp, k - j - 1);
            }
            else
            {
                tmp = CopytoArray(array1, i + 1);
                return p_022_FindkthNumberin2SortedArray(tmp, array2, k - i - 1);
            }

        }

        private int[] CopytoArray(int[] input, int index)
        {
            int[] res = new int[input.Length - index];
            for (int i = index; i < input.Length; i++)
            {
                res[i - index] = input[i];
            }
            return res;
        }

        /// <summary>
        /// http://leetcode.com/2011/03/median-of-two-sorted-arrays.html
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public int p_023_FindMedianOf2SortedArray(int[] array1, int[] array2)
        {
            int len1 = array1.Length;
            int len2 = array2.Length;

            int midianIndex = (len1 + len2) / 2;
            if ((len1 + len2) % 2 != 0)
            {
                midianIndex++;
            }
            return p_022_FindkthNumberin2SortedArray(array1, array2, midianIndex);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1223/surrounded-regions
        /// </summary>
        /// <param name="input"></param>
        public void p_024_CaptureSurroundRegion(int[,] input)
        {
            bool[,] tracker = new bool[input.GetLength(0), input.GetLength(1)];
            List<Tuple<int, int>> area;
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    if (input[i, j] == 0 && tracker[i, j] == false)
                    {
                        area = new List<Tuple<int, int>>();
                        travel(i, j, input, tracker, area);
                        if (!ConnectOutSide(area, input.GetLength(0), input.GetLength(1)))
                        {
                            foreach (Tuple<int, int> t in area)
                            {
                                input[t.Item1, t.Item2] = 1;
                            }
                        }
                    }
                }
            }
        }

        private void travel(int i, int j, int[,] input, bool[,] tracker, List<Tuple<int, int>> area)
        {
            if (input[i, j] == 0 && !tracker[i, j])
            {
                tracker[i, j] = true;
                area.Add(new Tuple<int, int>(i, j));

                for (int v = i - 1; v < i + 1; v++)
                {
                    for (int h = j - 1; h < j + 1; h++)
                    {
                        if ((v == i || h == j) && !(v == i && h == j))
                        {
                            if ((v >= 0 && v <= input.GetLength(0)) &&
                                (h >= 0 && h <= input.GetLength(1)) &&
                                (input[v, h] == 0 && !tracker[v, h]))
                            {
                                travel(v, h, input, tracker, area);
                            }
                        }
                    }
                }
            }
        }

        private bool ConnectOutSide(List<Tuple<int, int>> input, int height, int width)
        {
            foreach (Tuple<int, int> item in input)
            {
                if (item.Item1 == 0 || item.Item2 == 0 || item.Item1 == height - 1 || item.Item2 == width - 1)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/271/interleaving-string
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool P_025_InterleavString(string s1, string s2, string t)
        {
            if (t.Length != s1.Length + s2.Length) return false;

            //if(s1 == string.Empty && s2 == string.Empty && t == string.Empty) return true;

            if (s1 == string.Empty && s2 == t) return true;

            if (s2 == string.Empty && s1 == t) return true;

            if (s1.Length > 0 && s1[0] == t[0])
            {
                if (P_025_InterleavString(s1.Substring(1), s2, t.Substring(1)))
                {
                    return true;
                }
            }

            if (s2.Length > 0 && s2[0] == t[0])
            {
                if (P_025_InterleavString(s1, s2.Substring(1), t.Substring(1)))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/212/longest-valid-parentheses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int p_026_LongestValidParentheses(string str)
        {
            Stack<int> s = new Stack<int>();
            int left = 0;
            int max = -1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    s.Push(i);
                }
                else
                {
                    if (s.Count == 0)
                    {
                        left = i;
                    }
                    else
                    {
                        s.Pop();
                        if (s.Count == 0)
                        {
                            max = Math.Max(max, i - left);
                        }
                        else
                        {
                            max = Math.Max(max, s.Peek() - left);
                        }
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// consider the smallest number is 0th
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_027_FindKthSmallestInSortedArray(int[] input, int k, int startIndex, int endIndex)
        {
            if (k > endIndex - startIndex + 1)
            {
                //return -1;// throw exception.
            }

            // swap a random number to the front.
            //Random x = new Random();
            //int swap = x.Next(startIndex, endIndex);

            int left = startIndex + 1;
            int right = endIndex;
            int tmp;

            while (left <= right)
            {
                while (left <= right && input[left] <= input[startIndex]) left++;
                while (right >= left && input[right] >= input[startIndex]) right--;
                if (left < right)
                {
                    tmp = input[left];
                    input[left] = input[right];
                    input[right] = tmp;
                    left++;
                    right--;
                }
            }

            tmp = input[startIndex];
            input[startIndex] = input[left - 1];
            input[left - 1] = tmp;

            if (left - 1 == k)
            {
                return input[left - 1];
            }
            else if (left - 1 > k)
            {
                return p_027_FindKthSmallestInSortedArray(input, k, startIndex, left - 1);
            }
            else
            {
                return p_027_FindKthSmallestInSortedArray(input, k, left, endIndex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double p_028_SQRT(double input)
        {
            double high = input;
            double low = 0.0;
            double current = (high + low) / 2.0;


            while (Math.Abs(current * current - input) > 0.00001)
            {
                if (current * current > input)
                {
                    high = current;
                    current = (current + low) / 2.0;
                }
                else
                {
                    low = current;
                    current = (high + current) / 2.0;
                }
            }

            return current;
        }

        /// <summary>
        /// Newton method f(x) = x^2 -input, f'(x) = 2x;
        /// x1 = x0 - f(x0) / f'(x0);
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public double p_029_SQRT(double input)
        {
            double x1 = input / 2.0;
            double x0 = input;

            while (Math.Abs(x1 - x0) > 0.000001)
            {
                x0 = x1;
                x1 = x0 - (x0 - input / x0) / 2.0;
            }
            return x0;
        }

        /// <summary>
        /// turn "a1a2a3a4b1b2b3b4" -> "a1b1a2b2a3b3a4b4"
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> p_30_ChangeString(List<string> input)
        {
            List<string> end = new List<string>();
            if (input.Count <= 2) return input;

            if (input.Count % 2 == 1) return input; // throw error.

            if ((input.Count / 2) % 2 == 1)
            {
                //copy the last a(n) to right beofr b(n);

                string tmp = input[input.Count / 2 - 1];
                for (int i = input.Count / 2 - 1; i < input.Count - 1; i++)
                {
                    input[i] = input[i + 1];
                }
                input[input.Count - 2] = tmp;

                end = input.GetRange(input.Count - 2, 2);
                input = input.GetRange(0, input.Count - 2);
            }

            //1. mirror middle half;
            Mirror(input, input.Count / 4, input.Count / 4 + input.Count / 2 - 1);

            //2. mirror second quarter;
            Mirror(input, input.Count / 4, input.Count / 2 - 1);

            //3. mirro the third quarter;
            Mirror(input, input.Count / 2, input.Count / 2 + input.Count / 4 - 1);

            // recursive on first half
            List<string> left = p_30_ChangeString(input.GetRange(0, input.Count / 2));

            // recursive on second half.
            List<string> right = p_30_ChangeString(input.GetRange(input.Count / 2, input.Count / 2));

            left.AddRange(right);
            left.AddRange(end);
            return left;

        }

        private void Mirror(List<string> input, int startIndex, int endIndex)
        {
            string tmp;
            while (startIndex <= endIndex)
            {
                tmp = input[startIndex];
                input[startIndex] = input[endIndex];
                input[endIndex] = tmp;
                startIndex++;
                endIndex--;
            }
        }

        /// <summary>
        /// http://blog.csdn.net/v_july_v/article/details/9024123
        /// make sure, negative, overflow...
        /// not a number throw formatException.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_31_atoi(string input)
        {
            int sign = 1;
            int res = 0;
            int i = 0;
            if (input[0] == '-')
            {
                sign = -1;
                i++;
            }
            else if (input[0] == '+')
            {
                sign = +1;
                i++;
            }

            for (; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                if (digit < 0 || digit > 9)
                {
                    throw new FormatException();
                }

                if (sign > 0)
                {
                    if (int.MaxValue / 10 <= res && int.MaxValue % 10 <= digit)
                    {
                        return int.MaxValue;
                    }
                }
                else
                {
                    if (int.MaxValue / 10 <= res && int.MaxValue % 10 <= (digit - 1))
                    {
                        return int.MinValue;
                    }
                }
                res = res * 10 + digit;
            }
            return res * sign;
        }

        /// <summary>

        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public string p_32_Regx(string s, string rule)
        {
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1070/longest-consecutive-sequence
        /// require O(n).
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_33_longestConsecutiveSequence(int[] input)
        {
            Dictionary<int, Tuple<int, int>> tracker = new Dictionary<int, Tuple<int, int>>();
            int maxLen = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!tracker.Keys.Contains(input[i]))
                {
                    int leftKey = input[i];
                    while (tracker.Keys.Contains(leftKey - 1)) leftKey = tracker[leftKey - 1].Item1;
                    int rightKey = input[i];
                    while (tracker.Keys.Contains(rightKey + 1)) rightKey = tracker[rightKey + 1].Item2;
                    maxLen = maxLen > rightKey - leftKey + 1 ? maxLen : rightKey - leftKey + 1;
                    tracker[input[i]] = new Tuple<int, int>(leftKey, rightKey);
                }
            }

            return maxLen;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<List<int>> p_34_ZigZag(TreeNode root)
        {
            List<List<int>> res = new List<List<int>>();
            if (root == null) return res;
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();

            s1.Push(root);
            bool directionLeft = false;

            while (s1.Count != 0)
            {
                List<int> tmp = new List<int>();
                directionLeft = !directionLeft;
                while (s1.Count != 0)
                {
                    TreeNode node = s1.Pop();
                    tmp.Add(node.Value);
                    if (directionLeft)
                    {
                        if (node.LeftChild != null)
                        {
                            s2.Push(node.LeftChild);
                        }
                        if (node.RightChild != null)
                        {
                            s2.Push(node.RightChild);
                        }
                    }
                    else
                    {
                        if (node.RightChild != null)
                        {
                            s2.Push(node.RightChild);
                        }
                        if (node.LeftChild != null)
                        {
                            s2.Push(node.LeftChild);
                        }
                    }
                }
                res.Add(tmp);
                s1 = s2;
                s2 = new Stack<TreeNode>();
            }
            return res;
        }

        public List<string> p_35_PrettyPrint(string input, int width)
        {
            List<string> res = new List<string>();

            while (input.Length > width)
            {
                int i = width - 1;
                while (input[i] != ' ' && input[i + 1] != ' ') i--;
                if (i < 0)
                {
                    // throw exception one word is too long.
                }

                List<string> line = Tokenize(input.Substring(0, i + 1));
                int stringLen = getStringLength(line);

                int diff = width - stringLen;
                int space = diff / (line.Count - 1);
                int mod = diff % (line.Count - 1);

                StringBuilder sb = new StringBuilder();
                foreach (string s in line)
                {
                    if (sb.Length != 0)
                    {
                        for (int j = 0; j < space; j++)
                        {
                            sb.Append(' ');
                        }
                        if (mod > 0)
                        {
                            sb.Append(' ');
                            mod--;
                        }
                    }
                    sb.Append(s);
                }
                res.Add(sb.ToString());
                input = input.Substring(i + 1);

            }
            if (input.Length > 0)
            {
                res.Add(input);
            }
            return res;
        }

        public List<string> Tokenize(string s)
        {
            List<string> res = new List<string>();
            if (string.IsNullOrEmpty(s)) return res;
            int startIndex = 0;
            while (s[startIndex] == ' ') startIndex++;
            int i = startIndex;


            while (i < s.Length)
            {
                while (i < s.Length && s[i] != ' ') i++;
                if (i < s.Length)
                {
                    res.Add(s.Substring(startIndex, i - startIndex));
                }
                else
                {
                    res.Add(s.Substring(startIndex, s.Length - startIndex));
                }

                while (i < s.Length && s[i] == ' ') i++;
                startIndex = i;
            }

            return res;
        }

        public int getStringLength(List<string> input)
        {
            int len = 0;
            foreach (string s in input)
            {
                len += s.Length;
            }
            return len;
        }

        /// <summary>
        /// still pretty print, but try to solve the bug in the last implementation
        /// </summary>
        /// <param name="input"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public List<string> p_036_PrettyPrintII(string input, int width)
        {
            List<string> res = new List<string>();
            List<string> words = new List<string>();
            if (string.IsNullOrEmpty(input)) return res;

            words = Tokenize(input);

            int startIndex = 0;
            int lineLen = 0;

            int i = startIndex;
            while (i < words.Count)
            {
                lineLen += words[i].Length;
                if ((lineLen + i - startIndex) > width)
                {
                    int len = lineLen - words[i].Length;
                    int wordsCount = i - startIndex;
                    int space = (width - len) / (wordsCount - 1);
                    int mod = (width - len) % (wordsCount - 1);

                    StringBuilder sb = new StringBuilder();
                    for (int j = startIndex; j < i; j++)
                    {
                        if (sb.Length != 0)
                        {
                            for (int k = 0; k < space; k++)
                            {
                                sb.Append(' ');
                            }
                            if (mod > 0)
                            {
                                sb.Append(' ');
                                mod--;
                            }
                        }
                        sb.Append(words[j]);
                    }
                    res.Add(sb.ToString());
                    startIndex = i;
                    lineLen = words[i].Length;
                }
                i++;
            }

            StringBuilder sb1 = new StringBuilder();
            for (int j = startIndex; j < words.Count; j++)
            {
                if (sb1.Length != 0)
                {
                    sb1.Append(' ');
                }
                sb1.Append(words[j]);
            }
            res.Add(sb1.ToString());
            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int[] p_037_PlusOne(int[] input)
        {
            int carry = 1;
            int result = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = input[i] + carry;
                carry = result / 10;
                input[i] = result % 10;
            }

            if (carry > 0)
            {
                int[] res = new int[input.Length + 1];
                for (int i = input.Length - 1; i > 0; i--)
                {
                    res[i + 1] = input[i];
                }
                res[0] = carry;
                return res;
            }
            else
            {
                return input;
            }

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/263/merge-sorted-array
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        public void p_038_MergeSortedArray(int[] array1, int n, int[] array2, int m)
        {

            while (n >= 0 && m >= 0)
            {
                if (array1[n] >= array2[m])
                {
                    array1[n + m + 1] = array1[n];
                    n--;
                }
                else
                {
                    array1[n + m + 1] = array2[m];
                    m--;
                }
            }

            if (m > 0)
            {
                for (int i = m; i >= 0; i--)
                {
                    array1[m] = array2[m];
                }
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/253/subsets
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> p_039_AllsubSet(int[] input)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> tmp = new List<int>();

            AllSubSetWorker(input, 0, tmp, res);
            return res;
        }

        private void AllSubSetWorker(int[] input, int level, List<int> tmp, List<List<int>> res)
        {
            if (level == input.Length)
            {
                List<int> cur = new List<int>();
                foreach (int i in tmp)
                {
                    cur.Add(i);
                }
                res.Add(cur);
                return;
            }
            else
            {
                AllSubSetWorker(input, level + 1, tmp, res);
                tmp.Add(input[level]);
                AllSubSetWorker(input, level + 1, tmp, res);
                tmp.Remove(input[level]);
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/257/remove-duplicates-from-sorted-list-ii
        /// </summary>
        /// <param name="node"></param>
        public LinkListNode p_040_RemoveDupFromLinkListII(LinkListNode node)
        {
            LinkListNode dummyHeader = new LinkListNode();
            dummyHeader.Next = node;

            LinkListNode tail = dummyHeader;
            LinkListNode tmp = tail.Next;
            LinkListNode runner = tail.Next;
            while (tail.Next != null)
            {
                while (runner != null && runner.Value == tmp.Value)
                {
                    runner = runner.Next;
                }

                if (runner == null)
                {
                    if (tmp.Next == runner)
                    {
                        tail.Next = tmp;
                        tail = tail.Next;
                    }
                    else
                    {
                        tail.Next = null;
                    }
                }
                else
                {
                    if (tmp.Next == runner)
                    {
                        tail.Next = tmp;
                        tail = tail.Next;
                        tmp = runner;
                    }
                    else
                    {
                        tmp = runner;
                    }
                }
            }

            return dummyHeader.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/252/combinations
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> p_041_GetAllCombination(int n, int k)
        {
            if (k > n) return null;
            if (k <= 0 || n <= 0) return null;

            List<List<int>> res = new List<List<int>>();
            List<int> cur = new List<int>();
            GetallCombinationWorker(n, 1, 0, k, cur, res);
            return res;
        }

        public void GetallCombinationWorker(int n, int level, int count, int k, List<int> cur, List<List<int>> res)
        {
            if (count == k)
            {
                List<int> tmp = new List<int>();
                foreach (int i in cur)
                {
                    tmp.Add(i);
                }
                res.Add(tmp);
                return;
            }
            if (level > n)
            {
                return;
            }

            if (count < k)
            {
                GetallCombinationWorker(n, level + 1, count, k, cur, res);
                cur.Add(level);
                GetallCombinationWorker(n, level + 1, count + 1, k, cur, res);
                cur.Remove(level);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/246/climbing-stairs
        /// </summahttp://discuss.leetcode.com/questions/246/climbing-stairsry>
        /// <param name="n"></param>
        /// <returns></returns>
        public int p_042_ClimbStairs(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            int a1 = 1;
            int a2 = 2;
            int i = 3;
            int res = 0;
            while (i <= n)
            {
                res = a1 + a2;

                i++;
                a1 = a2;
                a2 = res;
            }

            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/233/merge-intervals
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<Tuple<int, int>> p_043_MergeInterval(List<Tuple<int, int>> input)
        {
            if (input.Count == 0) return input;
            List<Tuple<int, int>> res = new List<Tuple<int, int>>();
            Tuple<int, int> cur = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                if (cur.Item2 >= input[i].Item1)
                {
                    if (cur.Item2 < input[i].Item2)
                    {
                        cur = new Tuple<int, int>(cur.Item1, input[i].Item2);
                    }
                }
                else
                {
                    res.Add(cur);
                    cur = input[i];
                }
            }
            res.Add(cur);
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/tags/oj/?sort=active&page=2
        /// </summary>
        /// <param name="input"></param>
        /// <param name="interval"></param>
        /// <returns></returns>
        public List<Tuple<int, int>> p_044_InsertInterval(List<Tuple<int, int>> input, Tuple<int, int> interval)
        {
            int left = interval.Item1;
            int right = interval.Item2;
            List<int> removeList = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (left > input[i].Item1 && left <= input[i].Item2)
                {
                    left = input[i].Item1;
                }

                if (right >= input[i].Item1 && right < input[i].Item2)
                {
                    right = input[i].Item2;
                }
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].Item1 >= left && input[i].Item2 <= right)
                {
                    removeList.Add(i);
                }
            }

            int insertIndex = 0;
            if (removeList.Count > 0)
            {
                input.RemoveRange(removeList[0], removeList.Count);
                insertIndex = removeList[0];
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (left > input[i].Item2)
                    {
                        insertIndex = i + 1;
                    }
                }
            }

            input.Insert(insertIndex, new Tuple<int, int>(left, right));
            return input;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1265/palindrome-partitioning
        /// </summary>
        /// <param name="input"></param>
        public List<List<string>> p_045_palindromePatitioning(string input)
        {
            List<int> cut = new List<int>() { 0 };
            List<List<string>> res = new List<List<string>>();
            PalindromePartitioningWorker(input, cut, 1, res);
            return res;
        }

        private void PalindromePartitioningWorker(string input, List<int> cut, int level, List<List<string>> res)
        {
            if (level == input.Length)
            {
                if (CheckPalindrome(input.Substring(cut[cut.Count - 1])))
                {
                    List<string> tmp = PartitionString(cut, input);
                    res.Add(tmp);
                }
                return;
            }

            PalindromePartitioningWorker(input, cut, level + 1, res);
            if (CheckPalindrome(input.Substring(cut[cut.Count - 1], level - cut[cut.Count - 1])))
            {
                cut.Add(level);
                PalindromePartitioningWorker(input, cut, level + 1, res);
                cut.Remove(level);
            }
        }

        private List<string> PartitionString(List<int> cut, string input)
        {
            List<string> tmp = new List<string>();
            if (cut.Count == 1)
            {
                tmp.Add(input);
                return tmp;
            }
            for (int i = 0; i < cut.Count - 1; i++)
            {
                tmp.Add(input.Substring(cut[i], cut[i + 1] - cut[i]));
            }
            tmp.Add(input.Substring(cut[cut.Count - 1], input.Length - cut[cut.Count - 1]));
            return tmp;

        }

        private bool CheckPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/237/permutation-sequence
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public string p_046_PermutationSequence(int n, int k)
        {
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1108/word-ladder
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public int p_047_WordLadder(string start, string end, HashSet<string> dict)
        {
            HashSet<string> visited = new HashSet<string>();
            int level = 1;
            Queue<string> q = new Queue<string>();
            q.Enqueue(start);
            visited.Add(start);
            q.Enqueue(string.Empty);
            while (q.Count != 0)
            {
                string tmp = q.Dequeue();
                if (tmp == string.Empty)
                {
                    if (q.Count != 0)
                    {
                        q.Enqueue(string.Empty);
                        level++;
                        continue;
                    }
                }
                for (int i = 0; i < tmp.Length; i++)
                {
                    char[] cArray = tmp.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        cArray[i] = c;
                        string s = new string(cArray);
                        if (s == end)
                        {
                            return level + 1;
                        }
                        if (!visited.Contains(s) && dict.Contains(s))
                        {
                            q.Enqueue(s);
                            visited.Add(s);
                        }
                    }

                }
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public LinkListNode p_048_ReverseLinkListII(LinkListNode head, int m, int n)
        {
            LinkListNode dummyHeader = new LinkListNode();
            dummyHeader.Next = head;
            LinkListNode firstTail;
            LinkListNode secondHeader;
            LinkListNode secondTail;
            LinkListNode thirdHeader;

            LinkListNode tmp = dummyHeader;
            int i = 1;
            for (i = 1; i < m; i++)
            {
                if (tmp == null)
                {
                    // throw exception.
                }
                tmp = tmp.Next;
            }
            firstTail = tmp;
            secondHeader = firstTail.Next;

            for (; i <= n; i++)
            {
                if (tmp == null)
                {
                    // throw exception.
                }
                tmp = tmp.Next;
            }
            secondTail = tmp;
            thirdHeader = tmp.Next;

            secondTail.Next = null;

            secondTail = secondHeader;

            // revers middle part

            LinkListNode middle;
            LinkListNode newSecondHeader = null;

            while (secondHeader != null)
            {
                middle = secondHeader;
                secondHeader = secondHeader.Next;
                middle.Next = newSecondHeader;
                newSecondHeader = middle;
            }

            firstTail.Next = newSecondHeader;
            secondTail.Next = thirdHeader;

            return dummyHeader.Next;

        }



        /// <summary>
        /// http://discuss.leetcode.com/questions/193/container-with-most-water
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_050_ContainerOfMostwater(int[] input)
        {
            int max = 0;
            int i = 0;
            int j = input.Length - 1;
            int tmp = 0;
            while (i < j)
            {
                tmp = Math.Min(input[i], input[j]) * (j - i);
                max = max > tmp ? max : tmp;
                if (input[i] < input[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return max;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/154/longest-substring-without-repeating-characters
        /// </summary>
        /// <param name="s"></param>
        public int p_051_LongestSubstringWithoutRepeating(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int startIndex = 0;
            int maxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!set.Contains(s[i]))
                {
                    set.Add(s[i]);
                    maxLen = maxLen > i - startIndex + 1 ? maxLen : i - startIndex + 1;
                }
                else
                {
                    while (s[startIndex] != s[i])
                    {
                        set.Remove(s[startIndex]);
                        startIndex++;
                    }
                }
            }
            return maxLen;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/195/roman-to-integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_051_RometoInt(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            int sum = dict[input[input.Length - 1]];
            for (int i = input.Length - 2; i >= 0; i--)
            {
                if (dict[input[i]] >= dict[input[i + 1]])
                {
                    sum += dict[input[i]];
                }
                else
                {
                    sum -= dict[input[i]];
                }
            }

            return sum;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/249/set-matrix-zeroes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void p_052_SetMatrix0(int[,] input)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> columns = new HashSet<int>();

            int n = input.GetLength(0);
            int m = input.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (input[i, j] == 0)
                    {
                        if (!rows.Contains(i)) rows.Add(i);
                        if (!columns.Contains(j)) columns.Add(j);
                    }
                }
            }

            foreach (int i in rows)
            {
                for (int j = 0; j < m; j++)
                {
                    input[i, j] = 0;
                }
            }
            foreach (int j in columns)
            {
                for (int i = 0; i < n; i++)
                {
                    input[i, j] = 0;
                }
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/249/set-matrix-zeroes
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> p_053_Permutation(string input)
        {
            List<string> res = new List<string>();
            char[] array = input.ToCharArray();
            PermutationWorker(array, 0, res);
            return res;
        }

        private void PermutationWorker(char[] input, int level, List<string> res)
        {
            if (level == input.Length)
            {
                string s = new string(input);
                res.Add(s);
                return;
            }

            for (int i = level; i < input.Length; i++)
            {
                SwapChar(input, level, i);
                PermutationWorker(input, level + 1, res);
                SwapChar(input, level, i);
            }
        }

        private void SwapChar(char[] input, int i, int j)
        {
            if (i == j) return;
            // make sure no out of index problem.
            char tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/225/permutations-ii
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> p_053_PermutationII(string input)
        {
            List<string> res = new List<string>();
            char[] array = input.ToCharArray();
            PermutationWorkerII(array, 0, res);
            return res;
        }

        private void PermutationWorkerII(char[] input, int level, List<string> res)
        {
            if (level == input.Length)
            {
                string s = new string(input);
                res.Add(s);
                return;
            }

            for (int i = level; i < input.Length; i++)
            {
                if (i == level || input[i] != input[level])
                {
                    SwapChar(input, level, i);
                    PermutationWorkerII(input, level + 1, res);
                    SwapChar(input, level, i);
                }
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/285/triangle
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_054_Triangle(List<List<int>> input)
        {
            if (input.Count == 0) return 0;

            List<int> cur = new List<int>();
            List<int> pre = new List<int>();
            pre = input[0];

            for (int i = 1; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Count; j++)
                {
                    if (j == 0)
                    {
                        cur.Add(pre[0] + input[i][j]);
                    }
                    else if (j == input[i].Count - 1)
                    {
                        cur.Add(pre[j - 1] + input[i][j]);
                    }
                    else
                    {
                        int tmp = pre[j - 1] < pre[j] ? pre[j - 1] : pre[j];
                        cur.Add(tmp + input[i][j]);
                    }
                }
                pre = cur;
                cur = new List<int>();
            }

            int min = int.MaxValue;
            for (int i = 0; i < pre.Count; i++)
            {
                min = min < pre[i] ? min : pre[i];
            }
            return min;

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/249/set-matrix-zeroes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int p_055_LengthOfLastWord(string s)
        {
            int i = 0;
            int lastcharIndex = 0;
            bool isSpace = true;
            int lastLength = 0;
            while (i < s.Length)
            {
                if (s[i] != ' ' && isSpace)
                {
                    isSpace = false;
                    lastcharIndex = i;
                }
                if (s[i] == ' ' && !isSpace)
                {
                    lastLength = i - lastcharIndex;
                    isSpace = true;
                }
                i++;
            }

            if (s[i - 1] != ' ')
            {
                lastLength = i - lastcharIndex;
            }

            return lastLength;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/217/count-and-say
        /// </summary>
        /// <param name="input"></param>
        public string p_056_CountAndSay(int n)
        {
            string s = "1";

            for (int i = 0; i < n; i++)
            {
                char curChar = s[0];
                int curCount = 1;
                StringBuilder sb = new StringBuilder();
                for (int j = 1; j < s.Length; j++)
                {
                    if (s[j] == curChar)
                    {
                        curCount++;
                    }
                    else
                    {
                        sb.Append(curCount.ToString());
                        sb.Append(curChar);
                        curChar = s[j];
                        curCount = 1;
                    }
                }
                sb.Append(curCount.ToString());
                sb.Append(curChar);
                s = sb.ToString();
            }
            return s;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/273/same-tree
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool p_057_SameTree(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null && t2 != null) return false;
            if (t1 != null && t2 == null) return false;
            if (t1.Value != t2.Value) return false;

            return p_057_SameTree(t1.LeftChild, t2.LeftChild) && p_057_SameTree(t1.RightChild, t2.RightChild);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/207/remove-duplicates-from-sorted-array
        /// </summary>
        /// <param name="input"></param>
        public void p_058_RemovedupFromsortedArray(int[] input)
        {
            int slower = 0;
            int faster = 1;
            while (faster < input.Length)
            {
                if (input[slower] != input[faster])
                {
                    input[slower + 1] = input[faster];
                    slower++;
                    faster++;
                }
                else
                {
                    faster++;
                }
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/186/construct-binary-tree-from-inorder-and-postorder-traversal
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="preorder"></param>
        /// <returns></returns>
        public TreeNode p_059_TreeFromInOrderAndPreOrder(List<int> inorder, List<int> preorder)
        {
            if (inorder.Count != preorder.Count) return null;
            if (inorder.Count == 0 && preorder.Count == 0) return null;


            int rootValue = preorder[0];

            int inorderIndex = 0;
            for (int i = 0; i < inorder.Count; i++)
            {
                if (rootValue == inorder[i])
                {
                    inorderIndex = i;
                    break;
                }
            }
            int lefttreelen = inorderIndex;
            int righttreelen = inorder.Count - lefttreelen - 1;

            List<int> leftInorder = inorder.GetRange(0, lefttreelen);
            List<int> rightInOrder = inorder.GetRange(inorderIndex + 1, righttreelen);

            List<int> leftPreOrder = preorder.GetRange(1, lefttreelen);
            List<int> rightPreOrder = preorder.GetRange(inorderIndex + 1, righttreelen);
            TreeNode root = new TreeNode(rootValue);
            root.LeftChild = p_059_TreeFromInOrderAndPreOrder(leftInorder, leftPreOrder);
            root.RightChild = p_059_TreeFromInOrderAndPreOrder(rightInOrder, rightPreOrder);

            return root;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/148/construct-binary-tree-from-preorder-and-inorder-traversal
        /// </summary>
        /// <param name="inorder"></param>
        /// <param name="postorder"></param>
        /// <returns></returns>
        public TreeNode p_059_TreeFromInOrderAndPostOrder(List<int> inorder, List<int> postorder)
        {
            if (inorder.Count != postorder.Count) return null;
            if (inorder.Count == 0 && postorder.Count == 0) return null;

            int rootValue = postorder[postorder.Count - 1];

            int inorderIndex = 0;
            for (int i = 0; i < inorder.Count; i++)
            {
                if (rootValue == inorder[i])
                {
                    inorderIndex = i;
                    break;
                }
            }

            int lefttreelen = inorderIndex;
            int righttreelen = inorder.Count - lefttreelen - 1;

            List<int> leftInorder = inorder.GetRange(0, lefttreelen);
            List<int> rightInOrder = inorder.GetRange(inorderIndex + 1, righttreelen);

            List<int> leftPostOrder = postorder.GetRange(0, lefttreelen);
            List<int> rightPostOrder = postorder.GetRange(inorderIndex, righttreelen);

            TreeNode root = new TreeNode(rootValue);
            root.LeftChild = p_059_TreeFromInOrderAndPostOrder(leftInorder, leftPostOrder);
            root.RightChild = p_059_TreeFromInOrderAndPostOrder(rightInOrder, rightPostOrder);
            return root;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/250/search-a-2d-matrix
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool p_060_SearchIn2dArray(int[,] input, int k)
        {
            int height = input.GetLength(0);
            int top = 0;
            int bottom = height - 1;
            int middle = 0;

            while (top <= bottom)
            {
                if (k > input[bottom, 0])
                {
                    middle = bottom;
                    break;
                }
                middle = top + (bottom - top) / 2;
                if (k < input[middle, 0])
                {
                    if (middle == 0)
                    {
                        return false;
                    }
                    else
                    {
                        bottom = middle - 1;
                    }
                }
                else if (k > input[middle, 0])
                {
                    if (middle == height - 1 || middle == bottom - 1 || middle == bottom)
                    {
                        break;
                    }
                    else
                    {
                        top = middle;
                    }
                }
                else
                {
                    return true;
                }
            }

            int width = input.GetLength(1);
            int left = 0;
            int right = width - 1;
            while (left <= right)
            {
                int center = left + (right - left) / 2;
                if (k == input[middle, center])
                {
                    return true;
                }
                if (k < input[middle, center])
                {
                    right = center - 1;
                }
                else
                {
                    left = center + 1;
                }
            }
            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/274/symmetric-tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool p_061_IsSymmetricTree(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetricWorker(root.LeftChild, root.RightChild);
        }

        private bool IsSymmetricWorker(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null || root2 == null) return false;

            if (root1.Value != root2.Value) return false;
            return IsSymmetricWorker(root1.LeftChild, root2.RightChild) && IsSymmetricWorker(root1.RightChild, root2.LeftChild);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/25/maximum-depth-of-binary-tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int p_062_MaxDeepthOfATree(TreeNode root)
        {
            if (root == null) return 0;

            int left = p_062_MaxDeepthOfATree(root.LeftChild);
            int right = p_062_MaxDeepthOfATree(root.RightChild);
            return Math.Max(left, right) + 1;

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/277/minimum-depth-of-binary-tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int p_063_MinDeepthOfATree(TreeNode root)
        {
            if (root == null) return 0;

            int left = p_062_MaxDeepthOfATree(root.LeftChild);
            int right = p_062_MaxDeepthOfATree(root.RightChild);
            return Math.Min(left, right) + 1;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/276/balanced-binary-tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool p_064_IsBalanceTree(TreeNode root)
        {
            if (root == null) return true;
            Tuple<bool, int> left = IsbalanceWorker(root.LeftChild);
            Tuple<bool, int> right = IsbalanceWorker(root.RightChild);

            Tuple<bool, int> res = new Tuple<bool, int>(
                left.Item1 && right.Item1 && Math.Abs(left.Item2 - right.Item2) <= 1,
                Math.Max(left.Item2, right.Item2));

            return res.Item1;

        }

        public Tuple<bool, int> IsbalanceWorker(TreeNode root)
        {
            if (root == null) return new Tuple<bool, int>(true, 0);
            Tuple<bool, int> left = IsbalanceWorker(root.LeftChild);
            Tuple<bool, int> right = IsbalanceWorker(root.RightChild);

            Tuple<bool, int> res = new Tuple<bool, int>(
                left.Item1 && right.Item1 && Math.Abs(left.Item2 - right.Item2) <= 1,
                Math.Max(left.Item2, right.Item2 + 1));
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/76/implement-strstr
        /// </summary>
        /// <returns></returns>
        public bool p_065_strStr(string s1, string s2)
        {
            if (s2.Length > s1.Length) return false;
            if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) return true;
            if (string.IsNullOrEmpty(s2)) return true;

            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i + j] != s2[j])
                    {
                        break;
                    }
                    if (j == s2.Length - 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/49/binary-tree-level-order-traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public List<List<int>> p_066_LevelOrderTravel(TreeNode root)
        {
            if (root == null) return null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            List<int> level = new List<int>();
            List<List<int>> res = new List<List<int>>();
            q.Enqueue(root);
            q.Enqueue(null);
            while (q.Count != 0)
            {
                TreeNode tmp = q.Dequeue();
                if (tmp == null)
                {
                    res.Add(level);
                    level = new List<int>();
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    if (tmp.LeftChild != null)
                    {
                        q.Enqueue(tmp.LeftChild);
                    }
                    if (tmp.RightChild != null)
                    {
                        q.Enqueue(tmp.RightChild);
                    }
                    level.Add(tmp.Value);
                }
            }
            return res;
        }



        /// <summary>
        /// http://discuss.leetcode.com/questions/284/pascals-triangle-ii
        /// </summary>
        public List<int> p_067_PascalTriangleII(int n)
        {
            if (n < 1) return null;
            if (n == 1) return new List<int>() { 1 };
            if (n == 2) return new List<int>() { 1, 1 };

            List<int> pre = new List<int>() { 1, 1 };
            List<int> cur = new List<int>() { };
            for (int i = 3; i <= n; i++)
            {
                cur.Add(pre[0]);
                for (int j = 1; j < pre.Count; j++)
                {
                    cur.Add(pre[j - 1] + pre[j]);
                }
                cur.Add(pre[pre.Count - 1]);
                pre = cur;
                cur = new List<int>();
            }
            return pre;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/94/best-time-to-buy-and-sell-stock
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int p_049_WhentoBuySellStock(int[] prices)
        {
            int buyIndex = 0;
            int sellIndex;

            int maxProfit = 0;
            int maxBuyIndex = 0;
            int maxSellIndex = 0;
            int currentProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                int diff = prices[i + 1] - prices[i];
                currentProfit += diff;
                if (currentProfit > maxProfit)
                {
                    maxProfit = currentProfit;
                    maxBuyIndex = buyIndex;
                    maxSellIndex = i + 1;
                }
                if (currentProfit < 0)
                {
                    buyIndex = i + 1;
                    currentProfit = 0;
                }
            }
            return maxProfit;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/286/best-time-to-buy-and-sell-stock-ii
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int p_089_BestTimeToBuyStockII(int[] prices)
        {
            int maxProfit = 0;
            List<int> p = new List<int>(prices);

            for (int i = 2; i < prices.Length - 2; i++)
            {
                List<int> left = p.GetRange(0, i);
                List<int> right = p.GetRange(i, prices.Length - i);

                int leftProfit = p_049_WhentoBuySellStock(left.ToArray());
                int righProfit = p_049_WhentoBuySellStock(right.ToArray());

                int profit = leftProfit + righProfit;

                maxProfit = maxProfit > profit ? maxProfit : profit;
            }

            return maxProfit;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/287/best-time-to-buy-and-sell-stock-iii
        /// </summary>
        public int p_068_BestTimeToBuyStockIII(int[] prices)
        {
            int singleProfit = p_049_WhentoBuySellStock(prices);
            int doubleProfit = p_089_BestTimeToBuyStockII(prices);
            return Math.Max(singleProfit, doubleProfit);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/257/remove-duplicates-from-sorted-list-ii
        /// </summary>
        /// <param name="node"></param>
        public LinkListNode p_069_RemoveDuplicatefromSortedLIstII(LinkListNode node)
        {
            if (node == null) return null;
            LinkListNode dummyHeader = new LinkListNode();
            dummyHeader.Next = node;
            LinkListNode tail = dummyHeader;

            LinkListNode cur = dummyHeader.Next;
            int curCount = 1;
            LinkListNode tmp = cur.Next;

            while (tmp != null)
            {
                if (tmp.Value != cur.Value)
                {
                    if (curCount == 1)
                    {
                        tail.Next = cur;
                        tail = tail.Next;
                    }
                    cur = tmp;
                    curCount = 1;
                }
                else
                {
                    curCount++;
                }
                tmp = tmp.Next;
            }


            if (curCount == 1)
            {
                tail.Next = cur;
                cur.Next = null;
            }
            else
            {
                tail.Next = null;
            }
            return dummyHeader.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/208/remove-element
        /// </summary>
        /// <param name="input"></param>
        public int p_070_RemoveElement(int[] input, int k)
        {
            int left = 0;
            int right = input.Length - 1;
            while (right >= 0 && input[right] == k) right--;
            if (right == 0) return -1;

            while (left < right)
            {
                while (input[left] != k && left < right) left++;
                while (input[right] == k && left < right) right--;
                if (left < right)
                {
                    input[left] = input[right];
                    right--;
                    while (right >= 0 && input[right] == k) right--;
                    left++;
                }

            }
            if (input[left] == k)
            {
                return left - 1;
            }
            else
            {
                return left;
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/204/merge-k-sorted-lists
        /// </summary>
        /// <param name="headers"></param>
        public LinkListNode p_071_MergeKSortedList(List<LinkListNode> headers)
        {
            LinkListNode dummyHeader = new LinkListNode();
            LinkListNode tail = dummyHeader;

            // pretend the list is a heap list. [0] is smallest
            while (headers.Count > 1)
            {
                LinkListNode minHeader = headers[0];
                headers.RemoveAt(0);
                tail.Next = minHeader;
                tail = tail.Next;
                if (minHeader.Next != null)
                {
                    headers.Add(minHeader.Next);
                }
            }

            // just pick up the last list.
            tail.Next = headers[0];

            return dummyHeader.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/251/sort-colors
        /// </summary>
        /// <param name="input"></param>
        public void p_072_SortColor(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left <= right)
            {
                while (left < right && input[left] <= 1) left++;
                while (right > left && input[right] > 1) right--;
                if (left <= right)
                {
                    int tmp = input[left];
                    input[left] = input[right];
                    input[right] = tmp;
                    left++;
                    right--;
                }
            }

            right = input.Length - 1;
            while (left <= right)
            {
                while (left < right && input[left] <= 2) left++;
                while (right > left && input[right] > 2) right--;
                if (left <= right)
                {
                    int tmp = input[left];
                    input[left] = input[right];
                    input[right] = tmp;
                    left++;
                    right--;
                }
            }
            return;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/238/rotate-list
        /// </summary>
        /// <param name="node"></param>
        public LinkListNode p_073_RotateList(LinkListNode node, int k)
        {
            if (node == null) return null;
            if (k == 0) return node;
            LinkListNode slower = node;
            LinkListNode faster = node;
            for (int i = 0; i < k; i++)
            {
                if (faster.Next != null)
                {
                    faster = faster.Next;
                }
                else
                {
                    // throw exception, listed list is too short for k.
                }
            }

            while (faster.Next != null)
            {
                slower = slower.Next;
                faster = faster.Next;
            }

            LinkListNode newHeader = slower.Next;
            slower.Next = null;
            faster.Next = node;
            return newHeader;

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/188/two-sum
        /// </summary>
        /// <param name="input"></param>
        public Tuple<int, int> p_074_TwoSum(int[] input, int k)
        {
            // sort the array.
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                int sum = input[left] + input[right];
                if (sum == k)
                {
                    return new Tuple<int, int>(input[left], input[right]);
                }
                if (sum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return new Tuple<int, int>(-1, -1);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/190/zigzag-conversion
        /// </summary>
        /// <param name="s"></param>
        public string p_075_ZigZagConversion(string s, int n)
        {
            if (n <= 1) return s;
            string res = string.Empty;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (j % (2 * n - 2) == i || j % (2 * n - 2) == (2 * n - 2 - i))
                    {
                        sb.Append(s[j]);
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/194/integer-to-roman
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string p_076_IntegerToRoman(int input)
        {
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/191/reverse-integer
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_077_ReverseInteger(int input)
        {
            // assum there is no over flow concern.
            int res = 0;
            while (input != 0)
            {
                res = res * 10 + input % 10;
                input = input / 10;
            }

            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/260/maximal-rectangle
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_078_MaximalRectangle(int[,] input)
        {
            // really assume all numbers are 0 or 1
            int count = 0;
            int height = input.GetLength(0);
            int width = input.GetLength(1);
            int[,] tracker = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (input[i, j] == 1)
                    {
                        count++;
                        tracker[i, j] = count;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (tracker[i, j] != 0)
                    {
                        int startIndex = j - tracker[i, j] + 1;
                        int maxwidth = tracker[i, j];
                        int curMax = maxwidth;

                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (tracker[k, startIndex] == 0)
                            {
                                break;
                            }
                            for (int w = startIndex; w < maxwidth; w++)
                            {
                                if (tracker[k, w] == 0)
                                {
                                    maxwidth = w - startIndex + 1;
                                    break;
                                }
                            }
                            curMax = maxwidth * (i - k + 1) > curMax ? maxwidth * (i - k + 1) : curMax;
                        }
                        max = max > curMax ? max : curMax;
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/226/rotate-image
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public void p_079_RotateImage(int[,] input)
        {
            int height = input.GetLength(0);
            int width = input.GetLength(1);

            for (int i = 0; i <= height / 2; i++)
            {
                for (int j = i; j < width - i - 1; j++)
                {
                    int tmp = input[i, j];
                    input[i, j] = input[j, width - i - 1];
                    input[j, width - i - 1] = input[height - i - 1, width - j - 1];
                    input[height - i - 1, width - j - 1] = input[height - j - 1, i];
                    input[height - j - 1, i] = tmp;
                }
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/256/search-in-rotated-sorted-array-ii
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool p_080_SearchInRotateSortedArrayII(int[] input, int k)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (input[mid] == k) return true;

                if (input[left] < input[mid])
                {
                    if (k <= input[mid] && k >= input[left])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (k >= input[mid] && k <= input[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/255/remove-duplicates-from-sorted-array-ii
        /// </summary>
        /// <param name="input"></param>
        public void p_081_RemoveDupFromSortedArrayII(int[] input)
        {
            // allow most twice.
            int cur = -1;
            int count = 0;

            int slow = 0;
            int faster = 0;
            while (faster < input.Length)
            {
                if (count == 0)
                {
                    count = 1;
                    cur = input[faster];
                }
                else
                {
                    if (cur == input[faster])
                    {
                        count++;
                    }
                    else
                    {
                        for (int i = 0; i < count && i < 2; i++)
                        {
                            input[slow] = cur;
                            slow++;
                        }
                        cur = input[faster];
                        count = 1;
                    }
                }
                faster++;
            }
            for (int i = 0; i < count && i < 2; i++)
            {
                input[slow] = cur;
                slow++;
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/288/binary-tree-maximum-path-sum
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public Tuple<int, int> p_082_BinaryTreeMaximumPathSum(TreeNode root)
        {
            if (root == null) return new Tuple<int, int>(0, 0);

            Tuple<int, int> left = p_082_BinaryTreeMaximumPathSum(root.LeftChild);
            Tuple<int, int> right = p_082_BinaryTreeMaximumPathSum(root.RightChild);

            int cross = left.Item1 + right.Item1 + root.Value;
            int maxCross = Math.Max(cross, Math.Max(left.Item2, right.Item2));

            int fromroot = root.Value + Math.Max(left.Item1, right.Item1);

            return new Tuple<int, int>(fromroot, maxCross);
        }

        public int p_082_BinaryTreeMaxPathSumII(TreeNode root)
        {
            int globalMax = int.MinValue;
            p_082_Worker(root, ref globalMax);
            return globalMax;
        }

        private int p_082_Worker(TreeNode root, ref int globalMax)
        {
            if (root == null) return 0;
            int left = p_082_Worker(root.LeftChild, ref globalMax);
            int right = p_082_Worker(root.RightChild, ref globalMax);
            globalMax = globalMax > root.Value + left + right ? globalMax : root.Value + left + right;
            return left > right ? (root.Value + left) : (root.Value + right);
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/218/combination-sum-ii
        /// </summary>
        /// <returns></returns>
        public List<List<int>> p_083_CombinationSumII(int[] input, int k)
        {
            return null;
        }

        private void p_083_Worker(int[] input, int level, List<int> tmp, int sum, int k, List<List<int>> res)
        {
            // even sum > k, I still need to continue to run because of potential negative number.
            if (sum == k)
            {
                List<int> cur = new List<int>();
                foreach (int i in tmp)
                {
                    cur.Add(i);
                }
                res.Add(cur);
                return;
            }
            if (level == input.Length)
            {
                return;
            }
            p_083_Worker(input, level + 1, tmp, sum, k, res);

            sum += input[level];
            tmp.Add(input[level]);
            p_083_Worker(input, level + 1, tmp, sum, k, res);
            sum -= input[level];
            tmp.Remove(input[level]);

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/61/combination-sum
        /// </summary>
        /// <returns></returns>
        public List<List<int>> p_083_CombinationSum(int[] input, int k)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> tmp = new List<int>();
            p_083_Worker(input, 0, tmp, 0, k, res);
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/181/palindrome-number
        /// </summary>
        /// <returns></returns>
        public bool p_084_PalindromeNumber(int input)
        {
            int reverse = p_077_ReverseInteger(input);

            return reverse == input;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/248/edit-distance
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int p_085_EditDistance(string s1, string s2)
        {
            int m = s1.Length;
            int n = s2.Length;
            if (m == 0 && n == 0) return 0;
            if (m != 0 && n == 0) return m;
            if (m == 0 && n != 0) return n;


            int[,] tracker = new int[m, n];
            if (s1[0] != s2[0])
            {
                tracker[0, 1] = 1;
            }

            for (int j = 1; j < n; j++)
            {
                tracker[0, j] = tracker[0, j - 1] + 1;
            }

            for (int i = 1; i < m; i++)
            {
                tracker[i, 0] = tracker[i - 1, 0] + 1;
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    int increase = 1;
                    if (s1[i] == s2[j])
                    {
                        increase = 0;
                    }

                    tracker[i, j] = Math.Min(Math.Min(tracker[i - 1, j] + 1, tracker[i, j - 1] + 1), tracker[i - 1, j - 1] + increase);
                }
            }

            return tracker[m - 1, n - 1]; ;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/47/validate-binary-search-tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool p_086_ValidateBST(TreeNode root)
        {
            return p_086_ValidateBST_Worker(root, int.MinValue, int.MaxValue);
            return true;
        }

        private bool p_086_ValidateBST_Worker(TreeNode root, int min, int max)
        {
            if (root == null) return true;
            if (root.Value < min || root.Value > max)
            {
                return false;
            }
            return p_086_ValidateBST_Worker(root.LeftChild, min, root.Value) &&
                p_086_ValidateBST_Worker(root.RightChild, root.Value, max);


        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/203/generate-parentheses
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> p_087_GenerateAllParentheses(int t)
        {
            List<string> res = new List<string>();
            p_087_Worker_GenerateAllParentheses(t, 0, 0, string.Empty, res);
            return res;
        }

        private void p_087_Worker_GenerateAllParentheses(int t, int n, int k, string s, List<string> res)
        {
            if (n == t && k == t)
            {
                res.Add(s);
                return;
            }

            if (n > k)
            {
                p_087_Worker_GenerateAllParentheses(t, n, k + 1, s + ")", res);
            }
            if (n < t)
            {
                p_087_Worker_GenerateAllParentheses(t, n + 1, k, s + "(", res);
            }

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/281/distinct-subsequences
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int p_088_DistinctSubSequences(string s, string t)
        {
            if (t.Length == 0) return 1;
            if (s.Length == 0) return 0;

            int tmp = 0;
            if (s[0] == t[0])
            {
                tmp = p_088_DistinctSubSequences(s.Substring(1), t.Substring(1));
            }

            int match = p_088_DistinctSubSequences(s.Substring(1), t);

            return match + tmp;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/281/distinct-subsequences
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int p_088_DistinctSubSequencesII(string s, string t)
        {
            if (t.Length == 0) return 1;
            if (s.Length == 0) return 0;
            if (t.Length > s.Length) return 0;

            int[,] tracker = new int[t.Length, s.Length];
            if (s[0] == t[0]) tracker[0, 0] = 1;
            for (int i = 1; i < t.Length; i++)
            {
                if (s[i] == t[i])
                {
                    tracker[i, i] = tracker[i - 1, i - 1];
                }
            }

            for (int i = 1; i < t.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (t[i] == s[j])
                    {
                        tracker[i, j] = tracker[i - 1, j - 1] + tracker[i, j - 1];
                    }
                    else
                    {
                        tracker[i, j] = tracker[i, j - 1];
                    }
                }
            }
            return tracker[t.Length - 1, s.Length - 1];
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/175/regular-expression-matching
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool p_090_RegularExpressionMatching(string s, string p)
        {
            //if s.Length == 0 check if p has * after each character
            if (s.Length == 0)
            {
                return RegularExpressionMatching_CheckEmpty(p);
            }
            //if s.Length >= 0 and p.Length == 0, return false
            if (p.Length == 0)
            {
                return false;
            }

            char s1 = s[0];
            char p1 = p[0];
            char p2 = p.Length > 1 ? p[1] : '0'; //any character but '*' will work

            if (p2 == '*')
            {
                if (p1 == '.' || s1 == p1)
                {
                    return p_090_RegularExpressionMatching(s.Substring(1), p) || p_090_RegularExpressionMatching(s, p.Substring(2));
                }
                else
                {
                    return p_090_RegularExpressionMatching(s, p.Substring(2));
                }
            }
            else
            {
                if (p1 == '.' || s1 == p1)
                {
                    return p_090_RegularExpressionMatching(s.Substring(1), p.Substring(1));
                }
                else
                {
                    return false;
                }
            }
        }

        private bool RegularExpressionMatching_CheckEmpty(string p)
        {
            if (p.Length % 2 != 0)
                return false;
            for (int i = 1; i < p.Length; i += 2)
            {
                if (p[i] != '*')
                    return false;
            }
            return true;


        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/280/flatten-binary-tree-to-linked-list
        /// </summary>
        /// <param name="node"></param>
        public TreeNode p_091_FlattenBinaryTreeToLinkedList(TreeNode node)
        {
            TreeNode tmp = null;
            if (node == null) return null;
            tmp = node;
            if (node.LeftChild != null)
            {
                p_091_worker(node.LeftChild, ref tmp);
            }
            if (node.RightChild != null)
            {
                p_091_worker(node.RightChild, ref tmp);
            }
            return node;
        }

        private void p_091_worker(TreeNode node, ref TreeNode tmp)
        {
            if (node == null) return;
            tmp.Next = node;
            tmp = tmp.Next;
            if (node.LeftChild != null)
            {
                p_091_worker(node.LeftChild, ref tmp);
            }
            if (node.RightChild != null)
            {
                p_091_worker(node.RightChild, ref tmp);
            }
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/199/4sum
        /// </summary>
        /// <param name="node"></param>
        public List<Tuple<int, int, int, int>> p_092_4Sum(int[] input, int k)
        {
            Dictionary<int, List<Tuple<int, int>>> dict = new Dictionary<int, List<Tuple<int, int>>>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (!dict.Keys.Contains(input[i] + input[j]))
                    {
                        dict.Add(input[i] + input[j], new List<Tuple<int, int>>() { new Tuple<int, int>(i, j) });
                    }
                    else
                    {
                        dict[input[i] + input[j]].Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            List<Tuple<int, int, int, int>> res = new List<Tuple<int, int, int, int>>();
            foreach (int x in dict.Keys)
            {
                if (dict.Keys.Contains(k - x))
                {
                    Dictionary<int, int> track = new Dictionary<int, int>();

                    for (int i = 0; i < dict[x].Count; i++)
                    {
                        if (!track.Keys.Contains(i))
                        {
                            for (int j = 0; j < dict[k - x].Count; j++)
                            {
                                if (!track.Values.Contains(j))
                                {
                                    if (dict[x][i].Item1 != dict[k - x][j].Item1 &&
                                        dict[x][i].Item1 != dict[k - x][j].Item2 &&
                                        dict[x][i].Item2 != dict[k - x][j].Item1 &&
                                        dict[x][i].Item2 != dict[k - x][j].Item2)
                                    {
                                        track.Add(i, j);
                                    }
                                }
                            }
                        }
                    }

                    foreach (int key in track.Keys)
                    {
                        res.Add(new Tuple<int, int, int, int>(dict[x][key].Item1, dict[x][key].Item2, dict[k - x][track[key]].Item1, dict[k - x][track[key]].Item2));
                    }
                }
            }

            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/220/trapping-rain-water
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_093_TrappingRainWater(int[] input)
        {
            int sum = 0;
            int left = 0;
            int lefttop = input[0];
            int right = input.Length - 1;
            int righttop = input[right];

            while (left < right)
            {
                if (input[left] <= input[right])
                {
                    if (input[left + 1] < lefttop)
                    {
                        sum += lefttop - input[left + 1];
                    }
                    else
                    {
                        lefttop = input[left + 1];
                    }
                    left++;
                }
                else
                {
                    if (input[right - 1] < righttop)
                    {
                        sum += righttop - input[right - 1];
                    }
                    else
                    {
                        righttop = input[right - 1];
                    }
                    right--;
                }
            }

            return sum;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1266/palindrome-partitioning-ii
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int p_094_PalindromePartitioningII(string s)
        {
            if (s.Length < 2) return 0;
            int[] tracker = new int[s.Length];
            tracker[0] = 0;
            for (int i = 1; i < s.Length; i++)
            {
                tracker[i] = i;
            }

            for (int i = 1; i < s.Length; i++)
            {
                int mincut = tracker[i];
                for (int j = i; j >= 0; j--)
                {
                    if (IsPalindrome(s.Substring(j, i - j + 1)))
                    {
                        if (j != 0)
                        {
                            mincut = mincut < tracker[j - 1] ? mincut : tracker[j - 1];
                        }
                        else
                        {
                            mincut = -1;
                        }
                    }
                }
                tracker[i] = mincut + 1;

            }

            return tracker[s.Length - 1];
        }

        private bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/214/search-insert-position
        /// </summary>
        /// <param name="input"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int p_095_SearchInsertPosition(int[] input, int k)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (k == input[mid])
                {
                    return mid;
                }
                else if (k < input[mid])
                {
                    if (mid == 0) return 0;
                    if (k > input[mid - 1])
                    {
                        return mid;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (mid == input.Length - 1)
                    {
                        return input.Length;
                    }

                    if (k < input[mid + 1])
                    {
                        return mid + 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/211/next-permutation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string p_096_NextPermutation(int[] input)
        {
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/275/binary-tree-level-order-traversal-ii
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<List<int>> p_097_BinaryTreeLevelOrderTraversalII(TreeNode node)
        {
            List<List<int>> res = new List<List<int>>();
            List<int> tmp = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(node);
            tmp.Add(node.Value);
            q.Enqueue(null);
            while (q.Count != 0)
            {
                TreeNode n = q.Dequeue();
                if (n == null)
                {
                    res.Add(tmp);
                    tmp = new List<int>();
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);
                    }
                }
                else
                {
                    tmp.Add(n.Value);
                    if (n.LeftChild != null) q.Enqueue(n.LeftChild);
                    if (n.RightChild != null) q.Enqueue(n.RightChild);
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/270/unique-binary-search-trees
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int p_098_UniqueBinarySearchTree(int n)
        {
            List<TreeNode> res = p_098_Worker(0, n);
            return res.Count;
        }

        private List<TreeNode> p_098_Worker(int startIndex, int endIndex)
        {
            List<TreeNode> res = new List<TreeNode>();
            if (startIndex == endIndex)
            {

                TreeNode node = new TreeNode(startIndex);
                res.Add(node);
                return res;
            }
            if (startIndex > endIndex)
            {
                res.Add(null);
                return res;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                List<TreeNode> left = p_098_Worker(startIndex, i - 1);
                List<TreeNode> right = p_098_Worker(i + 1, endIndex);

                foreach (TreeNode l in left)
                {
                    foreach (TreeNode r in right)
                    {
                        TreeNode root = new TreeNode(i);
                        root.LeftChild = l;
                        root.RightChild = r;
                        res.Add(root);
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/241/valid-number
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool p_099_IsValidNumber(string s)
        {
            return true;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/265/subsets-ii
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<List<int>> p_100_SubsetII(int[] input)
        {
            if (input == null || input.Length == 0) return null;
            Array.Sort(input);

            List<List<int>> res = new List<List<int>>();

            int start = 0;
            res.Add(new List<int>());
            for (int i = 0; i < input.Length; i++)
            {
                int count = res.Count;
                for (int j = start; j < count; j++)
                {
                    List<int> tmp = new List<int>(res[j]);
                    tmp.Add(input[i]);
                    res.Add(tmp);
                }
                if (i < input.Length - 1 && input[i] == input[i + 1])
                {
                    start = count;
                }
                else
                {
                    start = 0;
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/213/search-for-a-range
        /// </summary>
        /// <param name="input"></param>
        public Tuple<int, int> p_101_SearchForARange(int[] input, int k)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (input[mid] == k)
                {
                    int leftEdge = p_101_FindLeft(input, k, mid);
                    int rightEdge = p_101_FindRight(input, k, mid);
                    return new Tuple<int, int>(leftEdge, rightEdge);
                }
                else if (input[mid] < k)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return null;
        }

        private int p_101_FindLeft(int[] input, int k, int index)
        {
            int left = 0;
            int right = index;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (input[mid] == k)
                {
                    if (mid == 0 || input[mid - 1] < k)
                    {
                        return mid;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        private int p_101_FindRight(int[] input, int k, int index)
        {
            int left = index;
            int right = input.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (input[mid] == k)
                {
                    if (mid == input.Length - 1 || input[mid + 1] > k)
                    {
                        return mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    right = mid - 1;
                }
            }
            return input.Length;

        }


        /// <summary>
        /// http://discuss.leetcode.com/questions/229/n-queens
        /// </summary>
        /// <param name="input"></param>
        public void p_102_8Queens(int[,] input)
        {
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/230/n-queens-ii
        /// </summary>
        /// <param name="input"></param>
        public void p_102_8QueensII(int[,] input)
        {
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/247/simplify-path
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string p_103_SimplifyPath(string str)
        {
            Stack<string> s = new Stack<string>();
            int startIndex = 0;
            while (str[startIndex] != '/') startIndex++;
            int endIndex = startIndex + 1;

            while (endIndex < str.Length)
            {
                while (str[endIndex] != '/') endIndex++;
                string tmp = str.Substring(startIndex + 1, endIndex - startIndex - 1);
                if (tmp == ".")
                {

                }
                else if (tmp == "..")
                {
                    if (s.Count > 0)
                    {
                        s.Pop();
                    }
                    else
                    {
                        //throw exception.
                    }
                }
                else
                {
                    s.Push(tmp);
                }
                startIndex++;
                while (startIndex < str.Length && str[startIndex] != '/') startIndex++;
                endIndex = startIndex + 1;

            }
            string res = string.Empty;
            while (s.Count != 0)
            {
                res = s.Pop() + "/" + res;
            }

            return "/" + res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/222/wildcard-matching
        /// </summary>
        public bool p_104_WildcardMatching(string s, string p)
        {
            if (s == p) return true;

            if (s.Length == 0)
            {
                if (p.Length == 0)
                {
                    return true;
                }
                for (int i = 0; i < p.Length; i++)
                {
                    if (p[i] != '*')
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                if (p.Length == 0)
                {
                    return false;
                }
            }

            if (p[0] == '?')
            {
                return p_104_WildcardMatching(s.Substring(1), p.Substring(1));
            }

            if (p[0] == '*')
            {
                return p_104_WildcardMatching(s.Substring(1), p) ||
                    p_104_WildcardMatching(s.Substring(1), p.Substring(1));
            }

            if (p[0] == s[0])
            {
                return p_104_WildcardMatching(s.Substring(1), p.Substring(1));
            }

            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/582/valid-palindrome
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool p_105_ValidPalindrome(char[] s)
        {
            if (s == null || s.Length == 0) return true;

            int slower = 0;
            int faster = 0;

            while (faster < s.Length)
            {
                while (!(s[faster] - 'a' <= 26 && s[faster] - 'a' >= 0)) faster++;
                s[slower] = s[faster];
                slower++;
                faster++;
            }
            int left = 0;
            int right = slower - 1;

            while (left <= right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/205/swap-nodes-in-pairs
        /// </summary>
        /// <param name="node"></param>
        public LinkListNode p_106_SwapNodesInPairs(LinkListNode node)
        {
            if (node == null) return null;
            LinkListNode dummyNode = new LinkListNode();
            dummyNode.Next = node;
            LinkListNode tmp = dummyNode;

            LinkListNode n1 = null;
            LinkListNode n2 = null;
            LinkListNode nextHeader = null;
            while (tmp.Next != null && tmp.Next.Next != null)
            {
                n1 = tmp.Next;
                n2 = tmp.Next.Next;
                nextHeader = tmp.Next.Next.Next;

                tmp.Next = n2;
                n2.Next = n1;
                n1.Next = nextHeader;
                tmp = n1;
            }
            return dummyNode.Next;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/262/scramble-string
        /// </summary>
        /// <param name="s"></param>
        public bool p_107_ScrableString(string s1, string s2)
        {
            List<string> res = new List<string>();
            res = p_107_ScrambleString_Worker(s1);
            return res.Contains(s2);
        }

        private List<string> p_107_ScrambleString_Worker(string s)
        {
            if (s.Length == 1) return new List<string>() { s };
            if (s.Length == 0) return new List<string>() { string.Empty };
            List<string> res = new List<string>();
            res.Add(s);

            for (int i = 1; i < s.Length; i++)
            {
                List<string> leftList = p_107_ScrambleString_Worker(s.Substring(0, i));
                List<string> rightList = p_107_ScrambleString_Worker(s.Substring(i));

                foreach (string s1 in leftList)
                {
                    foreach (string s2 in rightList)
                    {
                        res.Add(s2 + s1);
                        res.Add(s1 + s2);
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/1051/word-ladder-ii
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public List<string> p_108_WordLadderII(string start, string end, HashSet<string> dict)
        {
            HashSet<string> visited = new HashSet<string>();
            Queue<WordNode> q = new Queue<WordNode>();
            q.Enqueue(new WordNode(start, null));
            visited.Add(start);
            List<string> l = new List<string>();

            while (q.Count != 0)
            {
                WordNode node = q.Dequeue();
                char[] word = null;
                for (int i = 0; i < node.Word.Length; i++)
                {
                    word = node.Word.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        word[i] = c;
                        string tmp = new string(word);
                        if (tmp == end)
                        {
                            string res = tmp;
                            WordNode parent = node;
                            while (parent != null)
                            {
                                res = parent.Word + " -> " + res;
                                parent = parent.previous;
                            }
                            l.Add(res);
                            continue;
                        }
                        if (dict.Contains(tmp) && !visited.Contains(tmp))
                        {
                            q.Enqueue(new WordNode(tmp, node));
                            visited.Add(tmp);
                        }
                    }
                }
            }

            return l;
        }

        public class WordNode
        {
            public WordNode(string w, WordNode prev)
            {
                this.Word = w;
                this.previous = prev;
            }
            public string Word;
            public WordNode previous;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/215/valid-sudoku
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool p_109_ValidateSoduku(int[,] input)
        {
            return false;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/221/multiply-strings
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int p_110_MuplyStrings(string s1, string s2)
        {
            int[] res = new int[s1.Length + s2.Length];
            int carry = 0;
            int tmp = 0;

            for (int i = s2.Length - 1; i >= 0; i--)
            {
                for (int j = s1.Length - 1; j >= 0; j--)
                {
                    tmp = (s2[i] - '0') * (s1[j] - '0') + carry;
                    carry = tmp / 10;
                    tmp = tmp % 10;
                    res[i + j + 1] += tmp;
                    carry += res[i + j + 1] / 10;
                    res[i + j + 1] = res[i + j + 1] % 10;
                }
                if (carry > 0)
                {
                    res[i] = carry;
                    carry = 0;
                }
            }


            int number = 0;

            for (int i = 0; i < res.Length; i++)
            {
                number = number * 10 + res[i];
            }

            return number;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/23/binary-tree-inorder-traversal
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<int> p_111_BinaryTreeInOrderTraversal(TreeNode node)
        {
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(node);
            bool isBackTrack = false;
            List<int> track = new List<int>();

            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (!isBackTrack && tmp.LeftChild != null)
                {
                    s.Push(tmp.LeftChild);
                    continue;
                }

                s.Pop();
                track.Add(tmp.Value);
                isBackTrack = true;

                if (isBackTrack && tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    isBackTrack = false;
                }
            }

            return track;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/244/text-justification
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<string> p_112_TextJustification(string s)
        {
            return null;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/178/longest-palindromic-substring
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int p_113_LongestPalindromicString(string s)
        {
            int max = 0;
            int cur = 0;

            for (int i = 0; i < s.Length; i++)
            {
                cur = 1;
                int left = i;
                int right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    max = max > right - left + 1 ? max : right - left + 1;
                    left--;
                    right++;
                }
                left = i - 1;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    max = max > right - left + 1 ? max : right - left + 1;
                    left--;
                    right++;
                }
            }
            return max;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/219/first-missing-positive
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_114_FirstMissingNmber(int[] input)
        {
            Byte[] track = new byte[int.MaxValue / 8 + 1];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0) continue;
                track[input[i] / 8] = (byte)(track[input[i] / 8] | 1 << input[i] % 8);
            }

            for (int i = 0; i < track.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((track[i] & 1 << j) == 0)
                    {
                        return i * 8 + j;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/268/restore-ip-addresses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<string> p_115_RestoreIPAddress(string s)
        {
            List<int> cuts = new List<int>();
            List<string> res = new List<string>();
            p_115_WorkerProcess(s, cuts, res);
            return res;
        }

        private void p_115_WorkerProcess(string s, List<int> cut, List<string> res)
        {
            if (cut.Count == 3)
            {
                string tmp = p_115_Verify_ValidIP(s, cut);
                if (!string.IsNullOrEmpty(tmp))
                {
                    res.Add(tmp);
                }
                return;
            }

            int startIndex = 0;
            if (cut.Count > 0)
            {
                startIndex = cut[cut.Count - 1] + 1;
            }
            for (int i = startIndex; i < s.Length - 1; i++)
            {
                cut.Add(i);
                p_115_WorkerProcess(s, cut, res);
                cut.Remove(i);
            }
        }

        private string p_115_Verify_ValidIP(string s, List<int> cut)
        {
            // Assert cut is 3 
            int lasIndex = 0;
            string s1 = s.Substring(0, cut[0] + 1);
            string s2 = s.Substring(cut[0] + 1, cut[1] - cut[0]);
            string s3 = s.Substring(cut[1] + 1, cut[2] - cut[1]);
            string s4 = s.Substring(cut[2] + 1);

            try
            {
                if (int.Parse(s1) <= 255 && int.Parse(s2) <= 255 && int.Parse(s3) <= 255 && int.Parse(s4) <= 255)
                {
                    return s1 + "." + s2 + "." + s3 + "." + s4;
                }
            }
            catch
            {
                return string.Empty;
            }
            return string.Empty;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/198/letter-combinations-of-a-phone-number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> p_116_LetterCombinationOfaPhoneNumber(int[] input)
        {
            List<string> dict = new List<string>();
            dict.Add("1");
            dict.Add("abc");
            dict.Add("def");
            dict.Add("ghi");
            dict.Add("jkl");
            dict.Add("mno");
            dict.Add("pqrs");
            dict.Add("tuv");
            dict.Add("wxyz");
            dict.Add("-");
            string s = string.Empty;
            List<string> res = new List<string>();
            p_116_LetterCombination_Worker(dict, s, input, res);

            return res;
        }

        private void p_116_LetterCombination_Worker(List<string> dict, string s, int[] input, List<string> res)
        {
            if (s.Length == input.Length)
            {
                res.Add(s);
                return;
            }

            int digit = input[s.Length];
            for (int i = 0; i < dict[digit].Length; i++)
            {
                p_116_LetterCombination_Worker(dict, s + dict[digit][i], input, res);
            }

        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/269/unique-binary-search-trees-ii
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<TreeNode> p_117_UniqueBSTII(int n)
        {
            List<TreeNode> res = p_117_UniqueBSTII_Worker(1, n);
            return res;
        }

        public List<TreeNode> p_117_UniqueBSTII_Worker(int start, int end)
        {
            if (end < start) return new List<TreeNode>() { null };

            List<TreeNode> res = new List<TreeNode>();

            for (int i = start; i <= end; i++)
            {
                List<TreeNode> leftNodes = p_117_UniqueBSTII_Worker(start, i - 1);
                List<TreeNode> rightNodes = p_117_UniqueBSTII_Worker(i + 1, end);

                foreach (TreeNode lnode in leftNodes)
                {
                    foreach (TreeNode rnode in rightNodes)
                    {
                        TreeNode node = new TreeNode(i);
                        node.LeftChild = lnode;
                        node.RightChild = rnode;
                        res.Add(node);
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/264/gray-code
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<int> p_118_GrayCode(int n)
        {
            return null;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/259/largest-rectangle-in-histogram
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_119_LargestRectangleinHistogram(List<int> input)
        {
            Stack<int> p = new Stack<int>();
            int i = 0;
            int max = 0;
            input.Add(0);

            while (i < input.Count)
            {
                if (p.Count == 0 || input[p.Peek()] <= input[i])
                {
                    p.Push(i);
                    i++;
                }
                else
                {
                    int t = p.Pop();
                    max = Math.Max(max, input[t] * (p.Count == 0 ? 1 : i - p.Peek() - 1));
                }

            }
            return max;
        }

        /// <summary>
        /// http://discuss.leetcode.com/questions/97/minimum-window-substring
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public int p_120_MinimumWindowSubString(string s, string t)
        {
            int start = 0;
            int end = 0;
            int max = int.MaxValue;
            int tCount = 0;
            int sCount = 0;

            Dictionary<char, int> track = new Dictionary<char, int>();
            Dictionary<char, int> match = new Dictionary<char, int>();

            for (int i = 0; i < t.Length; i++)
            {
                if (match.Keys.Contains(t[i]))
                {
                    match[t[i]] += 1;
                }
                else
                {
                    match[t[i]] = 1;
                    tCount++;
                }
            }

            while (end < s.Length)
            {
                char c = s[end];
                if (match.Keys.Contains(c))
                {
                    if (track.Keys.Contains(c))
                    {
                        track[c] += 1;
                        if (track[c] == match[c]) sCount++;
                    }
                    else
                    {
                        track[c] = 1;
                        if (track[c] == match[c]) sCount++;
                    }

                    //if (sCount == tCount && end - start + 1 < max)
                    //{
                    //    max = end - start + 1;
                    //}

                    if (track[c] > match[c] && sCount == tCount)
                    {
                        while (start <= end && (track[c] != match[c] || !match.Keys.Contains(s[start])))
                        {
                            char b = s[start];
                            if (track.Keys.Contains(b))
                            {
                                track[b]--;
                                if (track[b] != match[b])
                                {
                                    sCount--;
                                }
                            }
                            start++;
                        }
                    }

                    if (sCount == tCount && end - start + 1 < max)
                    {
                        max = end - start + 1;
                    }

                }
                end++;
            }
            return max;
        }

        /// <summary>
        /// http://leetcode.com/2012/05/clone-graph-part-i.html
        /// I guess the assumption is this is a connected graph, 
        /// </summary>
        /// <param name="node"></param>
        public GraphNode p_121_CloneGraph(GraphNode node)
        {
            Dictionary<GraphNode, GraphNode> track = new Dictionary<GraphNode, GraphNode>();
            p_121_helper(node, track);
            // p_121_AddEdges(node, track);
            return track[node];
        }

        public void p_121_helper(GraphNode node, Dictionary<GraphNode, GraphNode> tracker)
        {
            if (node == null) return;
            if (!tracker.Keys.Contains(node))
            {
                tracker.Add(node, new GraphNode(node.value));
                foreach (GraphNode n in node.Neighbors)
                {
                    p_121_helper(n, tracker);
                    tracker[node].Neighbors.Add(tracker[n]);
                }
            }
        }

        public GraphNode p_121_CloneGraphII(GraphNode node)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(node);
            Dictionary<GraphNode, GraphNode> tracker = new Dictionary<GraphNode, GraphNode>();
            while (q.Count != 0)
            {
                GraphNode n = q.Dequeue();
                if (!tracker.Keys.Contains(n))
                {
                    tracker.Add(n, new GraphNode(n.value));
                }
                foreach (GraphNode neighbor in n.Neighbors)
                {
                    if (!tracker.Keys.Contains(neighbor))
                    {
                        tracker.Add(neighbor, new GraphNode(neighbor.value));
                        q.Enqueue(neighbor);
                    }
                    tracker[n].Neighbors.Add(tracker[neighbor]);
                }
            }
            return tracker[node];
        }

        public GraphNode p_121_CloneGraphIII(GraphNode node)
        {
            Dictionary<GraphNode, GraphNode> tracker = new Dictionary<GraphNode, GraphNode>();
            Stack<GraphNode> s = new Stack<GraphNode>();
            s.Push(node);
            while (s.Count != 0)
            {
                GraphNode n = s.Pop();
                if (!tracker.Keys.Contains(n))
                {
                    tracker.Add(n, new GraphNode(n.value));
                }
                foreach (GraphNode neighbor in n.Neighbors)
                {
                    if (!tracker.Keys.Contains(neighbor))
                    {
                        tracker.Add(neighbor, new GraphNode(neighbor.value));
                        s.Push(neighbor);
                    }
                    tracker[n].Neighbors.Add(tracker[neighbor]);
                }
            }

            return tracker[node];
        }

        public class GraphNode
        {
            public GraphNode()
            {
            }

            public GraphNode(int v)
            {
                value = v;
            }
            public int value;
            public List<GraphNode> Neighbors = new List<GraphNode>();
        }

        /// <summary>
        /// http://leetcode.com/2012/01/palindrome-number.html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool p_122_IsAPalindromeNumber(int input)
        {
            if (input < 0) return false;
            if (input == 0) return true;

            int k = 0;
            while (Math.Pow(10, k) < input) k++;
            k = k - 1;
            while (input > 0 && k > 0)
            {
                if (input / (int)Math.Pow(10, k) == input % 10)
                {
                    input -= (input / (int)Math.Pow(10, k)) * (int)Math.Pow(10, k);
                    input /= 10;
                    k = k - 2;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// http://leetcode.com/2012/01/palindrome-number.html
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool p_122_IsPalindromeNumberII(int n)
        {
            if (n < 0) return false;
            if (n < 10) return true;
            int i = 1;
            while (Math.Pow(10, i) < n) i++;
            i--;

            while (i > 0)
            {
                int first = n / (int)Math.Pow(10, i);
                int last = n % 10;
                if (first != last)
                {
                    return false;
                }
                n = n - first * (int)Math.Pow(10, i);
                n = n / 10;
                i = i - 2;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int p_123_EditDistance(string s1, string s2)
        {
            if (s1 == string.Empty) return s2.Length;
            if (s2 == string.Empty) return s1.Length;

            int a = p_123_EditDistance(s1.Substring(1), s2.Substring(1));

            int b = 0;

            if (s2.Length > 1)
            {
                b = p_123_EditDistance(s1, s2.Substring(1)) + 1;
            }

            int c = 0;
            if (s1.Length > 1)
            {
                c = p_123_EditDistance(s1.Substring(1), s2) + 1;
            }

            int diff = s1[0] == s2[0] ? 0 : 1;
            a = a + diff;
            return Math.Min(Math.Min(a, b), c);
        }

        /// <summary>
        /// http://leetcode.com/2011/09/regular-expression-matching.html
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool p_124_RegularExpressionMatch(string s1, string p)
        {
            if (s1 == string.Empty)
            {
                return p_124_MatchEmtpy(p);
            }
            if (p == string.Empty)
            {
                return false;
            }

            char a0 = s1[0];
            char p0 = p[0];
            char p1 = p.Length > 1 ? p[1] : 'x';

            if (p1 == '*')
            {
                if (a0 == p0 || p0 == '.')
                {
                    return p_124_RegularExpressionMatch(s1.Substring(1), p) ||
                        p_124_RegularExpressionMatch(s1.Substring(1), p.Substring(2));
                }
                else
                {
                    return p_124_RegularExpressionMatch(s1, p.Substring(2));
                }
            }
            else
            {
                if (a0 == p0 || p0 == '.')
                {
                    return p_124_RegularExpressionMatch(s1.Substring(1), p.Substring(1));
                }
                else
                {
                    return false;
                }
            }
        }

        private bool p_124_MatchEmtpy(string p)
        {
            if (p.Length % 2 != 0) return false;
            for (int i = 0; i < p.Length - 1; i++)
            {
                if (p[i + 1] != '*')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// http://leetcode.com/2011/08/insert-into-a-cyclic-sorted-list.html
        /// </summary>
        /// <param name="k"></param>
        /// <param name="input"></param>
        public void p_125_InsertIntoCyclicSortedList(int k, List<int> input)
        {
            if (input.Count <= 1) input.Add(k);
            int mid = 0;
            int left = 0;
            int right = input.Count - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (mid - 1 >= 0)
                {
                    if (k >= input[mid - 1] && k <= input[mid])
                    {
                        input.Insert(mid, k);
                        return;
                    }
                    else
                    {
                        if (input[mid - 1] > input[mid] &&
                        (k >= input[mid - 1] || k <= input[mid]))
                        {
                            input.Insert(mid, k);
                            return;
                        }
                    }
                }
                if (mid + 1 < input.Count)
                {
                    if (k >= input[mid] && k <= input[mid + 1])
                    {
                        input.Insert(mid + 1, k);
                        return;
                    }
                    else
                    {
                        if (input[mid] > input[mid + 1] &&
                            (k >= input[mid] || k <= input[mid + 1]))
                        {
                            input.Insert(mid + 1, k);
                            return;
                        }
                    }
                }

                if (mid == 0)
                {
                    if (k < input[0])
                    {
                        input.Insert(0, k);
                        return;
                    }
                    else
                    {
                        input.Insert(1, k);
                        return;
                    }
                }
                if (mid == input.Count - 1)
                {
                    if (k < input[mid])
                    {
                        input.Insert(input.Count - 2, k);
                        return;
                    }
                    else
                    {
                        input.Insert(input.Count - 1, k);
                        return;
                    }
                }

                if (input[left] < input[mid] &&
                    k >= input[left] && k <= input[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return;
        }

        public List<int> P_126_PostOrderTravel(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            TreeNode previous = null;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (tmp.LeftChild != null &&
                    tmp.LeftChild != previous &&
                    (tmp.RightChild == null || tmp.RightChild != previous))
                {
                    s.Push(tmp.LeftChild);
                }
                else if (tmp.RightChild != null &&
                    tmp.RightChild != previous)
                {
                    s.Push(tmp.RightChild);
                }
                else
                {
                    s.Pop();
                    res.Add(tmp.Value);
                    previous = tmp;
                }
            }
            return res;
        }

        public List<int> p_127_InOrderTravel(TreeNode root)
        {
            List<int> res = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            bool isBackTrack = false;
            while (s.Count != 0)
            {
                TreeNode tmp = s.Peek();
                if (!isBackTrack && tmp.LeftChild != null)
                {
                    s.Push(tmp.LeftChild);
                    continue;
                }

                res.Add(tmp.Value);
                s.Pop();
                isBackTrack = true;

                if (isBackTrack && tmp.RightChild != null)
                {
                    isBackTrack = false;
                    s.Push(tmp.RightChild);
                }
            }
            return res;
        }

        public List<int> p_128_ZigZagTravel(TreeNode root)
        {
            // check null;
            List<int> res = new List<int>();
            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();
            bool isForward = true;
            s1.Push(root);
            while (s1.Count != 0)
            {
                while (s1.Count != 0)
                {
                    TreeNode tmp = s1.Peek();
                    if (isForward)
                    {
                        if (tmp.LeftChild != null) s2.Push(tmp.LeftChild);
                        if (tmp.RightChild != null) s2.Push(tmp.RightChild);
                    }
                    else
                    {
                        if (tmp.RightChild != null) s2.Push(tmp.RightChild);
                        if (tmp.LeftChild != null) s2.Push(tmp.LeftChild);
                    }
                    s1.Pop();
                    res.Add(tmp.Value);
                }
                s1 = s2;
                s2 = new Stack<TreeNode>();
                isForward = !isForward;
            }
            return res;
        }

        public int p_127_FindTopK(int[] input, int k, int startIndex, int endIndex)
        {
            if (endIndex < startIndex) return -1;
            if (k > input.Length) return -1;
            int left = startIndex;
            int right = endIndex;

            while (left <= right)
            {
                //random swa p one element to index left.
                while (left <= right && input[left] <= input[startIndex]) left++;
                while (right >= left && input[right] >= input[startIndex]) right--;
                if (left <= right)
                {
                    p_127_helper(input, left, right);
                    left++;
                    right--;
                }
            }
            if (startIndex != left)
            {
                p_127_helper(input, startIndex, left - 1);
                left--;
            }

            if (k - 1 == left)
            {
                return input[left];
            }
            else if (k - 1 < left)
            {
                return p_127_FindTopK(input, k, startIndex, left - 1);
            }
            else
            {
                return p_127_FindTopK(input, k, left + 1, endIndex);
            }
        }

        private void p_127_helper(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        public TreeNode p_130_FindLCA(TreeNode root, int i, int j)
        {
            if (root == null) return null;
            if (root.Value == i || root.Value == j) return root;

            TreeNode leftRes = p_130_FindLCA(root.LeftChild, i, j);
            TreeNode rightRes = p_130_FindLCA(root.RightChild, i, j);

            if (leftRes != null && rightRes != null) return root;
            if (leftRes != null) return leftRes;
            if (rightRes != null) return rightRes;
            return null;
        }

        public bool p_131_RegesMatch(string s, string p)
        {
            if (s.Length == 0) return p_131_MatchEmptyString(p);
            if (p.Length == 0) return false;

            char s0 = s[0];
            char p0 = p[0];
            char p1 = p.Length >= 2 ? p[1] : 'x';

            if (p1 == '*')
            {
                if (p0 == '.' || p0 == s0)
                {
                    return p_131_RegesMatch(s.Substring(1), p.Substring(2)) || p_131_RegesMatch(s.Substring(1), p);
                }
                else
                {
                    return p_131_RegesMatch(s, p.Substring(2));
                }
            }
            else
            {
                if (p0 == '.' || p0 == s0)
                {
                    return p_131_RegesMatch(s.Substring(1), p.Substring(1));
                }
                else
                {
                    return false;
                }
            }

        }

        public bool p_131_MatchEmptyString(string p)
        {
            if (p.Length % 2 != 0) return false;
            for (int i = 1; i < p.Length; i = i + 2)
            {
                if (p[i] != '*')
                {
                    return false;
                }
            }
            return true;
        }

        public string p_132_NthPermutation(char[] s, int k)
        {
            // check if k > n^n. throw exception.
            int count = 0;
            P_132_Help(s, k, ref count, 0);
            return new string(s);
        }

        public bool P_132_Help(char[] s, int k, ref int count, int level)
        {
            if (k == count)
            {
                return true;
            }
            if (level == s.Length - 1)
            {
                count++;
                return false;
            }

            P_132_Help(s, k, ref count, level + 1);
            for (int i = level; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    p_132_Swap(s, i, j);
                    if (P_132_Help(s, k, ref count, level + 1))
                    {
                        return true;
                    }
                    p_132_Swap(s, i, j);
                }
            }
            return false;
        }

        public void p_132_Swap(char[] s, int i, int j)
        {
            // make sure i and j are less than s.Length;
            char tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;
        }

        public List<List<int>> p_133_FindChanges(int[] coins, int t)
        {
            List<int> tracker = new List<int>();
            List<List<int>> res = new List<List<int>>();
            int sum = 0;
            p_133_helper(coins, tracker, ref sum, t, res);
            return res;

        }

        public void p_133_helper(int[] coins, List<int> tracker, ref int sum, int t, List<List<int>> res)
        {
            if (sum == t)
            {
                List<int> tmp = new List<int>(tracker);
                res.Add(tmp);
                return;
            }
            if (sum > t)
            {
                return;
            }
            for (int i = 0; i < coins.Length; i++)
            {
                tracker.Add(coins[i]);
                sum += coins[i];
                p_133_helper(coins, tracker, ref sum, t, res);
                sum -= coins[i];
                tracker.Remove(coins[i]);
            }
        }

        /// <summary>
        /// http://leetcode.com/2011/05/a-distance-maximizing-problem.html
        /// did not get this question right. thinking.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int p_134_DistanceMax(int[] input)
        {
            Stack<int> s = new Stack<int>();
            int max = 0;
            s.Push(0);
            for (int i = 1; i < input.Length; i++)
            {
                while (s.Count != 0 && s.Peek() < input[i])
                {
                    max = max > input[i] - input[s.Peek()] ? max : i - s.Peek();
                    s.Pop();
                }
                s.Push(i);
            }
            return max;
        }

        /// <summary>
        /// http://leetcode.com/2011/05/longest-substring-without-repeating-characters.html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string p_135_LongestSubString(string input)
        {
            int[] tracker = new int[256];
            int left = 0; int right = 1;
            tracker[input[left]]++;
            int max = 1;
            int leftindex = 0;
            int rightindex = 1;
            while (right < input.Length)
            {
                tracker[input[right]]++;
                if (tracker[input[right]] > 1)
                {
                    while (input[left] != input[right])
                    {
                        tracker[input[left]]--;
                        left++;
                    }
                    tracker[input[left]]--;
                    left++;
                }

                if (right - left > max)
                {
                    max = right - left;
                    leftindex = left;
                    rightindex = right;
                }
                right++;
            }
            return input.Substring(leftindex, rightindex - leftindex + 1);
        }
    }

    public class Amazon
    {
        /// <summary>
        /// Give a Domino and a set of Dominos find the longest list can be formded
        /// </summary>
        /// <param name="input"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int p_001_FindLongestDomino(List<Domino> input, Domino d)
        {
            HashSet<Domino> track = new HashSet<Domino>();
            List<Domino> res = new List<Domino>() { d };
            d.Forward = true;
            int max = LongestDomino(input, track, 0, res);
            return max;
        }

        public int LongestDomino(List<Domino> input, HashSet<Domino> track, int level, List<Domino> res)
        {
            bool frontAdd = false;
            bool backAdd = false;
            int max = res.Count;

            for (int i = level; i < input.Count; i++)
            {
                Domino d1 = input[i];
                if (!track.Contains(d1))
                {
                    if (d1.Face.Item2 == res[0].FrontValue)
                    {
                        d1.Forward = true;
                        res.Insert(0, d1);
                        track.Add(d1);
                        frontAdd = true;
                    }
                    else if (d1.Face.Item1 == res[0].FrontValue)
                    {
                        d1.Forward = false;
                        res.Insert(0, d1);
                        track.Add(d1);
                        frontAdd = true;
                    }
                }

                for (int j = level; j < input.Count; j++)
                {
                    Domino d2 = input[j];
                    if (!track.Contains(d2))
                    {
                        if (d2.Face.Item2 == res[res.Count - 1].BackValue)
                        {
                            d2.Forward = false;
                            res.Insert(0, d2);
                            track.Add(d2);
                            backAdd = true;
                        }
                        else if (d2.Face.Item1 == res[res.Count - 1].BackValue)
                        {
                            d2.Forward = true;
                            res.Add(d2);
                            track.Add(d2);
                            backAdd = true;
                        }
                    }

                    int tmp = LongestDomino(input, track, level + 1, res);
                    max = Math.Max(max, Math.Max(tmp, res.Count));

                    if (backAdd)
                    {
                        res.Remove(d2);
                        track.Remove(d2);
                    }
                }
                if (frontAdd)
                {
                    res.Remove(d1);
                    track.Remove(d1);
                }
            }
            return max;
        }

        public class Domino
        {
            public Domino(Tuple<int, int> face, bool forward)
            {
                this.Face = face;
                this.Forward = forward;
            }

            public Tuple<int, int> Face;
            public bool Forward;
            public int FrontValue
            {
                get
                {
                    if (Forward)
                    {
                        return Face.Item1;
                    }
                    else
                    {
                        return Face.Item2;
                    }
                }
            }

            public int BackValue
            {
                get
                {
                    if (Forward)
                    {
                        return Face.Item2;
                    }
                    else
                    {
                        return Face.Item1;
                    }
                }
            }
        }


        /// <summary>
        /// Given a file with a list of all English words, match a string that can include the '?' wildcard..
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool p_002_MatchingWords(string s, string p)
        {
            if (s.Length == 0)
            {
                if (IsNullPattern(p))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if (p.Length == 0)
            {
                return false;
            }

            char s1 = s[0];
            char p1 = p[0];
            char p2 = p.Length > 1 ? p[1] : 'x';

            if (p2 == '*')
            {
                if (s1 == p1 || p1 == '.')
                {
                    return p_002_MatchingWords(s.Substring(1), p) || p_002_MatchingWords(s.Substring(1), p.Substring(2));
                }
                else
                {
                    return p_002_MatchingWords(s, p.Substring(2));
                }
            }
            else
            {
                if (s1 == p1 || p1 == '.')
                {
                    return p_002_MatchingWords(s.Substring(1), p.Substring(1));
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsNullPattern(string p)
        {
            if (p.Length % 2 != 0) return false;
            for (int i = 1; i < p.Length; i = i + 2)
            {
                if (p[i] != '*')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Given an input string write a function that can count words or count of lines.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int p_003_CountTheWords(string s)
        {
            if (s.Length == 0) return 0;
            int count = s[1] == ' ' ? 0 : 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] == ' ' && s[i] != ' ')
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Given a list of all word in the English language, and a word string, find all anagrams. You can assume unlimited memory and unlimited preprocessing time.
        /// </summary>
        public List<string> p_004_Find_AllAnagram(List<string> dict, string word)
        {
            // 1. set hashtable, key will be a anagram.
            // 2. prcoess all words in dict, sort the chars int word, find anagram 
            // 3. insert the un sorted word into hashtable base on anagram.
            // 4. when search, sort the word, find the sorted string in dict and return the list of words.
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public List<string> p_005_Find_All_StartWith(Oj.TrieNode root, string prefix)
        {
            Oj.TrieNode tmp = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (tmp.nodes[prefix[i] - 'a'] != null)
                {
                    tmp = tmp.nodes[prefix[i] - 'a'];
                }
                else
                {
                    return null;
                }
            }

            List<string> res = new List<string>();
            p_005_Worker(tmp, res, prefix);
            return res;
        }

        public void p_005_Worker(Oj.TrieNode root, List<string> res, string s)
        {
            if (root.IsWord)
                res.Add(s);

            for (int i = 0; i < root.nodes.Length; i++)
            {
                if (root.nodes[i] != null)
                {
                    p_005_Worker(root.nodes[i], res, s + (char)('a' + i));
                }
            }
        }

        public void p_005_InsertIntoTrie(Oj.TrieNode root, string s)
        {
            if (root == null) { /*throw exception. */}
            if (s == string.Empty)
            {
                root.IsWord = true;
                return;
            }

            if (root.nodes[s[0] - 'a'] == null)
            {
                root.nodes[s[0] - 'a'] = new Oj.TrieNode();
            }
            p_005_InsertIntoTrie(root.nodes[s[0] - 'a'], s.Substring(1));

        }

        /// <summary>
        /// http://www.mitbbs.com/article/JobHunting/32335965_3.html
        /// original question is double linked list. logic is same as 
        /// </summary>
        /// <param name="node"></param>
        public LinkListNode p_006_SortDoubleLinkedList(LinkListNode node)
        {
            LinkListNode olderHeader = new LinkListNode();
            olderHeader.Next = node;
            LinkListNode newHeader = new LinkListNode();
            LinkListNode tmp = olderHeader.Next;
            LinkListNode current = newHeader;

            while (tmp != null)
            {
                olderHeader.Next = tmp.Next;
                current = newHeader;
                while (current.Next != null && tmp.Value > current.Next.Value)
                {
                    current = current.Next;
                }

                tmp.Next = current.Next;
                current.Next = tmp;
                tmp = olderHeader.Next;
            }
            return newHeader.Next;
        }

        /// <summary>
        /// http://www.mitbbs.com/article/JobHunting/32335965_3.html
        /// 例子（底层数量一定是2的幂）：
        ///3  -5  4  -6
        ///结果
        ///                  -4
        ///          -2               -2
        ///      3        -5     4        -6
        /// </summary>
        /// <param name="input"></param>
        public TreeNode p_007_CreateTree(int[] input)
        {
            // check if input.Length is the 2 power of n.
            TreeNode res = p_007_Workder(input, 0, input.Length - 1);
            return res;
        }

        public TreeNode p_007_Workder(int[] input, int left, int right)
        {
            if (right < left) return null;
            if (left == right) return new TreeNode(input[left]);

            int mid = left + (right - left) / 2;
            TreeNode leftNode = p_007_Workder(input, left, mid);
            TreeNode rightNode = p_007_Workder(input, mid + 1, right);
            TreeNode node = new TreeNode(leftNode.Value + rightNode.Value);
            node.LeftChild = leftNode;
            node.RightChild = rightNode;
            return node;
        }

        /// <summary>
        /// 1。给一个迷宫，2维的，一个起始点，一个终点，找到这两个点之间的path。白板写代码

        /// </summary>
        /// <param name="input"></param>
        /// <param name="startx"></param>
        /// <param name="starty"></param>
        /// <param name="endx"></param>
        /// <param name="endy"></param>
        /// <returns></returns>
        public bool p_008_MazeTravel(int[,] input, int startx, int starty, int endx, int endy)
        {
            if (startx == endx && starty == endy)
            {
                return true;
            }

            input[startx, starty] = 1;

            for (int i = startx - 1; i <= startx + 1; i++)
            {
                for (int j = starty - 1; j <= starty + 1; j++)
                {
                    if ((i >= 0 && i < input.GetLength(0)) &&
                        (j >= 0 && j < input.GetLength(1)) &&
                        !(i == startx && j == starty))
                    {
                        if (input[i, j] == 0)
                        {
                            if (p_008_MazeTravel(input, i, j, endx, endy))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }

    public class Cc150
    {
        public string p_1_5_CompressString(string input)
        {
            // make sure input is not null.
            StringBuilder sb = new StringBuilder();
            char c = input[0];
            int charCount = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != c)
                {
                    sb.Append(c.ToString() + charCount.ToString());
                    c = input[i];
                    charCount = 1;
                }
                else
                {
                    charCount++;
                }
            }

            sb.Append(c.ToString() + charCount.ToString());

            if (sb.Length < input.Length)
            {
                input = sb.ToString();
            }

            return input;
        }

        public LinkListNode p_2_1_RemoveDup(LinkListNode node)
        {
            LinkListNode dummyHeader = new LinkListNode();
            LinkListNode tmp = dummyHeader;
            LinkListNode cur = null;
            while (node != null)
            {
                cur = node;
                node = node.Next;
                tmp = dummyHeader;
                while (tmp != null)
                {
                    if (tmp.Next == null || tmp.Next.Value > cur.Value)
                    {
                        cur.Next = tmp.Next;
                        tmp.Next = cur;
                        break;
                    }
                    else if (tmp.Next.Value == cur.Value)
                    {
                        break;
                    }
                    else
                    {
                        tmp = tmp.Next;
                    }
                }
            }

            return dummyHeader.Next;
        }

        public LinkListNode p_2_2_KthFromLast(LinkListNode node, int k)
        {
            int counter = 0;
            LinkListNode res = p_2_2_Worker(node, ref counter, k);
            return res;
        }

        public LinkListNode p_2_2_Worker(LinkListNode node, ref int counter, int k)
        {
            if (node == null)
            {
                counter = 0;
                return null;
            }

            LinkListNode res = p_2_2_Worker(node.Next, ref counter, k);
            if (res != null)
            {
                return res;
            }
            if (counter == k - 1)
            {
                return node;
            }
            else
            {
                counter++;
                return null;
            }
        }

        public LinkListNode p_2_2_KthFromLastII(LinkListNode node, int k)
        {
            LinkListNode fast = node;
            for (int i = 0; i < k; i++)
            {
                if (fast != null)
                {
                    fast = fast.Next;
                }
                else
                {
                    // thro exception.
                }
            }
            LinkListNode res = node;
            while (fast != null)
            {
                fast = fast.Next;
                res = res.Next;
            }
            return res;
        }

        public class SpecialStack
        {
            private Stack<int> s = new Stack<int>();
            private Stack<int> min = new Stack<int>();

            public void Push(int i)
            {
                s.Push(i);
                if (min.Count == 0 || i < min.Peek())
                {
                    min.Push(i);
                }
            }

            public int Pop()
            {
                if (s.Count > 0)
                {
                    int res = s.Pop();
                    if (res == min.Peek())
                    {
                        min.Pop();
                    }
                    return res;
                }

                return -1;
            }

            public int Min()
            {
                if (min.Count != 0)
                {
                    return min.Peek();
                }

                return int.MaxValue;
            }
        }

        public class C_3_5_MyQueue
        {
            private Stack<int> main = new Stack<int>();
            private Stack<int> tmp = new Stack<int>();

            public void Enqueue(int i)
            {
                main.Push(i);
            }

            public int Dequeue()
            {
                if (main.Count == 0)
                {
                    // throw exception
                }

                while (main.Count > 0)
                {
                    tmp.Push(main.Pop());
                }

                int res = tmp.Pop();

                while (tmp.Count > 0)
                {
                    main.Push(tmp.Pop());
                }
                return res;
            }
        }

        public bool p_4_2_IsARoute(List<GraphNode> graph, GraphNode n1, GraphNode n2)
        {
            return p_4_2_Helper(graph, n1, n2) || p_4_2_Helper(graph, n2, n1);
        }

        public bool p_4_2_Helper(List<GraphNode> graph, GraphNode n1, GraphNode n2)
        {
            if (n1 == n2) return true;
            HashSet<GraphNode> g = new HashSet<GraphNode>();
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(n1);
            g.Add(n1);
            while (q.Count != 0)
            {
                GraphNode tmp = q.Dequeue();
                foreach (GraphNode n in tmp.Neighbors)
                {
                    if (!g.Contains(n))
                    {
                        if (n2 == n)
                        {
                            return true;
                        }
                        else
                        {
                            g.Add(n);
                            q.Enqueue(n);
                        }
                    }
                }
            }
            return false;
        }

        public int p_17_8_FindMaxContiguous(int[] input)
        {
            int max = int.MinValue;

            int tmp = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (tmp + input[i] < 0)
                {
                    tmp = 0;
                    continue;
                }
                else
                {
                    tmp += input[i];
                    max = tmp > max ? tmp : max;
                }
            }

            if (max == int.MinValue)
            {
                return 0;
            }
            else
            {
                return max;
            }
        }

        public void p_17_14_BreakDownString(string input)
        {
        }

        public uint p_18_1_Add(uint n1, uint n2)
        {
            uint res = 0;
            uint carry = 0;

            for (int i = 0; i < 32; i++)
            {
                uint a = (n1 >> i) & 1;
                uint b = (n2 >> i) & 1;

                res = res | (((a ^ b) ^ carry) << i);
                carry = (a & b) | (a & carry) | (b & carry);
            }
            res |= carry << 31;
            return res;
        }

        public void p_18_2_PerfectShuffle(int[] cards)
        {
            Random rand = new Random();
            int k = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                k = rand.Next(i, cards.Length - 1);
                p_18_2_swap(cards, i, k);
            }
        }

        private void p_18_2_swap(int[] cards, int i, int j)
        {
            int tmp = cards[i];
            cards[i] = cards[j];
            cards[j] = tmp;
        }

        public int p_18_5_FindShortDistance(string[] input, string s1, string s2)
        {
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!dict.Keys.Contains(input[i]))
                {
                    dict.Add(input[i], new List<int>());
                }
                dict[input[i]].Add(i);
            }

            if (!dict.Keys.Contains(s1) || !dict.Keys.Contains(s2)) return int.MaxValue; // or throw exception.

            List<int> left = dict[s1];
            List<int> right = dict[s2];
            int distance = int.MaxValue;

            int k = 0;
            int j = 0;
            while (k < left.Count && j < right.Count)
            {
                if (Math.Abs(right[j] - left[k]) < distance)
                {
                    distance = Math.Abs(right[j] - left[k]);
                }
                if (right[j] >= left[k])
                {
                    k++;
                }
                else
                {
                    j++;
                }
            }
            return distance;
        }
    }

    public class Zillow
    {
        /// <summary>
        /// Assumption:
        ///  1. string can have prefix spaces, such blank or new line
        ///  2. string can have +/- sign at the begining of the number.
        ///  3. charactor other than digit will be considered as invalidate char and except will be throw.
        ///     123, -1234 are valid number and 123E7 is NOT a valid number
        ///  4. if result number is larger than the long.MaxValue or less than long.MinValue exception will throw
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public long StringToLong(string input)
        {
            long res = 0;
            int sign = 1;
            int c = 0;

            int i = 0;
            while (i < input.Length && IsSpace(input[i]))
            {
                i++;
            }

            if (input[i] == '+' || input[i] == '-')
            {
                if (input[i] == '-')
                {
                    sign = -1;
                }
                i++;
            }

            while (i < input.Length)
            {
                if (!IsDigit(input[i]))
                {
                    throw new FormatException(input + "is not a valid number");
                }

                c = input[i] - '0';
                if (sign > 0 && (res > long.MaxValue / 10 || (res == long.MaxValue / 10 && c > long.MaxValue % 10)))
                {
                    throw new OverflowException(input + "is larger than maximum long");
                }
                else if (sign < 0 && (res > long.MaxValue / 10 || (res == long.MaxValue / 10 && c > long.MaxValue % 10 + 1)))
                {
                    throw new OverflowException(input + "is less than minmum long.");
                }

                res = (res * 10) + c;
                i++;
            }
            return sign > 0 ? res : -res;
        }

        private bool IsSpace(char c)
        {
            if (c == ' ' ||
                c == '\t' ||
                c == '\r' ||
                c == '\n')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsDigit(char c)
        {
            if (c - '0' <= 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Insert a int into to Trinary Tree. 
        /// Assumption: Trinary tree node has an interge value. 
        /// if not we can implement the class with generic/template
        /// </summary>
        /// <param name="root"></param>
        /// <param name="input"></param>
        public void Insert(TrinaryTreeNode root, int input)
        {
            Insert(root, new TrinaryTreeNode() { Value = input });
        }

        /// <summary>
        /// insert a Trinary node into tree.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node"></param>
        public void Insert(TrinaryTreeNode root, TrinaryTreeNode node)
        {
            if (root == null)
            {
                throw new ArgumentException("root can not be null");
            }
            if (node == null)
            {
                throw new ArgumentException("node can not be null");
            }

            if (root.Value == node.Value)
            {
                while (root.MiddleChild != null)
                {
                    root = root.MiddleChild;
                }
                root.MiddleChild = node;
            }
            else if (node.Value < root.Value)
            {
                if (root.LeftChild == null)
                {
                    root.LeftChild = node;
                }
                else
                {
                    Insert(root.LeftChild, node);
                }
            }
            else
            {
                if (root.RightChild == null)
                {
                    root.RightChild = node;
                }
                else
                {
                    Insert(root.RightChild, node);
                }
            }
        }

        /// <summary>
        /// this method will delete the node in the tree, node. 
        /// the delete method take 2 nodes as input, one is root note and one is node to be deleted.
        /// I did not take value of node to delete becuase there are might be multiple nodes have same
        /// value.
        /// </summary>
        /// <param name="root">the tree's root node</param>
        /// <param name="input">the node to be delete</param>
        public TrinaryTreeNode Delete(TrinaryTreeNode root, TrinaryTreeNode node)
        {
            if (root == null)
            {
                throw new ArgumentException("root can not be null");
            }
            if (node == null)
            {
                return root; // nothing to delete
            }

            if (root == node)
            {
                TrinaryTreeNode left = root.LeftChild;
                TrinaryTreeNode right = root.RightChild;
                TrinaryTreeNode middle = root.MiddleChild;

                if (middle != null)
                {
                    if (left != null)
                    {
                        if (middle.LeftChild == null)
                        {
                            middle.LeftChild = left;
                        }
                        else
                        {
                            Insert(middle.LeftChild, left);
                        }
                    }

                    if (right != null)
                    {
                        if (middle.RightChild == null)
                        {
                            middle.RightChild = right;
                        }
                        else
                        {
                            Insert(middle.RightChild, right);
                        }
                    }
                    return middle;
                }
                else if (left != null)
                {
                    if (right != null)
                    {
                        if (left.RightChild == null)
                        {
                            left.RightChild = right;
                        }
                        else
                        {
                            Insert(left.RightChild, right);
                        }
                    }
                    return left;
                }
                else
                {
                    return right;
                }
            }
            else
            {
                // by Trinary's definition we can not  decide which sub tree can contains the node
                // so we need try to delete it in three sub tree.
                if (root.LeftChild != null)
                {
                    root.LeftChild = Delete(root.LeftChild, node);
                }
                if (root.MiddleChild != null)
                {
                    root.MiddleChild = Delete(root.MiddleChild, node);
                }
                if (root.RightChild != null)
                {
                    root.RightChild = Delete(root.RightChild, node);
                }
                return root;
            }
        }
    }

    /// <summary>
    /// Trinary Tree node class
    /// </summary>
    public class TrinaryTreeNode
    {
        public int Value;
        public TrinaryTreeNode LeftChild;
        public TrinaryTreeNode MiddleChild;
        public TrinaryTreeNode RightChild;
    }

}
