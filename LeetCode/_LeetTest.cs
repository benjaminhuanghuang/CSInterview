
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution086();
        var res = s.Partition(new ListNode(1), 0);

        Console.WriteLine(res);   
    }
}