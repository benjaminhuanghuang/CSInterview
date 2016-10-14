/*
138. Copy List with Random Pointer

A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.

Return a deep copy of the list.

*/

using System.Collections.Generic;

//* Definition for singly-linked list with a random pointer.
public class RandomListNode {
    public int label;
    public RandomListNode next, random;
    public RandomListNode(int x) { this.label = x; }
};

public class Solution138 {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if (head == null) 
            return null;
        var dict = new Dictionary<RandomListNode, RandomListNode>();
        var start = head;
        // put <origianl, copied> pair into dict
        while (start != null)
        {
            dict.Add(start, new RandomListNode(start.label));
            start = start.next;
        }

        start = head;
        var res = dict[start];
        while (start != null)
        {
            var newstart = dict[start];
            newstart.next = start.next != null ? dict[start.next] : null;
            newstart.random = start.random != null ? dict[start.random] : null;

            start = start.next;
        }

        return res;
    }
}