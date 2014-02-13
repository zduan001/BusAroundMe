using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter3_StacksAndQueues
{
    /*
        In the classic problem of the Towers of Hanoi, you have 3 rods and N disks of different sizes which can slide onto any tower. The puzzle starts with disks sorted in ascending order of size from top to bottom (e.g., each disk sits on top of an even larger one). You have the following constraints:
        (A) Only one disk can be moved at a time.
        (B) A disk is slid off the top of one rod onto the next rod.
        (C) A disk can only be placed on top of a larger disk.
        Write a program to move the disks from the first rod to the last using Stacks.
     */
    /// <summary>
    /// I need to make sure I can rewrite the code bug free.
    /// </summary>
    public class _03_04_TowerOfHanoi
    {
        public Stack<int>[] sArray = new Stack<int>[] {new Stack<int>(),new Stack<int>(),new Stack<int>() };

        private void Initial(int n)
        {
            for (int i = n; i > 0; i--)
            {
                sArray[0].Push(i);
            }
        }

        public void MoveTop(Stack<int> original, Stack<int> destination)
        {
            int tmp = original.Pop();
            destination.Push(tmp);
        }

        public void MoveDisk(int n, Stack<int> original, Stack<int> destination, Stack<int> buffer)
        {
            if (n > 0)
            {
                MoveDisk(n - 1, original, buffer, destination);
                MoveTop(original, destination);
                MoveDisk(n - 1, buffer, destination, original);
            }
        }

        public void Hanoi(int n)
        {
            Initial(n);
            MoveDisk(n, sArray[0], sArray[2], sArray[1]);
        }
    }
}
