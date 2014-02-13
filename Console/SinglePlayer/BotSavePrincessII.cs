using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayer
{
    /*https://www.hackerrank.com/challenges/saveprincess2
     * In this version of “Bot saves princess”, Princess Peach can be at any position on the grid except the center. Bot is still positioned at the center of the grid. Can you save the princess?

            Task

            Complete the function nextMove which takes in 4 parameters - an integer n, an integer x and y indicating the position of the bot and the character array grid and output only the next move the bot makes to rescue the princess.

            Input Format

            The first line of the input is N (<100), the size of the board (NxN). The second line of the input contains two space seperated integers, which is the position of the bot. Top left of the board is (0,0) and the bottom right of the grid is (N-1,N-1). N lines follow each line containing N characters which is the grid data. 

            The position of the princess is indicated by the character ‘p’ and the position of the bot is indicated by the character ‘m’ and each cell is denoted by ‘-‘ (ascii value 45). 

            Output Format

            Output only the next move you take to rescue the princess. Valid moves are LEFT or RIGHT or UP or DOWN

            Sample Input
            5
            2 2
            -----
            -----
            p-m--
            -----
            -----


            Sample Output
            LEFT


            Scoring
             Your score for every testcase would be NxN minus number of moves made to rescue the princess where N is the size of the grid (5x5 in the sample testcase). 

     */
    public class BotSavePrincessII
    {
        public void SavePrincess(int n, int x, int y, string[] grid)
        {
            int i = x; int j = y; int pi = 0; int pj = 0;
 


            bool foundprincess = false;
            for (int l = 0; l < n; l++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (grid[l][k] == 'p')
                    {
                        pi = l;
                        pj = k;
                        foundprincess = true;
                        break;
                    }
                }
                if (foundprincess)
                {
                    break;
                }
            }

            if (i > pi)
            {
                i--;
                Console.WriteLine("UP");
            }
            else if (i < pi)
            {
                i++;
                Console.WriteLine("DOWN");
            }
            else  if (j > pj)
            {
                j--;
                Console.WriteLine("LEFT");
            }
            else if (j < pj)
            {
                j++;
                Console.WriteLine("RIGHT");
            }
        }
    }
}
