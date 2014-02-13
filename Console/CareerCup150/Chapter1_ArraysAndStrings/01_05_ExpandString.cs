using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapt1_ArraysAndStrings
{
    public class _01_05_ExpandString
    {
        /*
         * Write a method to replace all spaces in a string with ‘%20’.
         */
        public char[] ExpandCharArray(char[] input)
        {
            int i = 0;
            int count = 0;
            while (input[i] != '\0')
            {
                i++;
                if (input[i] == ' ')
                {
                    count++;
                }
            }

            int end = i + count * 2;

            int j = i;
            while (j >= 0)
            {
                if (input[j] == ' ')
                {
                    input[end] = '0';
                    input[end - 1] = '2';
                    input[end - 2] = '%';
                    end = end - 3;
                }
                else
                {
                    input[end] = input[j];
                    end--;
                }
                j--;
            }

            return input;
        }
    }
}
