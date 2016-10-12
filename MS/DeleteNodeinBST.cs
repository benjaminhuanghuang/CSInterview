public TreeNode DeleteNode(TreeNode root, int value)
{
    if(root == null) return root;

    if (root.val < value)             
    {                 
        root.right = DeleteNode(root.right, value);             
    }             
    else if (root.val > value)
    {
        root.left = DeleteNode(root.left, value);
    }
    else
    {
        if (root.left == null)
        {
            return root.right;
        }
        else
        {
            var pre = root.left;
            while (pre != null && pre.right != null)
            {
                pre = pre.right;
            }

            root.val = pre.val;
            root.left = DeleteNode(root.left, pre.val);
        }
    }

    return root;
}