using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _005_OrderofAlphabetical
    {
        /*
         * 给你一本其他国家语言的字典。其中的单词是按照这个国家的语言的字母顺序排序的。输出这个国家的语言的字母顺序。
         * http://www.mitbbs.com/article_t1/JobHunting/32262719_0_1.html
         * finally I think I got it
         * scan throgh the dictionary compare adjacent words, find the first charactor different.
         * use the character in the first word as key, add second charactor to the list. 
         * do the hashtable's key is the char, and value is the list of chars "larger" than it.
         * after scan all word, count the list of each charactor, the word has longest list is the first and 
         * so on and so forth.
         */
        public List<KeyValuePair<char, int>> FindOrder(List<string> dictionary)
        {
            Dictionary<char, List<char>> tracker = new Dictionary<char, List<char>>();
            for (int i = 0; i < dictionary.Count - 1; i++)
            {
                int m = Math.Min(dictionary[i].Length, dictionary[i + 1].Length);
                for (int j = 0; j < m; j++)
                {
                    if (dictionary[i][j] != dictionary[i + 1][j])
                    {
                        if (tracker.Keys.Contains(dictionary[i][j]))
                        {
                            if (!tracker[dictionary[i][j]].Contains(dictionary[i + 1][j]))
                            {
                                tracker[dictionary[i][j]].Add(dictionary[i + 1][j]);
                            }
                        }
                        else
                        {
                            tracker.Add(dictionary[i][j], new List<char>() { dictionary[i + 1][j] });
                        }
                        break;
                    }
                }

            }

            List<KeyValuePair<char, int>> res = new List<KeyValuePair<char, int>>();
            foreach (char c in tracker.Keys)
            {
                res.Add(new KeyValuePair<char, int>(c, tracker[c].Count));
            }

            // sort by int of the key value pair.

            return res;

        }
    }
}
