﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayer
{
    public class BotCleanStochastic
    {
        /*
         * https://www.hackerrank.com/challenges/botcleanr
         * A deterministic environment is one where the next state is completely determined by the current state of the environment and the task executed by the agent. If there is any randomness involved in determining the next state, the environment is stochastic.

            The game Bot Clean took place in a deterministic environment. In this version, the bot is given 200 moves to clean as many dirty cells as possible. The grid initially has 1 dirty cell. When the bot cleans this cell, a new cell in the grid is made dirty. The new cell can be anywhere in the grid.

            The bot here is positioned at the top left corner of a 5*5 grid. Your task is to move the bot to appropriate dirty cell and clean it.

            Input Format

            The first line contains two single spaced integers which indicates the current position of the bot. The grid is indexed (x, y) 0<=x,y<=4 top to bottom and left to right respectively.

            5 lines follow showing the grid rows. Each cell in the grid is represented by any of the following 3 characters:

            ‘b’ (ascii value 98) - the bot’s current position (if on clean cell).

            ‘d’ (ascii value 100) - a dirty cell (even if robot there).

            ’-‘ (ascii value 45) - a clean cell in the grid.

            Sample Input

            0 0
            b---d
            -----
            -----
            -----
            -----
            Output Format

            Output is the action that is taken by the bot in the current step and it can be any of the movements in 4 directions or cleaning the cell in which it is currently located. The output formats are LEFT, RIGHT, UP and DOWN or CLEAN. Output CLEAN to clean the dirty cell. Repeat this process until all the cells on the grid are cleaned.

            Sample Output

            RIGHT
            Task

            Complete the function nextMove that takes in 3 parameters posx, posy being the co-ordinates of the bot’s current position and board which indicates the board state, and print the bot’s next move.

            Scoring

            At the end of 200 moves, your score will be equal to the number of dirty cell the bot has cleaned divided by 4.

            Educational Links

            https://en.wikipedia.org/wiki/Stochastic_game
         */
        public  void nextMove(int posx, int posy, String[] board)
        {
            int x = -1;
            int y = -1;
            bool found = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i][j] == 'd')
                    {
                        x = i;
                        y = j;
                        found = true;
                        break;
                    }
                }
                if (found)
                    break;
            }
            if (x != -1 && y != -1)
            {
                if (x == posx && y == posy)
                {
                    Console.WriteLine("CLEAN");
                }
                else
                {
                    if (x < posx)
                    {
                        Console.WriteLine("UP");
                    }
                    else if (x > posx)
                    {
                        Console.WriteLine("DOWN");
                    }
                    else if (y < posy)
                    {
                        Console.WriteLine("LEFT");
                    }
                    else if (y > posy)
                    {
                        Console.WriteLine("RIGHT");
                    }
                }
            }
        }
    }
}
