using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console2.From_026_To_050
{
    /*
     * 
    Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).

        For example:
        Given binary tree {3,9,20,#,#,15,7},
 
        3
        / \
        9  20
        /  \
        15   7
 

    return its zigzag level order traversal as:
 
    [
        [3],
        [20,9],
        [15,7]
    ]
     */
    /// <summary>
    /// This should be simple. normal level traversal, but toggle true/false between odd and even. 
    /// if even push all node in the level to a stack, before the null. Then when you see the null 
    /// pop them all back out.... easy implementation, skip it for now.
    /// </summary>
    class _047_TreeZigZagTraversal
    {
    }
}
