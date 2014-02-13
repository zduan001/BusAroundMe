using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _002_FindAllFactors
    {
        /* Difficult: *****
         * Write a program that takes an integer and prints out all ways to multiply smaller
            integers that equal the original number, without repeating sets of factors. In other words, if
            your output contains 4  3, you should not print out 3  4 again as that would be a repeating
            set. Note that this is not asking for prime factorization only. Also, you can assume that the
            input integers are reasonable in size; correctness is more important than eciency.
         * http://www.mitbbs.com/article_t/JobHunting/32058461.html
         * one interesting point of thiq question is I need to use the increase or decrease order
         * to make sure there is no dup in the answer. so I can make one loop O(n) to solve this problem. 
         * and I do not need to has a hashset to check the dup.
         * ah.. I did it wrong. there is no limitation  as only 2 factor allowed. 100 = 25*2*2 or 100 = 5*5*2*2 are fine too.
         */
        public List<KeyValuePair<int, int>> FindAllFactors(int n)
        {
            List<KeyValuePair<int, int>> resList = new List<KeyValuePair<int, int>>();
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();
            int left = 1;
            int right = n;
            while (left <= right)
            {
                int res = left * right;
                if (res == n)
                {
                    leftList.Add(left);
                    rightList.Add(right);
                    left++;
                    right--;
                }
                else if (res < n)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            for (int i = 0; i < leftList.Count; i++)
            {
                KeyValuePair<int, int> pair = new KeyValuePair<int, int>(leftList[i], rightList[i]);
                resList.Add(pair);
            }

            return resList;
        }

        public List<List<int>> FindAllFactorsII(int n)
        {
            if (n <= 2) return null;
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>() { n });
            for (int i = n ; i > 0; i--)
            {
                if ((n / i) * i == n && i>= n/i)
                {
                    res.Add(new List<int>() { i, n / i });
                    List<List<int>> temp = FindAllFactorsII(n / i);
                    if (temp != null)
                    {
                        foreach (List<int> l in temp)
                        {
                            List<int> newList = new List<int>();
                            newList.Add(i);
                            foreach (int elem in l)
                            {
                                newList.Add(elem);
                            }
                            res.Add(newList);
                        }
                    }
                }
            }
            return res;
        }
    }
}
