using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Console2.G_Code
{
    public class G_063_FromDictionayToOrder
    {
        /*
         * 给你一本其他国家语言的字典。其中的单词是按照这个国家的语言的字母顺序排序的。输出这个国家的语言的字母顺序。
         */
        // Assum I know how many char in the language. 
        // 1. scane through 2 adjacent word in dictionay
        // 2. find the first letter different. 
        // 3. try to insert the letter in to a Linkedlist.
        // 4. once all the char get into the list, return it
        public List<char> FindCharOrder(List<string> dict)
        {
            List<char> res = new List<char>();
            HashSet<Edge> edges = new HashSet<Edge>();
            char large;
            char small;
            for (int i = 0; i < dict.Count-1; i++)
            {
                int length = dict[i].Length < dict[i + 1].Length ? dict[i].Length : dict[i + 1].Length;
                for (int j = 0; j < length; j++)
                {
                    if (dict[i][j] != dict[i + 1][j])
                    {
                        large = dict[i + 1][j];
                        small = dict[i][j];
                        edges.Add(new Edge() { Start = small, End = large });
                    }
                }

                // after I have the graphy 
                // 1. find the char will has only been small. add it to res.
                // 2. find remove edges wher start is the last one added to res.
                // 3. go to step 1 unless edges is empty.
            }

            return res;
        }

        public class Edge
        {
            public char Start;
            public char End;
        }

    }
}
