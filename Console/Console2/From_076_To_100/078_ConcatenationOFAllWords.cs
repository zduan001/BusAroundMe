using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _078_ConcatenationOFAllWords
    {
        /*
        You are given a string, S, and a list of words, L, that are all of the same length. Find all starting indices of substring(s) 
        in S that is a concatenation of each word in L exactly once and without any intervening characters.
        For example, given:
         S: "barfoothefoobarman"
         L: ["foo", "bar"] 
        You should return the indices: [0,9].
         (order does not matter). 
         */
        public List<int> ConcatenationOfAllWords(string s, List<string> words)
        {
            int wordCount = words.Count;
            int wordLength = words[0].Length;
            List<int> res = new List<int>();
            HashSet<string> tracker = new HashSet<string>();
            int countOfFound = 0;
            if (s.Length < wordCount * wordLength)
            {
                return null;
            }

            for (int i = 0; i < s.Length - wordCount * wordLength; i++)
            {
                tracker.Clear();
                countOfFound = 0;
                for (int j = i; j < s.Length - wordLength; j = j + wordLength)
                {
                    string tmpWord = s.Substring(j, wordLength);
                    if (words.Contains(tmpWord) && !tracker.Contains(tmpWord))
                    {
                        tracker.Add(tmpWord);
                        countOfFound++;
                    }
                    if (countOfFound == wordCount)
                    {
                        res.Add(i);
                        break;
                    }
                }
            }
            return res;
        }

    }
}
