/*
234. Palindrome Linked List   QuestionEditorial Solution  My Submissions

Given a singly linked list, determine if it is a palindrome.

Follow up:
Could you do it in O(n) time and O(1) space?
*/


public class Solution {
    // Method space O(N)
    // put all values in a array, then check the values
    /

    public bool IsPalindrome(ListNode head) {
        Result p = this.IsPalindromeRecurse(rootNode, Listsize(rootNode));
        return p.result;
    }

    internal Result IsPalindromeRecurse(Node head, int length)
        {
            if (head == null || length == 0)
            {
                return new Result(null, true);
            }
            else if(length == 1)
            {
                return new Result(head.Next, true);
            }
            else if(length == 2)
            {
                return new Result(head.Next.Next, head.Value == head.Next.Value);
            }

            Result res = this.IsPalindromeRecurse(head.Next, length - 2);
            if (!res.result || res.Node == null)
            {
                return res;
            }
            else
            {
                res.result = head.Value == res.Node.Value;
                res.Node = res.Node.Next;
                return res;
            }
        }
    private int Listsize(Node rootNode)
    {
        var count = 0;
        while (rootNode!= null)
        {
            rootNode = rootNode.Next;
            count++;
        }

        return count;
    }
    // reverse the half part of the linked list and then use two points, one from, another from mid, 
    // scan and compare to check it is palindrome or not.
     public bool IsPalindrome(ListNode head) {
        if (head == null) return true;
        var count = 0;
        var start = head;
        while (start != null)
        {
            start = start.next;
            count++;
        }
        head = ReverseBetween(head, (int)Math.Ceiling(count/2.0) + 1, count);

        var index = 1;
        var end = head;
        while (index < Math.Ceiling(count/2.0) + 1)
        {
            end = end.next;
            index++;
        }

        start = head;
        while (end != null)
        {
            if (start.val != end.val)
            {
                return false;
            }

            end = end.next;
            start = start.next;
        }

        return true;      
    }
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            var fakehead = new ListNode(-1);
            fakehead.next = head;

            var start = fakehead;
            var count = 1;
            while (count < m)
            {
                start = start.next;
                count++;
            }

            var next = start.next;
            while (count++ < n)
            {
                var firstNode = next.next;
                next.next = firstNode.next;
                firstNode.next = start.next;
                start.next = firstNode;
            }

            return fakehead.next;
        }
}