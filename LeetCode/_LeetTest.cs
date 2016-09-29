
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        ListNode l1 = new ListNode(1);
        l1.next = new ListNode(2);
        l1.next.next = new ListNode(3);
        l1.next.next.next = new ListNode(4);
        
        var s = new Solution025();
        var res = s.ReverseKGroup(l1,3);     
    
    }
}