using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _006_Anagram
    {
        /// <summary>
        /// Given an array of strings, return all groups of strings that are anagrams.
        /// Note: All inputs will be in lower-case.
        /// e.g. "tea","and","ate","eat","dan".   return "and","dan","tea","ate","eat"
        /// </summary>
        /// <param name="input">the string array.</param>
        public List<List<string>> FindAnagrams(string[] input)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (string s in input)
            {
                char[] c = s.ToCharArray();
                Array.Sort(c);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < c.Length; i++)
                {
                    sb.Append(c[i]);
                }
                string key = sb.ToString();

                if (result.ContainsKey(key))
                {
                    result[key].Add(s);
                }
                else
                {
                    result.Add(key, new List<string>() { s });
                }
            }

            List<List<string>> res = new List<List<string>>();
            foreach (List<string> l in result.Values)
            {
                res.Add(l);
            }
            return res;
        }

        /// <summary>
        /// this methos is very similar to the last method. the different is this still return 
        /// a string array. and in the reuslt string all anagrams stay together.
        /// the solution is change compare method of the sort. sort the string 
        /// before compare.
        /// </summary>
        /// <param name="input">input string array</param>
        /// <returns>anagrams sorted array</returns>
        public string[] findanagrams(string[] input)
        {
            return new string[1];
        }
    }
}
