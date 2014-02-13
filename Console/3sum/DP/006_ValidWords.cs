using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace console.DP
{
    public class _006_ValidWords
    {
        /// <summary>
        /// Given a dictionary, and a string, verify if the string is composed by
        /// valid word from dictionary. string is not tokenized and no white space.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool ValidateWords(HashSet<string> dictionary, string s)
        {
            bool[] res = new bool[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (dictionary.Contains(s.Substring(j, i - j + 1)))
                    {
                        if (j == 0)
                        {
                            res[i] = true;
                        }
                        else if (j - 1 > 0 && res[j-1])
                        {
                            res[i] = res[j - 1];
                            break;
                        }
                    }
                }
            }
            return res[s.Length-1];
        }
    }
}
