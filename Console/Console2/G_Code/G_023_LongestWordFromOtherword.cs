using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_023_LongestWordFromOtherword
    {
        /*
         * Suppose you are given a dictionary of words based on an alphabet with a fixed
            number of characters. Please write a method/function which will find the longest word in
            the dictionary such that it can be built from successively adding a single character to an
            existing word in the dictionary (in any location). For instance, “a” -> “at” -> “cat” -> “chat”
            -> “chart”.
         * http://www.mitbbs.com/article_t/JobHunting/32061173.html
         * there is nothing fancy about this method
         * 1. group all the words by their length.
         * 2. from length = 2 group. try to remove one charactor from every word and check  to see if the new word
         *    exists in the lenght -1 group. if so keep the words. 
         * 3. keep going to untill reach a group where there is nothing left.
         *    
         */
        public List<string> LongestWordFromOtherWord(string[] input)
        {
            Dictionary<int, List<string>> abc = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> res = new Dictionary<int, List<string>>();
            int maxLength = int.MinValue;
            foreach (string s in input)
            {
                if (abc.Keys.Contains(s.ToLower().Trim().Length))
                {
                    abc[s.Length].Add(s);
                }
                else
                {
                    abc.Add(s.Length, new List<string>() { s });
                }
                maxLength = maxLength > s.Length ? maxLength : s.Length;
            }
            int maxResLength = int.MinValue;
            res.Add(1, abc[1]);

            for (int i = 2; i <= maxLength; i++)
            {
                foreach (string s in abc[i])
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        string tmp = s.Remove(j, 1).ToLower();
                        if (res[i - 1].Contains(tmp))
                        {
                            if (res.Keys.Contains(s.Length))
                            {
                                res[s.Length].Add(s);
                            }
                            else
                            {
                                res.Add(s.Length, new List<string>() { s });
                            }
                            maxResLength = maxResLength > s.Length ? maxResLength : s.Length;
                        }
                        
                    }
                }
                if (!res.Keys.Contains(i))
                {
                    break;
                }
            }
            return res[maxResLength];
        }
    }
}
