using Infra;
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

        /// <summary>
        /// Given a string, find longest substring which contains just two unique characters.
        /// http://www.mitbbs.com/article_t/JobHunting/32440405.html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int _023_Longest_UniqueString(string input)
        {
            int count = 0;
            int maxLength = 0;
            int length = 0;
            int startIndex = 0;
            int endEndIndex = 0;
            int[] tracker = new int[26]; // assume lower case character, easily expand
            while (endEndIndex < input.Length - 1)
            {
                if (count <= 2)
                {
                    endEndIndex++;
                    if (tracker[input[endEndIndex] - 'a'] == 0)
                    {
                        count++;
                    }
                    tracker[input[endEndIndex] - 'a']++;
                    length = endEndIndex - startIndex;
                    if (count <= 2)
                    {
                        maxLength = maxLength > length ? maxLength : length;
                    }
                }
                else
                {
                    startIndex++;
                    if (tracker[input[startIndex] - 'a'] == 1)
                    {
                        count--;
                    }
                    tracker[input[startIndex] - 'a']--;
                }
            }

            return maxLength;
        }

        /// <summary>
        /// T' question sort a linked list 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public LinkListNode _024_SortLinkedList(LinkListNode input)
        {
            if (input == null || input.Next == null) return input;
            LinkListNode fast = input;
            LinkListNode slow = input;

            while (fast.Next != null && fast.Next.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            LinkListNode Right = slow.Next;
            slow.Next = null;
            input = _024_SortLinkedList(input);
            Right = _024_SortLinkedList(Right);

            LinkListNode dummyHeader = new LinkListNode();
            LinkListNode current = dummyHeader;
            LinkListNode tmp = null;
            while (input != null && Right != null)
            {
                if (input.Value < Right.Value)
                {
                    tmp = input;
                    input = input.Next;
                }
                else
                {
                    tmp = Right;
                    Right = Right.Next;
                }

                current.Next = tmp;
                current = current.Next;
            }

            LinkListNode res = null;
            if (input == null)
            {
                res = Right;
            }
            else
            {
                res = input;
            }

            while (res != null)
            {
                current.Next = res;
                current = current.Next;
                res = res.Next;
            }

            return dummyHeader.Next;
        }

        /// <summary>
        /// given a array [1,2,3,5,2,1], which means one 2, three 5s, two 1s (sort of like a zip format), code the iterator sort of class with HasNext(), GetNext()
        /// </summary>
        public class ArrayIterator
        {
            int[] tracker;
            int index = 0;
            int count = 0;
            public ArrayIterator(int[] input)
            {
                tracker = input;
                if (input == null || input.Length == 0 || input.Length % 2 != 0)
                {
                    //Throw exception
                }
                count = tracker[index];
            }
            public int GetNext()
            {
                if (HasNext())
                {
                    count--;
                    return tracker[index + 1];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

            public bool HasNext()
            {
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    if (index == tracker[tracker.Length - 1])
                    {
                        return false;
                    }
                    else
                    {
                        while (count <= 0 && index < tracker.Length - 2)
                        {
                            index += 2;
                            count = tracker[index];
                        }

                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }


        }

        /// <summary>
        /// Count the inversionAgain
        /// </summary>
        /// <param name="input"></param>
        public int _025_CounterTheInversion(int[] input)
        {
            int[] tracker = new int[input.Length];
            return MergeSort(input, tracker, 0, input.Length - 1);
        }

        public int MergeSort(int[] input, int[] tracker, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return 0;
            int inversion = 0;
            int mid = startIndex + (endIndex - startIndex) / 2;

            inversion += MergeSort(input, tracker, startIndex, mid);
            inversion += MergeSort(input, tracker, mid + 1, endIndex);

            inversion += merge(input, tracker, startIndex, mid, endIndex);
            return inversion;
        }


        public int merge(int[] input, int[] tracker, int startIndex, int mid, int endIndex)
        {
            int inversions = 0;
            int left = startIndex;
            int right = mid + 1;
            int counter = left;

            while (left <= mid && right <= endIndex)
            {
                if (input[left] <= input[right])
                {
                    tracker[counter++] = input[left++];
                }
                else
                {
                    inversions += mid - left + 1;
                    tracker[counter++] = input[right++];
                }
            }

            if (left <= mid)
            {
                while (left <= mid)
                {
                    tracker[counter++] = input[left++];
                }
            }
            if (right <= endIndex)
            {
                while (right <= endIndex)
                {
                    tracker[counter++] = input[right++];
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                input[i] = tracker[i];
            }
            return inversions;

        }

        /// <summary>
        /// Match bots and nuts. 
        /// </summary>
        /// <param name="bots"></param>
        /// <param name="nuts"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        public void _026_MatchBotNut(int[] bots, int[] nuts, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            int left = startIndex;
            int right = endIndex;

            while (left <= right)
            {
                while (left <= endIndex && bots[left] < nuts[startIndex]) left++;
                while (right >= startIndex && bots[right] > nuts[startIndex]) right--;

                if (left <= right)
                {
                    if (bots[left] == nuts[startIndex])
                    {
                        swap(bots, left, startIndex);
                        left++;
                    }
                    else if (bots[right] == nuts[startIndex])
                    {
                        swap(bots, right, startIndex);
                        right--;
                    }
                    else
                    {
                        swap(bots, left, right);
                        left++;
                        right--;
                    }
                }
            }

            left = startIndex + 1;
            right = endIndex;
            while (left <= right)
            {
                while (left <= endIndex && nuts[left] < bots[startIndex]) left++;
                while (right > startIndex && nuts[right] > bots[startIndex]) right--;

                if (left <= right)
                {
                    swap(nuts, left, right);
                    left++;
                    right--;
                }
            }

            _026_MatchBotNut(bots, nuts, startIndex + 1, left - 1);
            _026_MatchBotNut(bots, nuts, left, endIndex);
        }

        public void swap(int[] input, int left, int right)
        {
            int tmp = input[left];
            input[left] = input[right];
            input[right] = tmp;
        }


        /// <summary>
        /// knapsack problem
        /// </summary>
        /// <param name="value"></param>
        /// <param name="weight"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
        public int _023_Knapsack(int[] value, int[] weight, int capacity)
        {
            //check value, weight and capacity, assume they all right 
            // and weight value all > 0. 
            int[,] tracker = new int[capacity + 1, value.Length];

            for (int i = weight[0]; i <= capacity; i++)
            {
                tracker[i, 0] = value[0];
            }

            for (int i = 0; i <= capacity; i++)
            {
                for (int j = 1; j < value.Length; j++)
                {
                    int tmpValue = -1;
                    for (int k = i - weight[j]; k >= 0; k--)
                    {
                        tmpValue = tmpValue > tracker[k, j - 1] ? tmpValue : tracker[k, j - 1];
                    }
                    if (tmpValue != -1)
                    {
                        tmpValue += value[j];
                    }
                    tracker[i, j] = tmpValue > tracker[i, j - 1] ? tmpValue : tracker[i, j - 1];
                }
            }
            return tracker[capacity, weight.Length - 1];
        }

        /// <summary>
        /// if number of votes of each states are fix, can president election be even?
        /// [9,3,11,6,55,9,7,3,29,16,4,4,20,11,6,6,8,8,4,10,11,16,10,6,10,3,5,6,4,14,5,29,15,3,18,7,7,20,4,9,3,11,38,6,3,13,12,5,10,3,3]
        /// </summary>
        /// <param name="input"></param>
        public bool _027_CanVoteBeEven(int[] input)
        {
            //check if input is just one or empty or null ....
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }

            if (sum % 2 != 0) return false;
            int half = sum / 2;
            int[,] tracker = new int[half + 1, input.Length];


            for (int i = input[0]; i <= half; i++)
            {
                tracker[i, 0] = input[0];
            }

            for (int i = 1; i <= half; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    int max = 0;
                    for (int k = i - input[j]; k > 0; k--)
                    {
                        max = max > tracker[k, j - 1] ? max : tracker[k, j - 1];
                    }
                    if (max > 0)
                    {
                        tracker[i, j] = max + input[j] > tracker[i, j - 1] ? max + input[j] : tracker[i, j - 1];
                    }
                    else
                    {
                        tracker[i, j] = tracker[i, j - 1];
                    }
                }
            }

            return tracker[half, input.Length - 1] == half;
        }
    }
}
