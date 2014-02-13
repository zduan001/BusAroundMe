using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCup150.Chapter19_Medium
{
    public class _19_05_MasterMind
    {
        /*
        The Game of Master Mind is played as follows:
        The computer has four slots containing balls that are red (R), yellow (Y), green (G) or blue (B).
        For example, the computer might have RGGB (e.g., Slot #1 is red, Slots #2 and #3 are green, Slot #4 is blue).
        You, the user, are trying to guess the solution. You might, for example, guess YRGB.
        When you guess the correct color for the correct slot, you get a “hit”. If you guess a color that exists but is in the wrong slot, you get a “pseudo-hit”. 
        For example, the guess YRGB has 2 hits and one pseudo hit.
        For each guess, you are told the number of hits and pseudo-hits.
        Write a method that, given a guess and a solution, returns the number of hits and pseudo hits.
        */
        /// <summary>
        /// Since only have 4 slot is too simple, I will try to do it as n slot.
        /// </summary>
        /// <param name="real"></param>
        /// <param name="guess"></param>
        /// <returns></returns>
        public string Response(string real, string guess)
        {
            if (real.Length != guess.Length) return string.Empty;
            HashSet<char> notHitChars = new HashSet<char>();
            bool[] hits = new bool[real.Length];
            int hitCount = 0;
            for (int i = 0; i < real.Length; i++)
            {
                if(real[i] == guess[i]) 
                {
                    hits[i] = true;
                    hitCount ++;
                }
                else
                {
                    if(!notHitChars.Contains(real[i]))
                    {
                        notHitChars.Add(real[i]);
                    }
                }

            }
            int pseudoHitCount = 0;
            for(int i = 0; i< real.Length; i ++)
            {
                if(!hits[i])
                {
                    if(notHitChars.Contains(guess[i]))
                    {
                        pseudoHitCount ++;
                    }
                }
            }
            return "Hits " + hitCount.ToString() + ", PseudoHits " + pseudoHitCount.ToString() + ".";
        }
    }
}
