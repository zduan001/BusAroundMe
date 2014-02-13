using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter19_Medium
{
    public class _19_10_GenerateRandNumber
    {
        /*
         * Write a method to generate a random number between 1 and 7, given a method that generates a random number between 1 and 5 (i.e., implement rand7() using rand5()).
         */
        /*
         * Not quite understand what is the next sentence mean, but .....
         * In order to generate a random number between 1 and 7, we just need to uniformly generate a larger range than we are looking for and then repeatedly sample until we get a number that is good for us. We will generate a base 5 number with two places with two calls to the RNG.
         */
        public int Randm7()
        {
            while (true)
            {
                int num = 5 * (rand5() - 1) + (rand5() - 1);
                if (num < 21) return (num % 7 + 1);
            }
        }

        /// <summary>
        /// assume this method return a true randonm number. 1-5..
        /// </summary>
        /// <returns></returns>
        public int rand5()
        {
            return 1;
        }
    }
}
