using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra
{
    public class TreeNode
    {
        public int Value { get; set; }
        public int TotalChildren { get; set; }
        public TreeNode LeftChild { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode Parent { get; set; }
        public TreeNode Next { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }

        #region deserialize Tree
        public static int index;
        /// <summary>
        /// Deserialize a tree from a string
        /// </summary>
        /// <param name="inputstring">input string</param>
        /// <param name="t">separator charator such as "1, 2, 3, 4" here ',' is a separator</param>
        /// <returns>result tree</returns>
        public static TreeNode DeserializeTree(string inputstring, char t)
        {
            string[] stringArray = inputstring.Split(t);
            index = 0;
            return CreatTree(stringArray);
        }

        /// <summary>
        /// Working method of the recursive.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static TreeNode CreatTree(string[] inputArray)
        {
            if (index > inputArray.Length - 1 || inputArray[index] == "#")
            {
                index++;
                return null;
            }
            if (index < inputArray.Length)
            {
                TreeNode node = new TreeNode(int.Parse(inputArray[index]));
                index++;
                node.LeftChild = CreatTree(inputArray);
                node.RightChild = CreatTree(inputArray);
                return node;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region serialize Tree
        /// <summary>
        /// Serialize a tee to string.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string SeriallizeTree(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            printOutTree(root, sb);
            return sb.ToString();
        }

        /// <summary>
        /// recursive method for serialize tree.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="sb"></param>
        public static void printOutTree(TreeNode node, StringBuilder sb)
        {
            if (sb.Length != 0) sb.Append(",");
            if (node == null)
            {
                sb.Append("#");
            }
            else
            {
                sb.Append(node.Value);
                printOutTree(node.LeftChild, sb);
                printOutTree(node.RightChild, sb);
            }
        }
        #endregion

        #region Verify Trees
        /// <summary>
        /// Verify if a tree is a BST. 
        /// </summary>
        /// <param name="root">root of the tree</param>
        /// <returns></returns>
        public static bool VerifyIfATreeIsABST(TreeNode root)
        {
            if (root.LeftChild == null && root.RightChild == null) return true;

            if (root.LeftChild != null && root.RightChild == null)
            {
                if (root.LeftChild.Value <= root.Value)
                {
                    return VerifyIfATreeIsABST(root.LeftChild);
                }
                else
                {
                    return false;
                }
            }

            if (root.RightChild != null && root.LeftChild == null)
            {
                if (root.RightChild.Value >= root.Value)
                {
                    return VerifyIfATreeIsABST(root.RightChild);
                }
                else
                {
                    return false;
                }
            }

            if (root.LeftChild != null && root.RightChild != null)
            {
                if (root.LeftChild.Value <= root.Value && root.Value <= root.RightChild.Value)
                {
                    return VerifyIfATreeIsABST(root.LeftChild) && VerifyIfATreeIsABST(root.RightChild);
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifyis a tree is a BST
        /// </summary>
        /// <param name="root"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool VerifyBST(TreeNode root, int left, int right)
        {
            if (root.Value < left || root.Value > right)
            {
                return false;
            }
            else
            {
                if (root.LeftChild == null && root.RightChild == null)
                {
                    return true;
                }
                else if (root.RightChild != null)
                {
                    return VerifyBST(root.RightChild, root.Value, right);
                }
                else if (root.LeftChild != null)
                {
                    return VerifyBST(root.LeftChild, left, root.Value);
                }
                else
                {
                    return VerifyBST(root.LeftChild, left, root.Value) && VerifyBST(root.RightChild, root.Value, right);
                }
            }
        }


        /// <summary>
        /// Verify if a tree is balanced. a balance tree's leaves's max depth difference should be less or equal to 1.
        /// </summary>
        /// <param name="root">The tree need to be verified</param>
        /// <returns>true if the tree is balanced</returns>
        public static bool VerifyIfBalanced(TreeNode root)
        {
            if (Math.Abs(MaxDepth(root.LeftChild) - MaxDepth(root.RightChild)) > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Find the max depth of the tree.
        /// </summary>
        /// <param name="root">the tree</param>
        /// <returns>the max depth.</returns>
        private static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.LeftChild), MaxDepth(root.RightChild)) + 1;
        }
        #endregion

        #region inroder travel
        /// <summary>
        /// Given a binary tree, return the inorder traversal of its nodes' values.
        ///For example:
        ///Given binary tree {1,#,2,3},
        ///return [1,3,2].
        /// </summary>
        /// <param name="root">the tree</param>
        public static string TreeTravelInorder(TreeNode root)
        {
            if (root == null) return string.Empty;
            StringBuilder sb = new StringBuilder();
            Stack<TreeNode> s = new Stack<TreeNode>();
            s.Push(root);
            TreeNode node;
            node = s.Peek();
            while (node.LeftChild != null)
            {
                s.Push(node.LeftChild);
                node = node.LeftChild;
            }
            while (s.Count != 0)
            {
                node = s.Pop();
                if (sb.Length > 0)
                {
                    sb.Append(",");
                }
                sb.Append(node.Value.ToString());
                if (node.RightChild != null)
                {
                    s.Push(node.RightChild);
                    node = node.RightChild;
                }
                if (s.Count == 0) continue;
                if (node == s.Peek().LeftChild) continue;
                node = s.Peek();
                while (node.LeftChild != null)
                {
                    s.Push(node.LeftChild);
                    node = node.LeftChild;
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Given a binary tree, return the inorder traversal of its nodes' values.
        /// Same as last method, used a backtrack
        /// </summary>
        /// <param name="root">The Tree</param>
        /// <returns>string output of in order travel.</returns>
        public static string BinaryTreeInorderTravel2(TreeNode root)
        {
            if (root == null) return null;
            Stack<TreeNode> s = new Stack<TreeNode>();
            StringBuilder sb = new StringBuilder();
            s.Push(root);
            bool backTrack = false;
            while (!(s.Count == 0))
            {
                TreeNode tmp = s.Peek();
                if (tmp.LeftChild != null && !backTrack)
                {
                    s.Push(tmp.LeftChild);
                    backTrack = false;
                    continue;
                }
                if (sb.Length > 0)
                {
                    sb.Append(",");
                }
                sb.Append(tmp.Value.ToString());

                s.Pop();
                backTrack = true;
                if (tmp.RightChild != null)
                {
                    s.Push(tmp.RightChild);
                    backTrack = false;
                }
            }
            return sb.ToString();
        }
        #endregion

        #region post order travel
        /// <summary>
        /// Travel a tree post order interatively.
        /// </summary>
        /// <param name="root">the tree</param>
        /// <returns>trace.</returns>
        public static string TreeTravelPostOrder(TreeNode root)
        {
            if (root == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode previous = null;
            TreeNode cur;
            s.Push(root);
            while (!(s.Count == 0))
            {
                cur = s.Peek();
                if (cur.LeftChild == null && cur.RightChild == null)
                {
                    cur = s.Pop();
                    if (sb.Length != 0) sb.Append(",");
                    sb.Append(cur.Value.ToString());
                }
                else if (previous == cur.LeftChild)
                {
                    if (cur.RightChild != null)
                    {
                        s.Push(cur.RightChild);
                    }
                    else
                    {
                        cur = s.Pop();
                        if (sb.Length != 0) sb.Append(",");
                        sb.Append(cur.Value.ToString());
                    }
                }
                else if (previous == cur.RightChild)
                {
                    cur = s.Pop();
                    if (sb.Length != 0) sb.Append(",");
                    sb.Append(cur.Value.ToString());
                }
                else
                {
                    s.Push(cur.LeftChild);
                }
                previous = cur;

            }

            return sb.ToString();
        }
        #endregion

        #region sub tree
        /// <summary>
        /// If a tree is a sub tree of another tree. this method check the value of the treenode.
        /// </summary>
        /// <param name="t1">parent tree</param>
        /// <param name="t2">sub tree to be</param>
        /// <returns>if it is a sub tree</returns>
        public static bool IsASubTree(TreeNode t1, TreeNode t2)
        {
            // null tree is sub tree of any tree.
            if (t2 == null) return true;
            // t2 != null but t1 == null, then it is not a sub tree.
            if (t1 == null) return false;

            if (t1.Value == t2.Value &&
                IsASubTree(t1.LeftChild, t2.LeftChild) && 
                IsASubTree(t1.RightChild, t2.RightChild))
            {
                return true;
            }
            else
            {
                return IsASubTree(t1.LeftChild, t2) || IsASubTree(t1.RightChild, t2);
            }
        }

        /// <summary>
        /// If a tree is a sub tree of another tree. this method check the reference of the treenode.
        /// </summary>
        /// <param name="t1">parent tree</param>
        /// <param name="t2">sub tree to be</param>
        /// <returns>if it is a sub tree</returns>
        public static bool IsASubTreeRef(TreeNode t1, TreeNode t2)
        {
            // null tree is sub tree of any tree.
            if (t2 == null) return true;
            // t2 != null but t1 == null, then it is not a sub tree.
            if (t1 == null) return false;

            return (t1 == t2) ||
                (t1.LeftChild == t2) ||
                (t1.RightChild == t2);
        }
        #endregion

        #region print tree border

        private static StringBuilder sb;
        public static string PrintOutBorder(TreeNode root)
        {
            sb = new StringBuilder();
            PrintOutleft(root);
            PrintOutBottom(root);
            PrintOutRight(root);
            return sb.ToString();
        }

        /// <summary>
        /// Working method for print out border, left
        /// </summary>
        /// <param name="root"></param>
        private static void PrintOutleft(TreeNode root)
        {
            if (root == null) return;
            if (!(root.LeftChild == null && root.RightChild == null))
            {
                sb.Append(root.Value + ", ");
            }

            PrintOutleft(root.LeftChild);
        }

        /// <summary>
        /// Working method for print out border, bottom
        /// </summary>
        /// <param name="root"></param>
        private static void PrintOutBottom(TreeNode root)
        {
            if (root == null) return;
            PrintOutBottom(root.LeftChild);
            if (root.LeftChild == null && root.RightChild == null)
            {
                sb.Append(root.Value + ", ");
            }
            PrintOutBottom(root.RightChild);
        }

        /// <summary>
        /// Woring method for print out border, right
        /// </summary>
        /// <param name="root"></param>
        private static void PrintOutRight(TreeNode root)
        {
            if (root == null) return;
            PrintOutRight(root.RightChild);
            if (!(root.LeftChild == null && root.RightChild == null))
            {
                sb.Append(root.Value + ", ");
            }
        }

        #endregion

        #region contruct tree from preorder and in order
        /// <summary>
        /// Construct a binary tree from pre order traversal and in order traversal.
        /// the element in 
        /// </summary>
        /// <param name="preOrder"></param>
        /// <param name="inOrder"></param>
        /// <returns></returns>
        public static TreeNode ContructTreeFromPreaAndIn(int[] preOrder, int[] inOrder)
        {
            if (preOrder.Length == 0 || inOrder.Length == 0) return null;
            if (preOrder.Length != inOrder.Length) return null;

            return ContructTree(preOrder, inOrder, 0, preOrder.Length - 1, 0, inOrder.Length - 1);
        }


        private static TreeNode ContructTree(int[] preOrder, int[] inOrder, int preStart, int preEnd, int inStart, int inEnd)
        {
            if (preStart > preEnd || inStart > inEnd) return null;

            int pivot = -1;
            for (int i = inStart; i <= inEnd; i++)
            {
                if (preOrder[preStart] == inOrder[i])
                {
                    pivot = i;
                    break;
                }
            }
            if (pivot == -1) return null;
            TreeNode node = new TreeNode(preOrder[preStart]);
            node.LeftChild = ContructTree(preOrder, inOrder, preStart + 1, preStart + pivot - inStart, inStart, pivot - 1);
            node.RightChild = ContructTree(preOrder, inOrder, preStart + pivot - inStart + 1, preEnd, pivot + 1, inEnd);


            return node;
        }
        #endregion

        #region printout level
        public void PrintOutLevel(TreeNode node)
        {
            // null,check.....
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(node);
            q.Enqueue(null); // This is the tail of the first levle.
            while (!(q.Count == 0))
            {
                TreeNode tmp = q.Dequeue();
                if (tmp == null)
                {
                    //print out new line...
                    if (!(q.Count == 0)) // make sure the null is not the tail of the last level.
                    {
                        q.Enqueue(null); // tail of the level.
                    }
                }
                else
                {
                    if (tmp.LeftChild != null) q.Enqueue(tmp.LeftChild);
                    if (tmp.RightChild != null) q.Enqueue(tmp.RightChild);
                }
            }
        }

        public static void PrintOutLevelZigzagII(TreeNode node)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            Stack<TreeNode> tmpStack = new Stack<TreeNode>();
            q.Enqueue(node);
            while (q.Count != 0 || s.Count != 0)
            {
                while (q.Count != 0)
                {
                    TreeNode tmp = q.Dequeue();
                    if (tmp.LeftChild != null) s.Push(tmp.LeftChild);
                    if (tmp.RightChild != null) s.Push(tmp.RightChild);
                    System.Diagnostics.Debug.Write(tmp.Value);
                }
                while (s.Count != 0)
                {
                    TreeNode tmp = s.Pop();
                    if (tmp.LeftChild != null) tmpStack.Push(tmp.RightChild);
                    if (tmp.RightChild != null) tmpStack.Push(tmp.LeftChild);
                    System.Diagnostics.Debug.Write(tmp.Value);
                }
                while (tmpStack.Count != 0)
                {
                    q.Enqueue(tmpStack.Pop());
                }

            }
        }


        public static void PrintOutLevelZigZag(TreeNode node)
        {
            // null check
            Queue<TreeNode> q = new Queue<TreeNode>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            q.Enqueue(node);
            q.Enqueue(null);
            while (q.Count != 0)
            {
                TreeNode tmp = q.Dequeue();
                if (tmp == null)
                {
                    if (q.Count != 0)
                    {
                        q.Enqueue(null);

                        while (true)
                        {
                            TreeNode t = q.Dequeue();
                            if (t == null)
                            {
                                q.Enqueue(null);
                                break;
                            }
                            if (t.LeftChild != null) q.Enqueue(t.LeftChild);
                            if (t.RightChild != null) q.Enqueue(t.RightChild);
                            s.Push(t);
                        }
                        while (s.Count != 0)
                        {
                            System.Diagnostics.Debug.Write(s.Pop().Value);
                        }
                        
                    }
                }
                else
                {
                    if (tmp.LeftChild != null) q.Enqueue(tmp.LeftChild);
                    if (tmp.RightChild != null) q.Enqueue(tmp.RightChild);
                    System.Diagnostics.Debug.Write(tmp.Value);
                }
            }
        }
        #endregion

    }
}
