
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        int[,] input = new int[,]{ {8, 30} };
        var s = new Solution060();
        Console.WriteLine(s.GetPermutation(8, 20));         
    }
}