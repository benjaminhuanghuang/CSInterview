
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution438();
        //var result = s.FindAnagrams("abab", "ab");
        var result = s.FindAnagrams_2("cbaebabacd", "abc");  // [0,6]
        foreach (var i in result)
        {
            Console.WriteLine(i);   
        }

    }
}