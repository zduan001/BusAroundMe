using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class _031_SubSetsII
    {
        /*
         * http://leetcode.com/onlinejudge#question_90
         */
        public List<string> AllSubSet(string s)
        {
            List<string> res = new List<string>();
            FindSubSet(s, res, string.Empty);
            return res;
        }

        private void FindSubSet(string s, List<string> res, string progress)
        {
            if (string.IsNullOrEmpty(s))
            {
                res.Add(progress);
                return;
            }
            else
            {
                int dupCount = 1;
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == s[0])
                    {
                        dupCount++;
                    }
                }

                FindSubSet(s.Substring(dupCount), res, progress + s[0]);
                FindSubSet(s.Substring(dupCount), res, progress);

                if (dupCount > 1)
                {
                    FindSubSet(s.Substring(dupCount), res, progress + s.Substring(0, dupCount));
                }
            }
        }
    }
}
