using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookQuestions
{
    public class _006_PrintOutAllBinaryTree
    {
        /*
         * Given preorder of a binary tree, print out all the binary trees.
         * actually I can print out all possible inorder it will be fine....
         */
        public List<TreeNode> PrintAllBinaryTree(string s)
        {
            if (s.Length == 0) return new List<TreeNode>() { null };
            List<TreeNode> res = new List<TreeNode>();
            TreeNode root = new TreeNode((int)s[0]);
            List<TreeNode> left = new List<TreeNode>();
            List<TreeNode> right = new List<TreeNode>();
            for (int i = 1; i < s.Length; i++)
            {
                for(int j = i;j< s.Length;j++)
                {
                    left = PrintAllBinaryTree(s.Substring(i,j-1));
                    right = PrintAllBinaryTree(s.Substring(j,s.Length-1-j));
                    foreach(TreeNode leftnode in left)
                    {
                        foreach(TreeNode rightnode in right)
                        {
                            root.LeftChild = leftnode;
                            root.RightChild = rightnode;
                            // a clone of root has be added here.
                            res.Add(root);
                        }
                    }
                }
            }
            return res;

        }

        public List<string> PrintAllBinaryTreeII(string s)
        {
            if (s.Length == 0) return new List<string>{string.Empty};
            if (s.Length == 1) return new List<string> { s.ToString() };
            List<string> res = new List<string>();
            for (int i = 1; i < s.Length; i++)
            {
                List<string> leftlist = PrintAllBinaryTreeII(s.Substring(1, i - 1));
                List<string> rightlist = PrintAllBinaryTreeII(s.Substring(i + 1));
                foreach (string lstr in leftlist)
                {
                    foreach (string rstr in rightlist)
                    {
                        res.Add(lstr + s[0] + rstr);
                    }
                }
            }
            return res;
        }

        public void PrintOutTree(TreeNode root)
        {
            //print out root.
        }
    }
}
