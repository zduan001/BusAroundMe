﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardSingleProblem
{
    public class BotCleanLarge
    {
        /*
         * https://www.hackerrank.com/challenges/botcleanlarge
                     * The goal of Artificial Intelligence is to create a rational agent (Artificial Intelligence 1.1.4). An agent gets input from the environment through sensors and acts on the environment with actuators. In this challenge, you will program a simple bot to perform the correct actions based on environmental input. 

            Meet the bot MarkZoid. Its a cleaning bot whose sensor is a head mounted camera and the actuator are the wheels beneath it. It’s used to clean the floor.

            The bot here is positioned at a cell in a H*W grid. Your task is to move the bot to clean all the dirty cells.

            Input Format

            The first line contains two single spaced integers which indicates the current position of the bot. The grid is indexed at (0,0) on the top left and (H-1,W-1) on the bottom right. The x co-ordinate increases from top to bottom and y co-ordinate increases left to right.

            The next line contains two single spaced integers H, W (1 <= H, W <= 50) which indicates the size of the board.

            H lines follow representing the grid. Each cell in the grid is represented by any of the following 3 characters. ‘b’ (ascii value 98) indicates the bot’s current position, ‘d’ (ascii value 100) indicates a dirty cell and ‘-‘ (ascii value 45) indicates a clean cell in the grid. If the bot is on a dirty cell, a ‘d’ will be printed in the location.

            Output Format

            The output is the action that is taken by the bot in the current step and it can be any of the movements in 4 directions or cleaning the cell in which it is currently located. The valid output strings are LEFT, RIGHT, UP and DOWN or CLEAN. If the bot ever reaches a dirty cell, output CLEAN to clean the dirty cell. Repeat this process until all the cells on the grid are cleaned.

            Sample Input
            0 0
            5 5
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

            Complete the function next_move that takes in 5 parameters posx, posy being the co-ordinates of the bot’s current position, dimx, dimy being the width and height of the board respectively and board which indicates the board state to print the bot’s next move.

            Scoring

            Your score is 200 - number of moves the bots make. CLEAN is considered a move as well. All boards can be cleaned in less than 200 moves and you cannot get a negative score.

            Once you submit, your bot will be played on four grids with three of the grid configurations unknown to you. The final score will be the sum of your moves in each of the four grids.
            *
         */
         
         public void next_move(int posx, int posy, int dimx, int dimy, String [] board){

             List<DirtySpot> dSpot = new List<DirtySpot>();
             for (int i = 0; i < dimx; i++)
             {
                 for (int j = 0; j < dimy; j++)
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
