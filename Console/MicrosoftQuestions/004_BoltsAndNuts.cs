using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftQuestions
{
    public class _004_BoltsAndNuts
    {
        /*
         * A list of bolts and nuts, sort the both array match them. make all 
         * compare(bolts[i], nuts[i]) == 0;
         */

        public void Match(Bolt[] bolts, Nut[] nuts)
        {
            Match(bolts, nuts, 0, bolts.Length - 1);
        }

        public void Match(Bolt[] bolts, Nut[] nuts, int left, int right)
        {
            if (left >= right) return;
            int nutIndex = -1;
            int leftNuts = left;
            int rightNuts = right;
            while (leftNuts <= rightNuts)
            {
                while (leftNuts <= right && Compare(bolts[left], nuts[leftNuts]) < 0) leftNuts++;
                while (rightNuts >= left && Compare(bolts[left], nuts[rightNuts]) > 0) rightNuts--;
                if (leftNuts <= rightNuts)
                {

                    if (Compare(bolts[left], nuts[leftNuts]) == 0)
                    {
                        Swap<Nut>(nuts, left, leftNuts);
                        leftNuts++;
                    }
                    else if (Compare(bolts[left], nuts[rightNuts]) == 0)
                    {
                        Swap<Nut>(nuts, left, rightNuts);
                        rightNuts--;
                    }
                    else
                    {

                        Swap<Nut>(nuts, leftNuts, rightNuts);
                        leftNuts++;
                        rightNuts--;
                    }
                }
            }
            if (leftNuts > left)
            {
                Swap<Nut>(nuts, left, leftNuts - 1);
                nutIndex = leftNuts - 1;
            }
            else
            {
                nutIndex = left;
            }

            int leftBolts = left + 1;
            int rightBolts = right;
            while (leftBolts <= rightBolts)
            {
                while (leftBolts <= right && Compare(bolts[leftBolts], nuts[nutIndex]) > 0) leftBolts++;
                while (rightBolts >= left && Compare(bolts[rightBolts], nuts[nutIndex]) < 0) rightBolts--;
                if (leftBolts <= rightBolts)
                {
                    Swap<Bolt>(bolts, leftBolts, rightBolts);
                    leftBolts++;
                    rightBolts--;
                }
            }
            Swap<Bolt>(bolts, left, nutIndex);
            Match(bolts, nuts, left, nutIndex - 1);
            Match(bolts, nuts, nutIndex + 1, right);
        }

        public void Swap<T>(T[] input, int i, int j)
        {
            T tmp = input[i];
            input[i] = input[j];
            input[j] = tmp;
        }


        public int Compare(Bolt bolt, Nut nut)
        {
            if (bolt == null || nut == null) throw new ArgumentException();
            if (bolt.value == nut.value)
            {
                return 0;
            }
            if (bolt.value < nut.value)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }





    public class Bolt
    {
        public int value;
    }

    public class Nut
    {
        public int value;
    }
}
