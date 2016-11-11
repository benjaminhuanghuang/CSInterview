/*
Check if a binary tree is subtree of another binary tree

Given two binary trees, check if the first tree is subtree of the second one. 
A subtree of a tree T is a tree S consisting of a node in T and all of its descendants in T.

We can do it since we know that preorder(postorder) and inorder can fix the tree. (we need to make the NULL values)

Find inorder and preorder traversals of T, store them in two auxiliary arrays inT[] and preT[].
Find inorder and preorder traversals of S, store them in two auxiliary arrays inS[] and preS[].
If inS[] is a subarray of inT[] and preS[] is a subarray preT[], then S is a subtree of T. Else not.
*/

public class Solution_IsSubTree {
    private bool IsSubTree(TreeNode rootNode, TreeNode node)
    {
        if (node == null)
        {
            return true;
        }

        if (rootNode == null)
        {
            return false;
        }

        // if find the data and compare success, return true;
        // otherwise travesal the tree again to find the node with the same
        // data as node
        if (rootNode.data.Equals(node.data))
        {
            if (this.IsEqualTree(rootNode, node)) return true;
        }

        return this.IsSubTree(rootNode.leftNode, node) || this.IsSubTree(rootNode.rightNode, node);
    }

    private bool IsEqualTree(TreeNode node1, TreeNode node2)
    {
        if (node2 == null)
        {
            return true;
        }

        if (node1 == null)
        {
            return false;
        }

        if (!node2.data.Equals(node1.data))
        {
            return false;
        }

        return this.IsEqualTree(node1.leftNode, node2.leftNode)
            && this.IsEqualTree(node1.rightNode, node2.rightNode);
    }