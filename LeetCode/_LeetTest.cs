
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        string S = "AAADOBECODEBANC";
        string T = "ABB";

        var s = new Solution076();
        var res = s.MinWindow(S, T);

        Console.WriteLine(res);   
    }
}