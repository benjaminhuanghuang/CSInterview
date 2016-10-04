
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        ListNode head = ListNode.BuildList(new int[]{1,2});
        var s = new Solution061();
        Console.WriteLine(s.RotateRight(head, 1));         
    }
}