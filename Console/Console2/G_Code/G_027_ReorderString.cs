using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.G_Code
{
    public class G_027_ReorderString
    {
        /*
            Given an input string and an order string, e.g., “house” and “soup”, print out
            characters in input string according to character order in order string. For characters in
            input string but not in order string, output them in the end, their relative order doesn’t
            matter.
            So for “house”, “souhe” and “soueh” are valid outputs.
         * http://www.mitbbs.com/article_t/JobHunting/32079701.html
         */
        public string ReOrderString(string s, string p)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (char c = 'a'; c <= 'z'; c++)
            {
                map.Add(c, int.MaxValue);
            }

            for (int i = 0;i< p.Length;i++)
            {
                if (map[p.ToLower()[i]] > i)
                {
                    map[p.ToLower()[i]] = i;
                }
            }

            // Use any sort algorighm to sort string s with comparer use map

            return string.Empty;
        }
    }
}
