using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder_SRM_571
{
    public class Class1
    {
        /*
         * Single Round Match 571 Round 1 - Division II, Level Three 
         * http://community.topcoder.com/stat?c=problem_statement&pm=12439&rd=15491
         * Fox Ciel is learning magical physics. Currently, she studies Magic Molecules. Each Magic Molecule consists of some Magic Atoms. Each Magic Atom stores some Magic Power, 
         * with different atoms possibly storing different amounts of power. Within the molecule, some pairs of atoms are connected by bidirectional Magic Bonds. 

            Ciel now has a Magic Molecule formed by n Magic Atoms. The atoms are numbered 0 through n-1, inclusive. You are given a int[] magicPower with n elements: For each i, 
         * the amount of power stored in the Magic Atom number i is magicPower[i]. You are also given a String[] magicBond with n elements, each containing n characters. Character j 
         * of element i of magicBond is 'Y' if the Magic Atoms i and j are connected by a Magic Bond. Otherwise, character j of element i of magicBond is 'N'. 

            Your task is to improve Ciel's Magic Molecule. You have to choose a subset S of the n Magic Atoms so that the following two conditions are met: 
            You are given a int k. The subset S must contain exactly k atoms. 
            For each pair of the given n atoms that are connected by a Magic Bond, at least one of these two atoms must belong to S. 
            Your goal is to maximize the total Magic Power stored in the chosen atoms. Compute and return the maximum total amount of power. If it is impossible to choose a subset of 
            atoms that satisfies the above criteria, return -1 instead. 
  
            Definition 
                 Class: MagicMoleculeEasy 
                    Method: maxMagicPower 
                    Parameters: int[], String[], int 
                    Returns: int 
                    Method signature: int maxMagicPower(int[] magicPower, String[] magicBond, int k) 
                    (be sure your method is public) 
  
            Constraints 
            - k will be between 1 and min(n, 14), inclusive, where n is the number of elements in magicPower. 
            - magicPower will contain between 2 and 50 elements, inclusive. 
            - Each element in magicPower will be between 1 and 100,000, inclusive. 
            - magicBond and magicPower will contain the same number of elements. 
            - Each element of magicBond will contain exactly n characters, where n is the number of elements in magicPower. 
            - Each element of magicBond will only contain the characters 'Y' and 'N'. 
            - For each valid i, magicBond[i][i] will be 'N'. 
            - For each valid i and j, magicBond[i][j] will be equal to magicBond[j][i]. 
         */
    }
}
