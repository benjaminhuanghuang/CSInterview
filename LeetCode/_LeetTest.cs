
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public class LeetTest {
    public static void Main(string[] args)
    {   
        string S = "ADOBECODEBANC";
        string T = "ABC";

        var s = new Solution076();
        var res = s.MinWindow(S, T);

        Console.WriteLine(res);
    }
}