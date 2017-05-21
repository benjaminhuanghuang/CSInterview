
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest
{
    public static void Main(string[] args)
    {
        var input = new int[] { 8, 16, 24, 32, 40, 48, 56, 64, 72, 80, 88, 96, 104, 112, 60 };
        var s = new Solution473();
        Console.WriteLine(s.Makesquare(input));
    }
}