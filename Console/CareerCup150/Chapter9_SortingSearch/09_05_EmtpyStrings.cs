using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter9_SortingSearch
{
    public class _09_05_EmtpyStrings
    {
        /*
         * Given a sorted array of strings which is interspersed with empty strings, write a method to find the location of a given string.
            Example: find “ball” in [“at”, “”, “”, “”, “ball”, “”, “”, “car”, “”, “”, “dad”, “”, “”] will return 4
            Example: find “ballcar” in [“at”, “”, “”, “”, “”, “ball”, “car”, “”, “”, “dad”, “”, “”] will return -1
         */

        public int FindString(string[] input, string value)
        {
            int left = 0;
            int right = input.Length - 1;
            int mid;
            while (left <= right)
            {
                mid = (left + right) / 2;
                
                if (input[mid] == "")
                {
                    while (input[mid] == "" && mid != left)
                    {
                        mid--;
                    }
                    if (mid == left)
                    {
                        while (input[mid] == "" && mid != right)
                        {
                            mid++;
                        }
                    }
                }
                if (input[mid] == value) return mid;
                if (string.Compare(value , input[mid]) <0)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }
    }
}
