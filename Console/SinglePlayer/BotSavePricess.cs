using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayer
{
    public class BotSavePrincess
    {
        /*https://www.hackerrank.com/challenges/saveprincess
         * Princess Peach is trapped in one of the four corners of a square grid. You are in the center of the grid and can move one step at a time in any of the four directions. Can you rescue the princess? 

            Input format

            The first line contains an odd integer M (< 100) denoting the size of the grid. This is followed by an MxM grid. Each cell is denoted by ‘-‘ (ascii value: 45). The bot position is denoted by ‘m’ and the princess position is denoted by ‘p’.

            The top left of the grid is indexed at (0,0) and the bottom right is indexed at (M-1,M-1)

            Output format

            Output each move you take to rescue the princess in one go. Moves must be separated by ‘\n’ a newline. The valid outputs are LEFT or RIGHT or UP or DOWN.

            Sample input 
            3
            ---
            -m-
            p--


            Sample output 

            DOWN
             LEFT

         */
        public List<string> SavePrincess(int m, string[] grid)
        {
            int i = 0; int j=0; int pi=0; int pj=0;
            int k = 0;

            if (grid[0][0] == 'p')
            {
                pi = 0; pj = 0;
            }
            else if (grid[0][m - 1] == 'p')
            {
                pi = 0; pj = 0;
            }
            else if (grid[m - 1][0] == 'p')
            {
                pi = m-1; pj = 0;
            }
            else if (grid[m - 1][m-1] == 'p')
            {
                pi = m - 1; pj = m-1;
            }
            bool foundbot = false;
            for (int l = 0; l < m; l++)
            {
                for (int n = 0; n < m; n++)
                {
                    if (grid[l][n] == 'm')
                    {
                        i = l;
                        j = n;
                        foundbot = true;
                        break;
                    }
                }
                if (foundbot)
                {
                    break;
                }
            }
            List<string> res = new List<string>();
            while (i != pi || j != pj)
            {
                if (i > pi)
                {
                    i--;
                    res.Add("UP");
                }
                else if (i < pi)
                {
                    i++;
                    res.Add("DOWN");
                }

                if (j > pj)
                {
                    j--;
                    res.Add("LEFT");
                }
                else if (j < pj)
                {
                    j++;
                    res.Add("RIGHT");
                }
            }
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
            return res;
        }
    }
}
