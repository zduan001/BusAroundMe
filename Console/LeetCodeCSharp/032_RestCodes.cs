using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra;

namespace LeetCodeCSharp
{
    public class _032_RestCodes
    {
        /*
         * http://leetcode.com/onlinejudge#question_89
         */
        public List<string> _033_GrayCode(int n)
        {
            if (n == 1)
            {
                return new List<string>() { "0", "1" };
            }
            else
            {
                List<string> tmp = _033_GrayCode(n - 1);
                List<string> tmp2 = new List<string>();
                for (int i = tmp.Count - 1; i >= 0; i--)
                {
                    tmp2.Add(tmp[i]);
                }

                for (int i = 0; i < tmp.Count; i++)
                {
                    tmp[i] = "0" + tmp[i];
                    tmp2[i] = "1" + tmp2[i];
                }

                tmp.AddRange(tmp2);
                return tmp;
            }
        }

        /*
         * http://leetcode.com/onlinejudge#question_88
         */
        public void _034_MergeSortedArray(int[] a, int n, int[] b, int m)
        {
            int index = n + m - 1;
            int aIndex = n - 1;
            int bIndex = m - 1;
            while (aIndex >= 0 && bIndex >= 0)
            {
                if (a[aIndex] > b[bIndex])
                {
                    a[index--] = a[aIndex--];
                }
                else
                {
                    a[index--] = b[bIndex--];
                }
            }

            if (aIndex < 0)
            {
                for (int i = bIndex; i >= 0; i++)
                {
                    a[i] = b[i];
                }
            }
        }

        /*
         * http://leetcode.com/onlinejudge#question_87
         */
        public bool _035_scrambleStrings(string s1, string s2)
        {
            if (s1 == s2) return true;
            if (s1.Length != s2.Length) return false;
            if (s1.Length == 0 && s2.Length == 0) return true;
            if (s1.Length == 1 && s2.Length == 1 && s1[0] == s2[0]) return true;

            for (int i = 1; i < s1.Length; i++)
            {
                if ((_035_scrambleStrings(s1.Substring(0, i), s2.Substring(s1.Length - i)) &&
                    _035_scrambleStrings(s1.Substring(s1.Length - i), s2.Substring(0, i))) ||
                    (_035_scrambleStrings(s1.Substring(0, i), s2.Substring(0, i)) &&
                    _035_scrambleStrings(s1.Substring(i + 1), s2.Substring(i + 1)))
                    )
                {
                    return true;
                }
            }
            return false;
        }

        public bool _035_scrambleStringsII(string s1, string s2)
        {
            // check null, size ...
            int n = s1.Length;

            bool[, ,] tracker = new bool[n, n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tracker[i, j, 0] = s1[i] == s1[j];
                }
            }

            for (int l = 1; l < n; l++)
            {
                for (int i = 0; i + l < n; i++)
                {
                    for (int j = 0; j + l < n; j++)
                    {
                        tracker[i, j, l] = false;
                        for (int k = 0; k < l; k++)
                        {
                            if (tracker[i, j, k] && tracker[i + k + 1, j + k + 1, l - 1 - k]
                                || tracker[i, j + l - k, k] && tracker[i + k + 1, j, l - 1 - k])
                            {
                                tracker[i, j, l] = true;
                                break;
                            }
                        }
                    }
                }
            }

            return tracker[0, 0, n - 1];

        }

        /*
         * http://leetcode.com/onlinejudge#question_86
         */
        public List<LinkListNode> _036_PartitionList(LinkListNode input, int n)
        {
            LinkListNode dummyH1 = new LinkListNode();
            LinkListNode dummyH2 = new LinkListNode();

            LinkListNode tmp = input;
            LinkListNode tmp1 = dummyH1;
            LinkListNode tmp2 = dummyH2;
            while (tmp != null)
            {
                if (tmp.Value < n)
                {
                    tmp1.Next = tmp;
                    tmp1 = tmp1.Next;
                }
                else
                {
                    tmp2.Next = tmp;
                    tmp2 = tmp2.Next;
                }
            }

            List<LinkListNode> res = new List<LinkListNode>();
            res.Add(dummyH1.Next);
            res.Add(dummyH2.Next);

            return res;
        }

