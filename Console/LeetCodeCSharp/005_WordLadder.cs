using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _005_WordLadder
    {
        /**/
        public int FindWordLadderLength(string[] dict, string start, string end)
        {
            Queue<string> q = new Queue<string>();
            HashSet<string> hash = new HashSet<string>();
            int step = 1;

            q.Enqueue(start);
            hash.Add(start);
            q.Enqueue(null);

            while (q.Count != 0)
            {
                string tmp = q.Dequeue();
                if(string.IsNullOrEmpty(tmp))
                {
                    step++;
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);
                    }
                    else
                    {
                        break;
                    }
                    continue;
                }

                List<string> neighbors = ChangeOneLetter(tmp);
                foreach(string s in neighbors)
                {
                    if (s == end)
                    {
                        return step+1;
                    }
                    if (!hash.Contains(s) && dict.Contains(s))
                    {
                        q.Enqueue(s);
                        hash.Add(s);
                    }
                }
            }

            return -1;
        }


        private List<string> ChangeOneLetter(string input)
        {
            char[] strCharArray = input.ToCharArray();
            List<string> res = new List<string>();
            for (int i = 0; i < strCharArray.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    strCharArray[i] = (char)((int)'a' + j);
                    string s = new string(strCharArray);
                    if (s != input)
                    {
                        res.Add(s);
                    }
                }
                strCharArray[i] = input[i];
            }
            return res;
        }
        #region word ladder II

        /*
         * used DFS method to find all pathes and find shortest path.
         * not quite sure if this is the best solution. but it works
         * http://leetcode.com/onlinejudge#question_127
         */
        public List<List<string>> FindWordLadderII(string[] dict, string start, string end)
        {
            Stack<string> tracker = new Stack<string>();
            List<List<string>> res = new List<List<string>>();
            tracker.Push(start);
            Find(dict, tracker, end, res);

            int min = int.MaxValue;
            foreach (List<string> l in res)
            {
                min = min < l.Count ? min : l.Count;
            }

            List<List<string>> final = new List<List<string>>();
            foreach (List<string> l in res)
            {
                if (l.Count == min)
                {
                    final.Add(l);
                }
            }

            return final;

        }

        public void Find(string[] dict, Stack<string> tracker, string end, List<List<string>> res)
        {
            string top = tracker.Peek();
            List<string> tmp = ChangeOneLetter(top);
            foreach (string s in tmp)
            {
                if (end == s)
                {
                    CopyToRes(res, tracker, end);
                }

                if (dict.Contains(s) && !tracker.Contains(s))
                {
                    tracker.Push(s);
                    Find(dict, tracker, end, res);
                    tracker.Pop();
                }
            }

        }

        public void CopyToRes(List<List<string>> res, Stack<string> tracker, string end)
        {
            Stack<string> tmp = new Stack<string>();
            List<string> OneList = new List<string>();

            while (tracker.Count != 0)
            {
                OneList.Insert(0, tracker.Peek());
                tmp.Push(tracker.Pop());
            }
            OneList.Add(end);
            while (tmp.Count != 0)
            {
                tracker.Push(tmp.Pop());
            }
            res.Add(OneList);
        }
        #endregion
    }
}
