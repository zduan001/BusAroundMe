using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter9_SortingSearch
{
    /*
     * Write a function to swap a number in place without temporary variables.
     */
    public class _19_01_SwapWithOutAdditional
    {
        public void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
