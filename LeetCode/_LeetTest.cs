
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution402();
        int[,] input = new int[,] { { 5, 4 }, { 6, 4 }, { 6, 7 }, { 2, 3 } };
        //var result = s.FindAnagrams("abab", "ab");
        var result = s.RemoveKdigits("10",2);  // [0,6]

        Console.WriteLine(result);

    }
}