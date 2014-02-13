using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _030_PrintAllStrings
    {
        List<string> res = new List<string>();
        /// <summary>
        /// Print all sub string of a string.
        /// </summary>
        /// <param name="s"></param>
        public List<string> PrintAllSubStrings(string s)
        {
            res.Clear();
            bool[] ifPrint = new bool[s.Length];
            for (int i = 0; i <= s.Length; i++)
            {
                PrintAllSubString(s, ifPrint, 0, i);
            }
            return res;
        }

        /// <summary>
        /// Working method of recursive method.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="ifPrint"></param>
        /// <param name="start"></param>
        /// <param name="remains"></param>
        public void PrintAllSubString(string s, bool[] ifPrint, int start, int remains)
        {
            if (remains == 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("{");
                for (int i = 0; i < ifPrint.Length; i++)
                {
                    if (ifPrint[i])
                        sb.Append(s[i] + ",");
                }
                sb.Append("}");
                res.Add(sb.ToString());
            }
            else
            {
                if (start + remains > s.Length)
                    ;
                else
                {
                    for (int i = start; i < s.Length; i++)
                    {
                        if (!ifPrint[i])
                        {
                            ifPrint[i] = true;
                            PrintAllSubString(s, ifPrint, i + 1, remains - 1);
                            ifPrint[i] = false;
                        }
                    }
                }
            }
        }
    }
}
