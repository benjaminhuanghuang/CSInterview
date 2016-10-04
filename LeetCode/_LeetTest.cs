
using System;
using System.IO;
using System.Collections;

public class LeetTest {
    public static void Main(string[] args)
    {   
        var input = "abccccdd";
        var s = new Solution409();
        Console.WriteLine(s.LongestPalindrome(input));         
    }
}