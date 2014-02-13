using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class OtherQuestion
    {
        /*
         * [Pinterest] 给一个数组和一个位置，从该位置起左右jump，检测能否jump到值为0的位置
            canJump(int a[], int pos)
            https://bay165.mail.live.com/default.aspx?id=64855#n=1810192880&view=1
         */
        public bool _020_CanJump(int[] a, int pos)
        {
            // check a and pos etc ...
            bool[] tracker = new bool[a.Length];
            return CanJumpWorker(a, tracker, pos);
        }

        public bool CanJumpWorker(int[] a, bool[] tracker, int k)
        {
            int left = k - a[k];
            int right = k + a[k];

            if (left == 0)
                return true;
            
            bool found = false;
            if (left >= 0 && !tracker[left])
            {
                tracker[left] = true;
                found = CanJumpWorker(a, tracker, left);
                if (found)
                    return true;
            }
            if (right < a.Length && !tracker[right])
            {
                tracker[right] = true;
                found = CanJumpWorker(a, tracker, right);
                if (found)
                    return true;

            }
            return false;
        }


        public bool _020_canJumpII(int[] A, int pos)
        {
            int n = A.Length;
            int i = pos, j = pos;
            int min = pos, max = pos;

            do
            {
                while (i >= min)
                {
                    min = Math.Min(min, Math.Max(0, i - A[i]));
                    max = Math.Max(max, Math.Min(n - 1, i + A[i]));
                    i--;
                }
                i++;

                while (j <= max)
                {
                    min = Math.Min(min, Math.Max(0, j - A[j]));
                    max = Math.Max(max, Math.Min(n - 1, j + A[j]));
                    j++;
                }

                j--;

            } while (i != min || j != max);

            return i == 0;
        }

        public string _021_LongestCommonPrefix(List<string> input)
        {
            // set input to lower for all string.
            // check empty, null ....
            TrieNode root = new TrieNode();
            ConstructTrie(input, root);
            StringBuilder sb = new StringBuilder();
            int tmplength = 0;
            int length = 0;
            string prefix = string.Empty;
            FindLongest(root, sb, tmplength, ref prefix, ref length);

            return prefix;

        }

        private void FindLongest(TrieNode root, StringBuilder tmp, int tmpLength, ref string s, ref int length)
        {
            if (tmpLength < length)
            {
                for (int i = 0; i < root.Children.Length; i++)
                {
                    if (root.count[i] > 1)
                    {
                        FindLongest(root.Children[i], tmp.Append((char)('a' + i)), tmpLength + 1, ref s, ref length);
                        tmp.Remove(tmp.Length - 1, 1);
                    }
                }
            }
            else
            {
                for (int i = 0; i < root.Children.Length; i++)
                {
                    if (root.count[i] > 1 && tmpLength >= length)
                    {
                        s = tmp.Append((char)('a' + i)).ToString();
                        length = tmpLength + 1;
                        FindLongest(root.Children[i], tmp, tmpLength + 1, ref s, ref length);
                        tmp.Remove(tmp.Length - 1, 1);
                    }
                }
            }
        }

        private void ConstructTrie(List<string> input, TrieNode root)
        {
            foreach (string str in input)
            {
                InsertString(str, root);
            }
        }

        public void InsertString(string str, TrieNode root)
        {
            if (str.Length == 0 || string.IsNullOrEmpty(str))
            {
                return;
            }
            else
            {
                if (root.Children[str[0] - 'a'] == null)
                {
                    root.Children[str[0] - 'a'] = new TrieNode();
                }
                root.count[str[0] - 'a']++;
                InsertString(str.Substring(1), root.Children[str[0] - 'a']);
            }
        }

        // assume english and all lower case. and only 26 characters.
        public class TrieNode
        {
            public TrieNode[] Children = new TrieNode[26];
            public int[] count = new int[26];
        }

        /// <summary>
        /// [Twitter] 最长连续上升子串，给定字符串，输出最长连续上升子串的起始点和长度.
        /// http://www.mitbbs.com/article_t/JobHunting/32436737.html
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="length"></param>
        public void _022_LongestIncrease(int[] input, ref int startIndex, ref int endIndex, ref int length)
        {
            System.Diagnostics.Debug.Assert(input != null);
            System.Diagnostics.Debug.Assert(input.Length != 0);

            int[] longestLength = new int[input.Length];
            int[] parent = new int[input.Length];
            longestLength[0] = 1;
            for (int i = 0; i < input.Length; i++)
            {
                parent[i] = i;
            }

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (input[i] > input[j] && longestLength[j] + 1 > longestLength[i])
                    {
                        longestLength[i] = longestLength[j] + 1;
                        parent[i] = j;
                    }
                }
            }

            int longestIndex = -1;
            int longestLen = 0;
            for (int i = 0; i < longestLength.Length; i++)
            {
                if (longestLength[i] > longestLen)
                {
                    longestLen = longestLength[i];
                    longestIndex = i;
                }
            }

            int preindex = longestIndex;
            int reslength = 1;
            while (preindex != parent[preindex])
            {
                preindex = parent[preindex];
                reslength++;
            }
            startIndex = preindex;
            endIndex = longestIndex;
            length = reslength;
            return;
        }


    }
}
