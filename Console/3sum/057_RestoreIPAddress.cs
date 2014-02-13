using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console
{
    public class _057_RestoreIPAddress
    {
        /// <summary>
        /// Given a string containing only digits, restore it by returning all possible valid IP address combinations.
        /// For example:
        /// Given "25525511135",
        /// 
        /// return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public List<string> RestoreIPAddress(string input)
        {
            return SeperateStrings(input, 2);
        }

        public List<string> SeperateStrings(string input,int remain)
        {
            // stop reached end.
            // and do something
            if(input.Length ==0)
            {
                return new List<string>() { string.Empty };
            }

            if (remain == 0)
            {
                int value = int.Parse(input);
                if (value <= 255 && value >= 0)
                {
                    return new List<string>() { input.ToString() };
                }
                else
                {
                    return new List<string>() { string.Empty };
                }
            }

            List<string> res = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                foreach (string s in SeperateStrings(input.Substring(0, i+1), remain - 1))
                {
                    foreach (string t in SeperateStrings(input.Substring(i + 1), remain - 1))
                    {
                        if (!string.IsNullOrWhiteSpace(s) && !string.IsNullOrWhiteSpace(t))
                        {
                            res.Add(s + "." + t);
                        }
                    }
                }
            }
            return res;
        }
    }
}
