using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter3_StacksAndQueues
{
    /*
     * Describe how you could use a single array to implement three stacks.
     */
    public class _03_01_ThreeStacksInOneArray
    {
        const int stackSize = 300;
        int[] array = new int[stackSize * 3];
        int[] stackStart = new int[] { 0, 0, 0 };
        
        public void Push(int stackNumber, int value)
        {
            if (stackStart[stackNumber] >= stackSize) throw new Exception("over flowed.");
            array[stackNumber * stackSize + stackStart[stackNumber]] = value;
            stackStart[stackNumber]++;
        }

        public int Pop(int stackNumber)
        {
            if (stackStart[stackNumber] <= 0) throw new Exception("under flow");
            int res = array[stackNumber * stackSize + stackStart[stackNumber] - 1];
            stackStart[stackNumber]--;
            return res;
        }

        public int Peek(int stackNumber)
        {
            if (stackStart[stackNumber] <= 0) throw new Exception("under flow");
            int res = array[stackNumber * stackSize + stackStart[stackNumber] - 1];
            return res;
        }

        public bool IsEmpty(int stackNumber)
        {
            return stackStart[stackNumber] == 0;
        }
    }
}
