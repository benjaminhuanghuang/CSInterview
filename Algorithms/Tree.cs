public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        var values = new List<int>();
        var mystack = new Stack<TreeNode>();
        if (root != null)
        {
            mystack.Push(root);
        }

        while (mystack.Count > 0)
        {
            var top = mystack.Pop();
            values.Add(top.val);
            
            // Note! push right firstly.
            if (top.right != null)
            {
                mystack.Push(top.right);
            }
            if (top.left != null)
            {
                mystack.Push(top.left);
            }
        }

        return values;
    }

    public IList<int> PreorderTraversal_Recursive(TreeNode root) {
        List<int> res = new List<int>();
        this.PreorderTraversal_Recursive_Helper(res, root);
        return res;
    }
    private void PreorderTraversal_Recursive_Helper(List<int> res, TreeNode root)
    {
        if (root == null)
            return;
        res.Add(root.val);
        PreorderTraversal_Recursive_Helper(res, root.left);
        PreorderTraversal_Recursive_Helper(res, root.right);
    }

    // https://miafish.wordpress.com/2015/01/28/leetcode-oj-c-binary-tree-preorder-traversal/
    public IList<int> PreorderTraversal_Iterative_Morris(TreeNode root) 
    {
        var res = new List<int>();

        while (root != null)
        {
            if (root.left != null)
            {
                var pre = root.left;
                while (pre.right != null && pre.right != root)
                {
                    pre = pre.right;
                }

                if (pre.right == null)
                {
                    pre.right = root;
                    res.Add(root.val);
                    root = root.left;
                }
                else
                {
                    pre.right = null;
                    root = root.right;
                }
            }
            else
            {
                res.Add(root.val);
                root = root.right;
            }
        }

        return res;     
    }

    public IList<int> PostorderTraversal_Iterative(TreeNode root) {
        var res = new List<int>();
        var nodeStack = new Stack<TreeNode>();
        if (root != null)
            nodeStack.Push(root);
        while (nodeStack.Count > 0)
        {
            var top = nodeStack.Pop();
            res.Add(top.val);

            // Note! push left firstly
            if (top.left != null)
            {
                nodeStack.Push(top.left);
            }
            if (top.right != null)
            {
                nodeStack.Push(top.right);
            }
        }
        res.Reverse();
        return res;
    }
    public IList<int> PostorderTraversal_Iterative_Morris(TreeNode root) {
        var res = new List<int>();
        while (root != null)
        {
            if (root.left != null)
            {
                var pre = root.left;
                while (pre.right != null && pre.right != root)
                {
                    pre = pre.right;
                }

                if (pre.right == null)
                {
                    pre.right = root;
                    root = root.left;
                }
                else
                {
                    pre.right = null;
                    root = root.right;
                }
            }
            else
            {
                root = root.right;
            }
        }

        return res;
    }
}