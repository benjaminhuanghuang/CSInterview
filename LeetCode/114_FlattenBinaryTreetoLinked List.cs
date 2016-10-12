/*
114. Flatten Binary Tree to Linked List

Given a binary tree, flatten it to a linked list in-place.

For example,
Given

         1
        / \
       2   5
      / \   \
     3   4   6
The flattened tree should look like:
   1
    \
     2
      \
       3
        \
         4
          \
           5
            \
             6
each node’s right child points to the next node of a pre-order traversal.
每一个节点的右孩子都是其先序遍历的下一个节点。
*/
using System.Collections.Generic;

public class Solution114 {
    public void Flatten(TreeNode root) {
        var previous = new List<TreeNode>();
        this.FlattenHelper(root, previous);

        var start = root;
        for (int i = 1; i < previous.Count; i++)
        {
            start.right = previous[i];
            start.left = null;

            start = start.right;
        }
    }
    // pre-order
    private void FlattenHelper(TreeNode root, List<TreeNode> previous)
    {
        if (root == null) return;
        // visited root
        previous.Add(root);

        this.FlattenHelper(root.left, previous);
        this.FlattenHelper(root.right, previous);
    }
}