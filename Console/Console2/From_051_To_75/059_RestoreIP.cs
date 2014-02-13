using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_051_To_75
{
    public class _059_RestoreIP
    {
        /*
         Given a string containing only digits, restore it by returning all possible valid IP address combinations.

         For example:
         Given "25525511135", 

        return ["255.255.11.135", "255.255.111.35"]. (Order does not matter) 

         */
        public List<string> RestoreIp(string s)
        {

            return Worker(s, 2);
        }

        private List<string> Worker(string s, int remain)
        {
            if (s.Length == 0) return new List<string>() { string.Empty };
            if (remain == 0)
            {
                if (int.Parse(s) >= 0 && int.Parse(s) <= 255)
                {
                    return new List<string>() { s };
                }
                else
                {
                    return new List<string>() { string.Empty };
                }
            }

            List<string> res = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                List<string> Left = Worker(s.Substring(0, i + 1), remain - 1);
                List<string> right = Worker(s.Substring(i + 1), remain - 1);
                foreach (string l in Left)
                {
                    foreach (string r in right)
                    {
                        if (!string.IsNullOrEmpty(l) && !string.IsNullOrEmpty(r))
                        {
                            res.Add(l + "," + r);
                        }
                    }
                }
            }
            return res;
        }
    }
}
