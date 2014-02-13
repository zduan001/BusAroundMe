using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    public class _043_PascalTriangle
    {
        /*
         * Given numRows, generate the first numRows of Pascal's triangle.

         For example, given numRows = 5,
         Return 
        [
             [1],
            [1,1],
           [1,2,1],
          [1,3,3,1],
         [1,4,6,4,1]
        ]
         */
        public List<List<int>> PascalTriangle(int n)
        {
            List<List<int>> res = new List<List<int>>();

            res.Add(new List<int>() { 1 });
            if (n == 1) return res;
            res.Add(new List<int>() { 1, 1 });
            if (n == 2) return res;

            for (int i = 2; i < n; i++)
            {
                List<int> tmp = new List<int>() { 1 };
                for (int j = 0; j < res[i - 1].Count - 1; j++)
                {
                    tmp.Add(res[i - 1][j] + res[i - 1][j + 1]);
                }
                tmp.Add(1);
                res.Add(tmp);
            }
            return res;
        }

        /*
         * Given an index k, return the kth row of the Pascal's triangle.

         For example, given k = 3,
         Return [1,3,3,1]. 

         */
        public List<int> psacalTriangleII(int n)
        {
            
            if (n == 1) return new List<int>() { 1 };
            if (n == 2) return new List<int>() { 1, 1 };

            List<int> res = new List<int>(){1,1};

            for (int i = 2; i < n; i++)
            {
                res.Insert(0, 1);
                for (int j = 1; j < res.Count - 1; j++)
                {
                    res[j] = res[j] + res[j + 1];
                }
                res[res.Count - 1] = 1;
            }
            return res;
        }
    }
}
