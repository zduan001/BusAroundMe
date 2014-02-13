using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayString
{
    public class CheckInterLeave
    {
        public bool IsInterLeave(string s1,string s2, string s3, string tmp)
        {

            if(tmp!= string.Empty && !s3.StartsWith(tmp))
            {
                return false;
            }
	        // initial check l1 + l2 == l3 ....
	        // no nulls
            if (s1 == string.Empty && s2 == string.Empty)
            {
                if (s3 == tmp)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if (IsInterLeave(s1.Substring(i), s2.Substring(j), s3, tmp + s1.Substring(0, i) + s2.Substring(0, j)) ||
                        IsInterLeave(s1.Substring(i), s2.Substring(j), s3, tmp + s2.Substring(0, j) + s1.Substring(0, i)))
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool IsInterLeave(string s1, string s2, string s3)
        {
            if (s1 == null || s2 == null || s3 == null) return false;
            if (s3.Length != s1.Length + s2.Length) return false;

            bool[,]  tracker = new bool[s1.Length+1,s2.Length+1];
            tracker[0, 0] = true;

            for (int i = 1; i < s1.Length; i++)
            {
                tracker[0, i] = tracker[0, i - 1] && s1[i-1] == s3[i-1];
            }

            for (int j = 1; j < s2.Length; j++)
            {
                tracker[j, 0] = tracker[j - 1, 0] && s2[j-1] == s3[j-1];
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    if ((s3[j + i-1] == s1[i-1] && tracker[j, i - 1]) ||
                        (s3[j + i-1] == s2[j-1] && tracker[j - 1, i]))
                    {
                        tracker[j, i] = true;
                    }
                }
            }

            return tracker[s1.Length , s2.Length ];
        }
    }
}
