/*
24. Swap Nodes in Pairs

Given a linked list, swap every two adjacent nodes and return its head.

For example,
Given 1->2->3->4, you should return the list as 2->1->4->3.

Your algorithm should use only constant space. You may not modify the values in the list, 
only nodes itself can be changed.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution024 {
    public ListNode SwapPairs(ListNode head) {
        if (head == null)
            return null;

        ListNode dummyhead = new ListNode(-1);
        ListNode tail = dummyhead;

        while (head !=null && head.next != null)
        {

        }
        return dummyhead.next;
    }
}

