/*
572. Subtree of Another Tree

Given two non-empty binary trees s and t, check whether tree t has exactly the same structure and 
node values with a subtree of s. A subtree of s is a tree consists of a node in s and all of this 
node's descendants. The tree s could also be considered as a subtree of itself.


 */


public class Solution572
{
    public bool IsSubtree(TreeNode s, TreeNode t)
    {
        if (t == null)
        {
            return true;
        }

        if (s == null)
        {
            return false;
        }
        if (s.val == t.val)
        {
            return this.IsSameTree(s, t);
        }
        return this.IsSubtree(s.left, t) || this.IsSubtree(s.right, t);
    }

    private bool IsSameTree(TreeNode s, TreeNode t)
    {
        if (s == null && t == null)
        {
            return true;
        }

        if (s == null || t == null)
        {
            return false;
        }

        if (s.val != t.val)
        {
            return false;
        }

        return this.IsSameTree(s.left, t.left)
            && this.IsSameTree(s.right, t.right);
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}