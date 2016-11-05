
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var s = new Solution385();
        //var result = s.FindAnagrams("abab", "ab");
        var result = s.Deserialize("[-1,-2]");  // [0,6]

        Console.WriteLine(result);

    }
}