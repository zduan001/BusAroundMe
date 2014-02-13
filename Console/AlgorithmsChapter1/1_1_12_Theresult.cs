using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsChapter1
{
    public class _1_1_12_Theresult
    {
        /*
         * What does the following code fragment print?
         */
        public string WhatisTheResult()
        {
            int[] a = new int[10]; 
            for (int i = 0; i < 10; i++)
                a[i] = 9 - i; 
            for (int i = 0; i < 10; i++)   
                a[i] = a[a[i]]; 
            string s = string.Empty;
            for (int i = 0; i < 10; i++)
                s = s + a[i].ToString() + ", ";
            return s;
        }
    }
}
