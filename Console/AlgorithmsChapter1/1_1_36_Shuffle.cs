using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_36_Shuffle
    {
        public void Shaffle(int[] input)
        {
            Random ran = new Random((int)DateTime.Now.ToOADate());
            for(int i = 0;i< input.Length; i++)
            {
                int tmp = ran.Next(i, input.Length);
                int t = input[i];
                input[i] = input[tmp];
                input[tmp] = t;
            }
        }

        public int[,] VerifyShaffle(int[] input)
        {
            int[,] res = new int[input.Length, input.Length];
            int Max = 1000;
            for (int i = 0; i < Max; i++)
            {
                Shaffle(input);
                for (int j = 0; j < input.Length; j++)
                {
                    res[j, input[j]]++;
                }
            }
            return res;
        }
    }
}
