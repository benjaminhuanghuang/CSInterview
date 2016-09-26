
using System;
using System.IO;


public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution004();
        var p1 = new int[]{};
        var p2 = new int[]{1};
        var n = s.FindMedianSortedArrays_Naive(p1,p2);    
        Console.WriteLine(n);
    }
}