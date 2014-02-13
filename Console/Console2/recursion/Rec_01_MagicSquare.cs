using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.recursion
{
    public class Rec_01_MagicSquare
    {
        /*
            First, what is a magic square?
            A magic square is a 'matrix' or a 2-dimensional grid of numbers. Take the simple case of a 3x3 magic square. Here's one:- 
            A Magic Square contains a certain bunch of numbers, in this case, 1..9, each of which has to be filled once into the grid. 
            The 'magic' property of a Magic Square is that the sum of the numbers in the rows and columns and diagonals should all be same,
         */
        public List<int[]> CreateAMagicSquare(int n)
        {
            int[] input = new int[n*n];
            bool[] tracker = new bool[n * n];
            List<int[]> res = new List<int[]>();

            Worker(n * n, 1, input, tracker, res);
            return res;
        }

        public void Worker(int n, int k, int[] input, bool[] tracker, List<int[]> res)
        {
            if (n == k - 1)
            {
                if (CheckMagicSquare(input))
                {
                    int[] newArray = new int[input.Length];
                    input.CopyTo(newArray, 0);
                    res.Add(newArray);
                    return;
                }
                else
                {
                    return ;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!tracker[i - 1])
                {
                    input[k - 1] = i;
                    tracker[i - 1] = true;
                    Worker(n, k + 1, input, tracker,res);
                    tracker[i - 1] = false;
                }
            }
        }

        private bool CheckMagicSquare(int[] a)
        {
            int n = (int)Math.Sqrt(a.Length);
            int[,] input = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    input[i, j] = a[i * n + j];
                }
            }

            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i] += input[i, j];
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (res[i] != res[i + 1]) return false;
            }
            int tmp = res[0];
            for (int i = 0; i < n; i++)
            {
                res[i] = 0;
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    res[j] += input[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (res[i] != tmp)
                    return false;
            }

            int diagon = 0;
            for (int i = 0; i < n; i++)
            {
                diagon += input[i, i];
            }
            if (diagon != tmp) return false;
            diagon = 0;
            for (int i = 0; i < n; i++)
            {
                diagon += input[i, n - i-1];
            }
            if (diagon != tmp) return false;
            return true;

        }
    }
}
