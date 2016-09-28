/*
25. Reverse Nodes in k-Group

Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.

You may not alter the values in the nodes, only nodes itself may be changed.

Only constant memory is allowed.

For example,
Given this linked list: 1->2->3->4->5

For k = 2, you should return: 2->1->4->3->5

For k = 3, you should return: 3->2->1->4->5

*/



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution025 {
    public ListNode ReverseKGroup(ListNode head, int k) {
        
    }

    public ListNode ReverseListNode(ListNode start, ListNode end)
    {
        ListNode prev = new ListNode(-1){next = start};
        while (prev.next != end)
        {
            var tmp = start.next;
            start.next = tmp.next;
            tmp.next = prev.next;
            prev.next = tmp;
        }
    }

    public ListNode ReverseList(ListNode head)
    {
        var prev = new ListNode(-1);

        while (head != null)
        {
            var next = head.next;

            head.next = prev.next;
            prev.next = head;

            head = next;
        }

        return prev.next;
    }
}