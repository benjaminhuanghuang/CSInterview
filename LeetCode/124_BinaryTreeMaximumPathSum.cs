/*
124. Binary Tree Maximum Path Sum

Given a binary tree, find the maximum path sum.

For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path does not need to go through the root.

For example:
Given the below binary tree,

       1
      / \
     2   3


Return 6.
*/
using System;

public class Solution124 {
    private long res = int.MinValue;
    public int MaxPathSum(TreeNode root)
    {
        MaxPathSumHelper(root);
        return (int)res;
    }

    private long MaxPathSumHelper(TreeNode root)
    {
        if (root == null) 
            return 0;

        var left = MaxPathSumHelper(root.left);
        var right = MaxPathSumHelper(root.right);

        var pathThroughRoot = Math.Max(Math.Max(left, right) + root.val, root.val);
        res = Math.Max(res, Math.Max(pathThroughRoot, left + right + root.val));
        return pathThroughRoot;
    }
}