
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var head = new ListNode(3);
        head.next = new ListNode(5);
        var s = new Solution092();
        var res = s.ReverseBetween(head, 1, 2);

        Console.WriteLine(res);   
    }
}