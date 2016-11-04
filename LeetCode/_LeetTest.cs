
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution372();
        //var result = s.FindAnagrams("abab", "ab");
        var result = s.SuperPow(2147483647, new int[]{2,0,0});  // [0,6]

        Console.WriteLine(result);

    }
}