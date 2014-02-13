using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_076_To_100
{
    public class _084_TrappingRainWater
    {
        /*
         * Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.
 
        For example, 
        Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6. 

         */
        public int TrappingRainWater(int[] input)
        {
            int maxIndex= -1;
            int maxValue = int.MinValue;

            for(int i = 0;i< input.Length;i++)
            {
                if(maxValue< input[i])
                {
                    maxIndex = i;
                    maxValue = input[i];
                }
            }
            int amountOfWater = 0;
            int topLeft = input[0];
            // from left
            for(int i = 1;i< maxIndex;i++)
            {
                if(input[i]< topLeft)
                {
                    amountOfWater += topLeft - input[i];
                }
                else
                {
                    topLeft = input[i];
                }
            }

            int topRight = input[input.Length-1];
            for(int i = input.Length-2;i>maxIndex;i--)
            {
                if(input[i]< topRight)
                {
                    amountOfWater += topRight-input[i];
                }
                else
                {
                    topRight = input[i];
                }
            }
            return amountOfWater;
        }
    }
}
