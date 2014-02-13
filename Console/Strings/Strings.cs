using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Strings
    {
        /*https://www.hackerrank.com/challenges/string-similarity
         * String Similarity
         * For two strings A and B, we define the similarity of the strings to be the length of the longest prefix common to both strings. For example, the similarity of strings “abc” and “abd” is 2, while the similarity of strings “aaa” and “aaab” is 3.

            Calculate the sum of similarities of a string S with each of it’s suffixes.

            Input:
            The first line contains the number of test cases T. Each of the next T lines contains a string each.

            Output:
            Output T lines containing the answer for the corresponding test case.

            Constraints:
            1 <= T <= 10
            The length of each string is at most 100000 and contains only lower case characters.

            Sample Input:
            2
            ababaa
            aa

            Sample Output:
            11
            3

            Explanation:
            For the first case, the suffixes of the string are “ababaa”, “babaa”, “abaa”, “baa”, “aa” and “a”. The similarities of each of these strings with the string “ababaa” are 6,0,3,0,1,1 respectively. Thus the answer is 6 + 0 + 3 + 0 + 1 + 1 = 11.

            For the second case, the answer is 2 + 1 = 3.
         */
        public void StringSimilarity(string[] input)
        {
            foreach (string s in input)
            {
                Console.WriteLine(CalcuateSimilarity(s).ToString());
            }

        }

        private int CalcuateSimilarity(string input)
        {
            int res = input.Length;

            for (int i = 1; i < input.Length; i++)
            {
                for (int j = 0; i + j < input.Length; j++)
                {
                    if (input[j] == input[i + j])
                    {
                        res++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return res;
        }
    }
}
