/*
23. Merge k Sorted Lists

Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
using System;
using System.Collections.Generic;

// https://miafish.wordpress.com/2015/01/27/leetcode-oj-c-merge-k-sorted-lists/
public class Solution023 {
    //  public ListNode MergeKLists_MiniHeap(ListNode[] lists) {
    //         var fakehead = new ListNode(-1);
    //         var start = fakehead;
    //         var heap = new Heap();

    //         foreach (var headnode in lists)
    //         {
    //             if (headnode != null)
    //             {
    //                 heap.Add(headnode);
    //             }
    //         }

    //         while (heap.Any())
    //         {
    //             var top = heap.GetMin();

    //             start.next = top;
    //             start = start.next;

    //             if (top.next != null)
    //             {
    //                 heap.Add(top.next);
    //             }
    //         }

    //         return fakehead.next; 
    // }
    public ListNode MergeKLists(ListNode[] lists) {
        var dummyhead = new ListNode(-1);

        return null;
    }
}