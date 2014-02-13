using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    class Class1
    {

        public List<int> FindPrime(int start, int end)
        {
            if(end<start) return null;

            List<int> res = new List<int>();
            for (int i = start; i <= end; i++)
            {
                if (i <= 3)
                {
                    res.Add(i);
                    continue;
                }
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }
                res.Add(i);
            }
            return res;
        }
    }
}
