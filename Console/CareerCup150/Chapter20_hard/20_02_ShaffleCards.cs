using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter20_hard
{
    public class _20_02_ShaffleCards
    {
        /*
         * Write a method to shuffle a deck of cards. It must be a perfect shuffle - in other words, each 52! permutations of the 
         * deck has to be equally likely. Assume that you are given a random number generator which is perfect.
         */
        /// <summary>
        /// this question does not have "ji shu han liang le". it is tooooooo old .
        /// </summary>
        /// <param name="input"></param>
        public void ShaffleCards(int[] input)
        {
            Random ran = new Random((int)DateTime.Now.ToBinary());
            for (int i = 0; i < input.Length; i++)
            {
                int tmp = ran.Next(i, input.Length);
                Swap(input, i, tmp);
            }
        }

        public void Swap(int[] input, int i, int j)
        {
            int tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }
    }
}
