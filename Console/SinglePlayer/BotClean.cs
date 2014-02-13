﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePlayer
{
    public class BotClean
    {
        /*https://www.hackerrank.com/challenges/botclean
         * The goal of Artificial Intelligence is to create a rational agent (Artificial Intelligence 1.1.4). An agent gets input from the environment through sensors and acts on the environment with actuators. In this challenge, you will program a simple bot to perform the correct actions based on environmental input.
            Meet the bot MarkZoid. It’s a cleaning bot whose sensor is a head mounted camera and the actuator are the wheels beneath it. It’s used to clean the floor.
            The bot here is positioned at the top left corner of a 5*5 grid. Your task is to move the bot to clean all the dirty cells.
            Input Format
            The first line contains two single spaced integers which indicates the current position of the bot. The grid is indexed at (0,0) on the top left and (4,4) on the bottom right. The x co-ordinate increases from top to bottom and y co-ordinate increases left to right.
            5 lines follow representing the grid. Each cell in the grid is represented by any of the following 3 characters. ‘b’ (ascii value 98) indicates the bot’s current position, ‘d’ (ascii value 100) indicates a dirty cell and ‘-‘ (ascii value 45) indicates a clean cell in the grid.
            Output Format
            The output is the action that is taken by the bot in the current step and it can be any of the movements in 4 directions or cleaning the cell in which it is currently located. The valid output strings are LEFT, RIGHT, UP and DOWN or CLEAN. If the bot ever reaches a dirty cell, output CLEAN to clean the dirty cell. Repeat this process until all the cells on the grid are cleaned.
            Sample Input

            0 0
            b---d
            -d--d
            --dd-
            --d--
            ----d
            Sample Output

            RIGHT
            Resultant state

            -b--d
            -d--d
            --dd-
            --d--
            ----d
            Task

            Complete the function next_move that takes in 3 parameters posx, posy being the co-ordinates of the bot’s current position and board which indicates the board state to print the bot’s next move.

            Scoring

            Your score is (200 - number of moves the bot makes)/40. CLEAN is considered a move as well.

            Once you submit, your bot will be played on four grids with three of the grid configurations unknown to you. The final score will be the sum of the scores obtained in each of the four grids.

            Education Links

            Introduction to AI by Stuart Russell and Peter Norvig
            Motor cognition
         */
        public void next_move(int posx, int posy, string[] board)
        {
            int n = 5;
            List<DirtySpot> dSpot = new List<DirtySpot>();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[i][j] == 'd')
                    {
                        dSpot.Add(new DirtySpot() { X = i, Y = j });
                    }
                }
            }

            foreach (DirtySpot spot in dSpot)
            {
                spot.Distance = Math.Abs(spot.X - posx) + Math.Abs(spot.Y - posy);
            }

            List<DirtySpot> tmp = dSpot.OrderBy(s => s.Distance).ToList();

            if (tmp[0].Distance == 0)
            {
                Console.WriteLine("CLEAN");
            }
            else
            {
                if (tmp[0].X < posx)
                {
                    Console.WriteLine("UP");
                }
                else if (tmp[0].X > posx)
                {
                    Console.WriteLine("DOWN");
                }
                else if (tmp[0].Y < posy)
                {
                    Console.WriteLine("LEFT");
                }
                else if (tmp[0].Y > posy)
                {
                    Console.WriteLine("RIGHT");
                }
            }


        }

        public class DirtySpot
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Distance { get; set; }
        }
    }
}