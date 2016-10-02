
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        int[] input = new int[]{2,3,1,1,4};
        var s = new Solution052();
        Console.WriteLine(s.TotalNQueens(4));         
    }
}