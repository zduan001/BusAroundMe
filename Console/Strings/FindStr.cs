using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class FindStr
    {
        /*https://www.hackerrank.com/challenges/find-strings
         * You are given ‘n’ strings w1, w2, ……, wn. Let Si denote the set of strings formed by considering all unique substrings of the string wi. A substring is defined as a contiguous sequence of one or more characters in the string. More information on substrings can be found here. Let ‘S’ = {S1 U S2 U …. Sn} .i.e ‘S’ is a set of strings formed by considering all the unique strings in all sets S1, S2, ….. Sn. You will be given many queries and for each query, you will be given an integer ‘k’. Your task is to output the lexicographically kth smallest string from the set ‘S’.

            Input:

            The first line of input contains a single integer ‘n’, denoting the number of strings. Each of the next ‘n’ lines consists of a string. The string on the ith line (1<=i<=n) is denoted by wi and has a length mi. The next line consists of a single integer ‘q’, denoting the number of queries. Each of the next ‘q’ lines consists of a single integer ‘k’.

            Note: The input strings consist only of lowercase english alphabets ‘a’ - ‘z’.

 

            Output:
            Output ‘q’ lines, where the ith line consists of a string which is the answer to the ith query. If the input is invalid (‘k’ > 	S 	), output “INVALID” (quotes for clarity) for that case.

            Constraints:

            1<=n<=50
            1<=mi<=2000
            1<=q<=500
            1<=k<=1000000000

            Sample Input:
            2
            aab
            aac
            3
            3
            8
            23

            Sample Output:
            aab
            c
            INVALID

            Explanation:

            For the sample test case, we have 2 strings “aab” and “aac”.
            S1 = {“a”, “aa”, “aab”, “ab”, “b”} . These are the 5 unique substrings of “aab”.
            S2 = {“a”, “aa”, “aac”,  “ac”, “c” } . These are the 5 unique substrings of “aac”.
            Now, S = {S1 U S2} = {“a”, “aa”, “aab”, “aac”, “ab”, “ac”, “b”, “c”}. Totally, 8 unique strings are present in the set ‘S’.
            The lexicographically 3rd smallest string in ‘S’ is “aab” and the lexicographically 8th smallest string in ‘S’ is “c”. Since there are only 8 distinct substrings, the answer to the last query is “INVALID”.
            */
        public List<string> FindString(string[] input)
        {
            HashSet<string> hashSet = new HashSet<string>();
            List<string> res = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    for (int k = 1; k < input[i].Length - j; k++)
                    {
                        string tmp = input[i].Substring(j, k);
                        if (!hashSet.Contains(tmp))
                        {
                            hashSet.Add(tmp);
                            res.Add(tmp);
                        }
                    }
                }
            }
            res.Sort();
            return res;
        }
    }
}
