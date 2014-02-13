using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
     * Determine whether an integer is a palindrome. Do this without extra space.
     */
    /// <summary>
    /// this recursive method is elegant. The way it recursively call to the end and then come back up 
    /// while coming back up, check the palindroma.
    /// </summary>
    public class _041_IsPalindromeNumber
    {
        public bool PalindromeNumberChecker(int x)
        {
            return Worker(x, ref x);
        }

        private bool Worker(int x, ref int y)
        {
            if (x < 0) return false;
            if (x == 0) return true;

            if(Worker(x/10, ref y) && (x%10 == y%10))
            {
                y = y/10;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
