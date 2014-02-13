using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_001_To_025
{
    public class _005_Anagrams_Round2
    {
        /// <summary>
        /// 
        /// Given an array of strings, return all groups of strings that are anagrams.
        /// Note: All inputs will be in lower-case.
        /// e.g. "tea","and","ate","eat","dan".   return "and","dan","tea","ate","eat"
        /// anangrams意思是重新排列字母顺序构成一个新词。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> AnagramsStrings(List<string> input)
        {
            Dictionary<string, List<string>> tmp = new Dictionary<string, List<string>>();
            List<string> res = new List<string>();

            foreach (string s in input)
            {
                char[] sArray = s.ToCharArray();
                Array.Sort(sArray);
                string str = new String(sArray);
                if (tmp.ContainsKey(str))
                {
                    tmp[s].Add(s);
                }
                else
                {
                    tmp.Add(str, new List<string>() { s });
                }
            }

            foreach (string s in tmp.Keys)
            {
                res.AddRange(tmp[s]);
            }

            return null;
        }
    }
}
