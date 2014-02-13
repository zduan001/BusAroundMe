using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestions.cs
{
    public class _014_SameMaxinN
    {
        /*
         * N组整数，每组都由小到大排列，如何快速找出N组都有的最大数？
         */
        public int FindSameMaxN(List<int[]> input)
        {
            if (input == null || input.Count == 0) throw new ArgumentException();

            int[] index = new int[input.Count];
            for (int i = 0; i < index.Length; i++)
            {
                index[i] = input[i].Length - 1;
                if (index[i] < 0) 
                    throw new ArgumentException();
            }

            bool areEqual = false;
            while (!areEqual)
            {
                areEqual = true;
                for (int i = 0; i < index.Length; i++)
                {
                    if(!areEqual) break;
                    for(int j = i+1; j < index.Length;j++)
                    {
                        if(input[i][index[i]] <input[j][index[j]])
                        {
                            index[j] --;
                            if(index[j] <0)
                            {
                                throw new ArgumentException();
                            }
                            areEqual = false;
                            break;
                        }
                        else if(input[i][index[i]] >input[j][index[j]])
                        {
                            index[i] --;
                            if(index[i] <0)
                            {
                                throw new ArgumentException();
                            }
                            areEqual = false;
                            break;
                        }
                    }
                }
            }
            return input[0][index[0]];
        }
    }
}