        /*
         * http://leetcode.com/onlinejudge#question_85
         */
        public int _037_MaxRectangle(List<string> input, int n)
        {
            int[,] tracker = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (input[i][j] == '1')
                    {
                        tracker[i, j] = count;
                        count++;
                    }
                    else if (count > 0)
                    {
                        tracker[i, j] = count;
                        count = 0;
                    }
                }
            }

            int max = 0;
            int tmp = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (tracker[i, j] > 0)
                    {
                        int height = 0;
                        int width = tracker[i, j];

                        for (int k = i; k >= 0; k--)
                        {
                            height++;
                            width = width < tracker[k, j] ? width : tracker[k, j];
                            tmp = height * width;
                            max = max > tmp ? max : tmp;
                        }
                    }
                }
            }

            return max;
        }

        /*
         * http://leetcode.com/onlinejudge#question_84
         * n^2 us easiest.
         */
        public int _038_MaxRetangleInHistogram(int[] input, int startInex, int endIndex)
        {
            if (startInex == endIndex) return input[startInex];
            if (startInex > endIndex) return 0;

            int mid = startInex + (endIndex - startInex) / 2;

            int leftValue = _038_MaxRetangleInHistogram(input, startInex, mid);
            int rigtValue = _038_MaxRetangleInHistogram(input, mid + 1, endIndex);

            int crossValue = 0;
            if (mid + 1 < input.Length)
            {
                int height = Math.Min(input[mid], input[mid + 1]);
                int leftIndex = mid;
                int rightIndex = mid + 1;
                while (leftIndex > startInex && input[leftIndex - 1] >= height) leftIndex--;
                while (rightIndex < endIndex && input[rightIndex + 1] >= height) rightIndex++;
                crossValue = (rightIndex - leftIndex + 1) * height;
            }

            return Math.Max(Math.Max(leftValue, rigtValue), crossValue);
        }

        /*
         * http://leetcode.com/onlinejudge#question_83
         */
        public LinkListNode _039_RemoveDup(LinkListNode header)
        {
            LinkListNode previousNode = null;
            LinkListNode tmp = header;
            while (tmp != null)
            {
                if (previousNode == null || tmp.Value != previousNode.Value)
                {
                    previousNode = tmp;
                    tmp = tmp.Next;
                }
                else
                {
                    tmp = tmp.Next;
                    previousNode.Next = tmp;
                }
            }
            return header;
        }

        /*
         * http://leetcode.com/onlinejudge#question_83
         */
        public LinkListNode _040_RemoveDupII(LinkListNode header)
        {
            LinkListNode dummyHeader = new LinkListNode();
            dummyHeader.Next = header;
            LinkListNode tmp = dummyHeader;
            while (tmp != null)
            {
                if (tmp.Next == null || tmp.Next.Next == null) break;

                if (tmp.Next.Value == tmp.Next.Next.Value)
                {
                    LinkListNode runer = tmp.Next.Next.Next;
                    while (runer != null && runer.Value == tmp.Next.Value)
                    {
                        runer = runer.Next;
                    }
                    tmp.Next = runer;
                }
                else
                {
                    tmp = tmp.Next;
                }
            }
            return dummyHeader.Next;
        }

        /*
         * http://leetcode.com/onlinejudge#question_81
         */
        public int _041_SearchInRotatedSortedArray(int[] input, int k, int left, int right)
        {
            if (left > right) return -1;

            int mid = left + (right - left) / 2;
            if (input[mid] == k) return mid;

            if (input[mid] < input[right])
            {
                if (k > input[mid] && k <= input[right])
                {
                    return _041_SearchInRotatedSortedArray(input, k, mid + 1, right);
                }
                else
                {
                    return _041_SearchInRotatedSortedArray(input, k, left, mid - 1);
                }
            }
            else
            {
                if (k >= input[left] && k < input[mid])
                {
                    return _041_SearchInRotatedSortedArray(input, k, left, mid - 1);
                }
                else
                {
                    return _041_SearchInRotatedSortedArray(input, k, mid + 1, right);
                }
            }
        }

        /*
         * http://leetcode.com/onlinejudge#question_75
         */
        public void _042_SortColor(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left <= right)
            {
                while (left < right && input[left] <= 1) left++;
                while (right > left && input[right] > 1) right--;
                if (left <= right)
                {
                    Swap(input, left, right);
                    left++;
                    right--;
                }
            }

            if (right > 0)
            {
                left = 0;
                while (left <= right)
                {
                    while (left < right && input[left] == 0) left++;
                    while (right > left && input[right] == 1) right--;
                    if (left <= right)
                    {
                        Swap(input, left, right);
                        left++;
                        right--;
                    }
                }
            }
        }

        public void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }

        /// <summary>
        /// newton method. http://leetcode.com/onlinejudge#question_69
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public double _043_FindSqaureRoot(int c)
        {
            if (c < 0) return Double.NaN;
            double EPS = 1E-15;
            double t = c;
            while (Math.Abs(t - c / t) > EPS * t)
                t = (c / t + t) / 2.0;
            return t;

        }

        /// <summary>
        /// http://leetcode.com/onlinejudge#question_72
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public int _044_EditDistance(string s1, string s2)
        {
            if (s1 == string.Empty) return s2.Length;
            if (s2 == string.Empty) return s1.Length;

            int c = int.MaxValue;
            if (s1[0] == s2[0])
            {
                c = _044_EditDistance(s1.Substring(1), s2.Substring(1));
            }
            else
            {
                c = _044_EditDistance(s1.Substring(1), s2.Substring(1)) + 1;
            }

            int a = _044_EditDistance(s1.Substring(1), s2);
            int b = _044_EditDistance(s1, s2.Substring(1));
            return Math.Min(c,Math.Min(a, b) + 1);
        }

        public int _044_EditDistanceII(string s1, string s2)
        {
            int[,] tracker = new int[s1.Length, s2.Length];
            for (int j = 0; j < s2.Length; j++)
            {
                tracker[0, j] = j;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                tracker[i, 0] = i;
            }

            for (int i = 1; i < s1.Length; i++)
            {
                for (int j = 1; j < s2.Length; j++)
                {
                    int c = int.MaxValue;
                    if (s1[i] == s2[j])
                    {
                        c = tracker[i - 1, j - 1];
                    }
                    else
                    {
                        c = tracker[i - 1, j - 1] + 1;
                    }

                    tracker[i, j] = Math.Min(c, Math.Min(tracker[i - 1, j], tracker[i, j - 1])+1);
                }
            }
            return tracker[s1.Length - 1, s2.Length-1];
        }

        /// <summary>
        /// http://leetcode.com/onlinejudge#question_71
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string _045_SimplifyPath(string s)
        {
            Stack<string> stack = new Stack<string>();
            while (s.Length != 0)
            {
                // make sure the s is a valiade sting.
                int i = 0;
                while (s[i] != '/')
                {
                    i++;
                }

                if (i == 0)
                {
                    s = s.Substring(1);
                }
                else
                {
                    string tmp = s.Substring(0, i);
                    if (tmp == "..")
                    {
                        if (stack.Count != 0)
                        {
                            stack.Pop();
                        }
                    }
                    else if (tmp != ".")
                    {
                        stack.Push(tmp);
                    }
                }

                s = s.Substring(i);
            }

            string sb = string.Empty;
            while (stack.Count != 0)
            {
                sb = stack.Pop() + "/" + sb;
            }

            return "/"+ sb.ToString();
        }

        /// <summary>
        /// http://leetcode.com/onlinejudge#question_56
        /// </summary>
        /// <param name="input"></param>
        public List<Tuple<int,int>> _046_MergeIntervals(List<Tuple<int, int>> input)
        {
            if (input == null || input.Count == 0) return null;
            List<Tuple<int, int>> res = new List<Tuple<int, int>>();
            // assume input is already sorted by the start point.
            Tuple<int, int> current = input[0];
            res.Add(current);
            for (int i = 1; i < input.Count; i++)
            {
                if (current == null)
                {
                    res.Add(current);
                }
                else if (current.Item2 < input[i].Item1)
                {
                    res.Add(input[i]);
                    current = input[i];
                }
                else if (current.Item2 > input[i].Item2)
                {
                    continue;
                }
                else
                {
                    Tuple<int, int> tmp = new Tuple<int, int>(current.Item1, input[i].Item2);
                    current = tmp;
                }
            }

            return res;
        }


        /// <summary>
        /// http://www.mitbbs.com/article_t/JobHunting/32184907.html
        /// Given an array of integers where each element points to the index of the next element how would you detect if there is a cycle in this array?
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool _047_IsThereALoop(int[] input)
        {
            int[] tracker = new int[input.Length];
            int count = 1;
            for (int i = 0; i < input.Length; i++)
            {
                if (tracker[i] == 0)
                {
                    if (FindLoop(i, input, tracker, count))
                    {
                        return true;
                    }
                    count++;
                }
            }
            return false;
        }

        private bool FindLoop(int i, int[] input, int[] tracker, int count)
        {
            if (tracker[i] == count)
            {
                return true;
            }

            if (input[i] < 0 || input[i] >= input.Length)
            {
                tracker[i] = count;
                return false;
            }

            if (tracker[i] != 0)
            {
                return false;
            }
            tracker[i] = count;
            return FindLoop(input[i], input, tracker, count);
        }
    }
}
